using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;

namespace Q101.DbDataParameterWrapper.Oracle.Converters
{
    /// <summary>
    /// Converter DataBase types
    /// </summary>
    public class OracleDbTypesConverter : IOracleDbTypesConverter
    {
        /// <summary>
        /// Dictionary to convert
        /// </summary>
        private readonly Dictionary<ParameterDbType, OracleDbType> _convertDictionary
            = new Dictionary<ParameterDbType, OracleDbType>()
            {
                { ParameterDbType.Varchar2, OracleDbType.Varchar2 },
                { ParameterDbType.Varchar, OracleDbType.NVarchar2 },
                { ParameterDbType.NVarchar2, OracleDbType.NVarchar2 },
                { ParameterDbType.Number, OracleDbType.Int32 },
                { ParameterDbType.Int, OracleDbType.Int32 },
                { ParameterDbType.Int64, OracleDbType.Int64 },
                { ParameterDbType.Decimal, OracleDbType.Decimal },
                { ParameterDbType.Bool, OracleDbType.Boolean },
                { ParameterDbType.Byte, OracleDbType.Byte },
                { ParameterDbType.Date, OracleDbType.Date },
                { ParameterDbType.DateTime, OracleDbType.TimeStamp }
            };

        /// <summary>
        /// To Convert into database type
        /// </summary>
        /// <param name="paramType"></param>
        /// <returns></returns>
        public OracleDbType Convert(ParameterDbType paramType)
        {
            var oracleType = _convertDictionary[paramType];

            return oracleType;
        }
    }
}
