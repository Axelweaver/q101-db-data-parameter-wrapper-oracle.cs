using System;
using System.Collections.Generic;
using System.Data;
using Q101.DbDataParameterWrapper.Enums;
using Q101.DbDataParameterWrapper.Parameters;

namespace Q101.DbDataParameterWrapper.Oracle.Parameters
{
    /// <summary>
    /// Создатель входящих параметров Oracle
    /// </summary>
    public class OracleParameterDirectionCreator : IDbParameterDirectionCreator
    {

        private IDbParameters _oracleParameters;

        /// <summary>
        /// Создатель параметров
        /// </summary>
        private readonly Func<string, ParameterDbType, object, int?, IDbDataParameter> _oracleParameterCreatе;

        /// <summary>
        /// Направление создаваемых параметров
        /// </summary>
        private ParameterDirection _direction;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oracleParameterCreator">Создатель параметров</param>
        public OracleParameterDirectionCreator(IDbParameterCreator oracleParameterCreator)
        {
            _oracleParameterCreatе = (name, type, value, size) =>
                oracleParameterCreator.Create(name, type, value, _direction, size);
        }

        /// <inheritdoc />
        public void SetDirection(ParameterDirection direction, IDbParameters oracleParameters)
        {
            _direction = direction;

            _oracleParameters = oracleParameters;
        }

        /// <inheritdoc />
        public IDbDataParameter Date(string name, object value = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.Date, value, null);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddDate(string name, object value = null)
        {
            var parameter = Date(name, value);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }


        /// <inheritdoc />
        public IDbDataParameter DateTime(string name, object value = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.DateTime, value, null);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddDateTime(string name, object value = null)
        {
            var parameter = DateTime(name, value);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }


        /// <inheritdoc />
        public IDbDataParameter TimeStamp(string name, object value = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.TimeStamp, value, null);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddTimeStamp(string name, object value = null)
        {
            var parameter = TimeStamp(name, value);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }

        /// <inheritdoc />
        public IDbDataParameter Varchar2(string name, object value = null, int? size = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.Varchar2, value, size);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddVarchar2(string name, object value = null, int? size = null)
        {
            var parameter = Varchar2(name, value, size);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }


        /// <inheritdoc />
        public IDbDataParameter Varchar(string name, object value = null, int? size = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.Varchar, value, size);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddVarchar(string name, object value = null, int? size = null)
        {
            var parameter = Varchar(name, value, size);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }

        /// <inheritdoc />
        public IDbDataParameter NVarchar(string name, object value = null, int? size = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.NVarchar2, value, size);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddNVarchar(string name, object value = null, int? size = null)
        {
            var parameter = NVarchar(name, value, size);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }

        /// <inheritdoc />
        public IDbDataParameter Number(string name, object value = null, int? size = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.Number, value, size);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddNumber(string name, object value = null, int? size = null)
        {
            var parameter = Number(name, value, size);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }
 
        /// <inheritdoc />
        public IDbDataParameter Int(string name, object value = null, int? size = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.Int, value, size);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddInt(string name, object value = null, int? size = null)
        {
            var parameter = Int(name, value, size);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }
 
        /// <inheritdoc />
        public IDbDataParameter Int64(string name, object value = null, int? size = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.Int64, value, size);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddInt64(string name, object value = null, int? size = null)
        {
            var parameter = Int64(name, value, size);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }
 
        /// <inheritdoc />
        public IDbDataParameter Decimal(string name, object value = null, int? size = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.Decimal, value, size);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddDecimal(string name, object value = null, int? size = null)
        {
            var parameter = Decimal(name, value, size);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }

        /// <inheritdoc />
        public IDbDataParameter Byte(string name, object value = null, int? size = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.Byte, value, size);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddByte(string name, object value = null, int? size = null)
        {
            var parameter = Byte(name, value, size);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }
 
        /// <inheritdoc />
        public IDbDataParameter Bool(string name, object value = null, int? size = null)
        {
            var parameter = _oracleParameterCreatе(name, ParameterDbType.Bool, value, size);

            return parameter;
        }

        /// <inheritdoc />
        public IDbParameters AddBool(string name, object value = null, int? size = null)
        {
            var parameter = Bool(name, value, size);

            ParametersList.Add(parameter);

            return _oracleParameters;
        }

       private List<IDbDataParameter> ParametersList =>
            (List<IDbDataParameter>)_oracleParameters.Parameters;
    }
}
