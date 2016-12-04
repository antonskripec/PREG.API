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

        private static Fields CreateErrandFields()
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
                Name = "ResponsibleManagerId",
                Type = typeof(int)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 2,
                Name = "ErrandTypeId",
                Type = typeof(int)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 3,
                Name = "Comment",
                Type = typeof(string)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 4,
                Name = "Created",
                Type = typeof(DateTime)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 5,
                Name = "CurrentPhaseId",
                Type = typeof(int)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 7,
                Name = "EventDescription",
                Type = typeof(string)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 8,
                Name = "EstimatedEndDate",
                Type = typeof(DateTime?)
            });

            return returnFields;
        }


        private static Fields CreateErrandTypeFields()
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
                Name = "ErrandTypeGroupId",
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


        private static Fields CreateIdNameFields()
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


            return returnFields;
        }

        private static Fields CreateIdNameFullnameTimestampFields()
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
                Name = "PermissionId",
                Type = typeof(string)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 3,
                Name = "Created",
                Type = typeof(DateTime)
            });

            returnFields.Add(new FieldInfo
            {
                OrdinalPosition = 4,
                Name = "FullName",
                Type = typeof(string)
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

            ////Permissions.
            //LoadPermissions(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameFields());

            ////Users.
            //LoadUser(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameFullnameTimestampFields());

            ////Approval procedures.
            //LoadApprovalProcedures(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            ////Distributors.
            //LoadDistributors(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            ////Dosage forms.
            //LoadDosageForms(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            ////Manufacturers.
            //LoadManufacturers(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            ////Open Storage.
            //LoadOpenStorage(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            ////Package type.
            //LoadPackageType(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            ////Package detail type.
            //LoadPackageDetailType(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            ////Responsible managers.
            //LoadResponsibleManagers(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());

            ////Errand type groups and Errand types.
            //LoadErrandTypeGroups(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());
            //LoadErrandTypes(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateErrandTypeFields());

            ////Phase groups and phases.
            //LoadPhaseGroups(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateIdNameTimestampFields());
            //LoadPhases(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreatePhasesFields());
            LoadErrands(bulkCopyDataIntoSqlServer, directoryInfo, userName, CreateErrandFields());


            Console.WriteLine("Finished loading data");

            Console.ReadKey();
        }

        private static void LoadOpenStorage(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading Open Storage.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "OpenStorages",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "OPEN_STORAGE.XLSX"),
                userName);

            Console.WriteLine("Finished loading Open Storage.");
        }

        private static void LoadPackageType(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading Package Type.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "PackageTypes",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "PACKAGE_TYPE.XLSX"),
                userName);

            Console.WriteLine("Finished loading Package Type.");
        }

        private static void LoadUser(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading Users.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "Users",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "PREG_USER.XLSX"),
                userName);

            Console.WriteLine("Finished loading Users.");
        }

        private static void LoadResponsibleManagers(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading Responsible Managers.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "ResponsibleManagers",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "RESPONSIBLE_MANAGER.XLSX"),
                userName);

            Console.WriteLine("Finished loading Responsible Managers.");
        }

        private static void LoadPermissions(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading Permissions.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "Permissions",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "PERMISSION.XLSX"),
                userName);

            Console.WriteLine("Finished loading Permissions.");
        }

        private static void LoadPackageDetailType(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
            DirectoryInfo directoryInfo,
            string userName,
            Fields fields)
        {
            Console.WriteLine("Start loading Package Detail Type.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                "PackageDetailTypes",
                Settings.Default.ConnectionString,
                Path.Combine(directoryInfo.FullName, "PACKAGE_DETAIL_TYPE.XLSX"),
                userName);

            Console.WriteLine("Finished loading Package Detail Type.");
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

        private static void LoadManufacturers(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
                                                DirectoryInfo directoryInfo,
                                                string userName,
                                                Fields fields)
        {
            Console.WriteLine("Start loading Manufacturers.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                                                "Manufacturers",
                                                Settings.Default.ConnectionString,
                                                Path.Combine(directoryInfo.FullName, "MANUFACTURER.XLSX"),
                                                userName);

            Console.WriteLine("Finished loading Manufacturers.");
        }

        private static void LoadErrands(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
                                        DirectoryInfo directoryInfo,
                                        string userName,
                                        Fields fields)
        {
            Console.WriteLine("Start loading Errands.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                                                "Errands",
                                                Settings.Default.ConnectionString,
                                                Path.Combine(directoryInfo.FullName, "ERRAND.XLSX"),
                                                userName);

            Console.WriteLine("Finished loading Errands.");
        }

        private static void LoadErrandTypes(BulkCopyDataIntoSqlServer bulkCopyDataIntoSqlServer,
                                            DirectoryInfo directoryInfo,
                                            string userName,
                                            Fields fields)
        {
            Console.WriteLine("Start loading Errand types.");

            bulkCopyDataIntoSqlServer.LoadTable(fields,
                                                "ErrandTypes",
                                                Settings.Default.ConnectionString,
                                                Path.Combine(directoryInfo.FullName, "ERRAND_TYPE.XLSX"),
                                                userName);

            Console.WriteLine("Finished loading Errand types.");
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