using System;
using System.IO;
using System.Security.Principal;
using MigrateFromOracleToSql.Properties;

namespace MigrateFromOracleToSql
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LoadData();
        }

        private static Fields CreatePhasesFields()
        {
            var returnFields = new Fields();

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 0,
                Name = "Id",
                Type = typeof(int)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 1,
                Name = "Name",
                Type = typeof(string)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 2,
                Name = "PhaseGroupId",
                Type = typeof(int)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 3,
                Name = "Created",
                Type = typeof(DateTime)
            });

            return returnFields;
        }



        private static Fields CreateIdNameTimestampFields()
        {
            var returnFields = new Fields();

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 0,
                Name = "Id",
                Type = typeof(int)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 1,
                Name = "Name",
                Type = typeof(string)
            });


            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 2,
                Name = "Created",
                Type = typeof(DateTime)
            });

            return returnFields;
        }

        private static void LoadData()
        {
            var userName = WindowsIdentity.GetCurrent().Name;

            Console.WriteLine("Start loading data.");

            var directoryInfo = new DirectoryInfo("D:\\Projects\\PREG_Database\\");

            var bulkCopyDataIntoSqlServer = new BulkCopyDataIntoSqlServer();

            //Approval procedures.
            LoadApprovalProcedures(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            //Distributors.
            LoadDistributors(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            //Dosage forms.
            LoadDosageForms(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            //Errand type groups and Errand types.
            LoadErrandTypeGroups(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());


            //Phase groups and phases.
            LoadPhaseGroups(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());
            LoadPhases(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreatePhasesFields());



            Console.WriteLine("Finished loading data");

            Console.ReadKey();
        }

        private static void LoadPhases(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading Phases.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "Phases",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "PHASE.XLSX"),
                userName);

            Console.WriteLine("Finished loading Phases.");
        }

        private static void LoadPhaseGroups(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading PhaseGroups.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "PhaseGroups",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "PHASE_GROUP.XLSX"),
                userName);

            Console.WriteLine("Finished loading PhaseGroups.");
        }

        private static void LoadErrandTypeGroups(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
                                            DirectoryInfo directoryInfo,
                                            string userName,
                                            Fields fields)
        {
            Console.WriteLine("Start loading Errand type groups.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "ErrandTypeGroups",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "ERRAND_TYPE_GROUP.XLSX"),
                userName);

            Console.WriteLine("Finished loading Errand type groups.");
        }

        private static void LoadDosageForms(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading DosageForms.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "DosageForms",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "DOSAGE_FORM.XLSX"),
                userName);

            Console.WriteLine("Finished loading DosageForms.");
        }

        private static void LoadDistributors(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading Distributors.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "Distributors",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "DISTRIBUTOR.XLSX"), userName);

            Console.WriteLine("Finished loading Distributors.");
        }

        private static void LoadApprovalProcedures(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading Approval procedures");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "ApprovalProcedures",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "APPROVAL_PROCEDURE.XLSX"),
                userName);

            Console.WriteLine("Finished loading Approval procedures");
        }
    }
}