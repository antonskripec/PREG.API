using System;

namespace MigrateFromOracleToSql
{
    public class FieldInfo
    {
        public int OrdinalPosition { get; set; }

        public string Name { get; set; }

        public Type Type { get; set; }
    }
}