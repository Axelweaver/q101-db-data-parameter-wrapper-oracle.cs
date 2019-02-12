using System.Data;

namespace Q101.DbDataParameterWrapper.Oracle.Parameters
{
    /// <summary>
    /// Создатель параметра Oracle
    /// </summary>
    public class OracleParameterCreator : IDbParameterCreator
    {
        /// <summary>
        /// Конвертер типов параметров
        /// </summary>
        private readonly IOracleDbTypesConverter _typeConverter;

        /// <summary>
        /// Создатель параметра Oracle
        /// </summary>
        /// <param name="typeConverter"></param>
        public OracleParameterCreator(IOracleDbTypesConverter typeConverter)
        {
            _typeConverter = typeConverter;
        }

        /// <summary>
        /// Создать параметер
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="type">Тип параметра</param>
        /// <param name="value">Значеие</param>
        /// <param name="direction">Направление</param>
        /// <param name="size">Размер</param>
        /// <returns></returns>
        public IDbDataParameter Create(string name,
                                        ParameterDbType type,
                                        object value,
                                        ParameterDirection direction,
                                        int? size = null)
        {
            var oraType = _typeConverter.Convert(type);

            var parameter = new OracleParameter(
                name,
                oraType,
                value,
                direction
            );

            if (size.HasValue)
            {
                parameter.Size = size.Value;
            }

            return parameter;
        }
    }
}
