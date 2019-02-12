using System;
using System.Collections.Generic;
using System.Data;

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

        private List<IDbDataParameter> ParametersList =>
            (List<IDbDataParameter>)_oracleParameters.Parameters;
    }
}
