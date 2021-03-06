﻿using Oracle.ManagedDataAccess.Client;
using Q101.DbDataParameterWrapper.Enums;

namespace Q101.DbDataParameterWrapper.Oracle.Converters
{
    /// <summary>
    /// Database parameters types converter
    /// </summary>
    public interface IOracleDbTypesConverter
    {
        /// <summary>
        /// To convert
        /// </summary>
        /// <param name="paramType"></param>
        /// <returns></returns>
        OracleDbType Convert(ParameterDbType paramType);
    }
}
