using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ClosedXML.Excel;

namespace MigrateFromOracleToSql
{
    public class BulkCopyDataIntoSqlServer
    {
        public void LoadTable(Fields fields,
            string tableName,
            string connectionstring,
            string excelFile,
            string userName)
        {
            var parameters = fields.OrderBy(info => info.OrdinalPosition);

            var dataTable = new DataTable(tableName);

            foreach (var parameter in parameters)
            {
                dataTable.Columns.Add(parameter.Name, parameter.Type);
            }

            dataTable.Columns.Add("CreatedBy", typeof(string));

            using (var sqlConnection = new SqlConnection(connectionstring))
            {
                sqlConnection.Open();

                using (var sqlCommand = new SqlCommand("DELETE " + tableName, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }

                var sqlBulkCopy = new SqlBulkCopy(sqlConnection, SqlBulkCopyOptions.KeepIdentity, null)
                {
                    DestinationTableName = tableName
                };

                foreach (var parameter in parameters)
                {
                    sqlBulkCopy.ColumnMappings.Add(parameter.Name, parameter.Name);
                }
                sqlBulkCopy.ColumnMappings.Add("CreatedBy", "CreatedBy");

                var workbook1 = new XLWorkbook(excelFile);
                var ws1 = workbook1.Worksheet(1);
                var row = 2;

                while (true)
                {
                    List<string> values=new List<string>();

                    foreach (var parameter in parameters)
                    {
                        var cellValue= 
                            ws1.Cell(row, parameter.OrdinalPosition+1).Value.ToString();

                        values.Add(cellValue);
                    }

                    var hasData = !values.Any(string.IsNullOrEmpty);

                    if (hasData)
                    {
                        values.Add(userName);

                        var dataRow =
                            dataTable.Rows.Add(values.ToArray());
                    }
                    else
                    {
                        break;
                    }

                    row++;
                }

                if (dataTable.Rows.Count > 0)
                    InsertDataTable(sqlBulkCopy, sqlConnection, dataTable);

                sqlConnection.Close();
            }
        }

        protected void InsertDataTable(SqlBulkCopy sqlBulkCopy,
            SqlConnection sqlConnection,
            DataTable dataTable)
        {
            sqlBulkCopy.WriteToServer(dataTable);

            dataTable.Rows.Clear();
        }
    }
}