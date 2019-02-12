using System.Collections.Generic;
using System.Data;
using Q101.DbDataParameterWrapper.Parameters;

namespace Q101.DbDataParameterWrapper.Oracle.Parameters
{
    /// <inheritdoc />
    public class OracleParameters : IDbParameters
    {
        /// <inheritdoc />
        public IDbParameterDirectionCreator Input { get; }

        /// <inheritdoc />
        public IDbParameterDirectionCreator Output { get; }

        /// <inheritdoc />
        public IDbParameterDirectionCreator InputOutput { get; }

        /// <inheritdoc />
        public IDbParameterDirectionCreator ReturnValue { get; }


        private IEnumerable<IDbDataParameter> _parameters;

        /// <inheritdoc />
        public IEnumerable<IDbDataParameter> Parameters
        {
            get
            {
                _parameters = _parameters ?? new List<IDbDataParameter>();
                return _parameters;
            }
            set { _parameters = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputOracleParameterDirectionCreator"></param>
        /// <param name="outputOracleParameterDirectionCreator"></param>
        /// <param name="inputOutputParameterDirectionCreator"></param>
        /// <param name="returnValueParameterDirectionCreator"></param>
        public OracleParameters(IDbParameterDirectionCreator inputOracleParameterDirectionCreator,
                                IDbParameterDirectionCreator outputOracleParameterDirectionCreator,
                                IDbParameterDirectionCreator inputOutputParameterDirectionCreator,
                                IDbParameterDirectionCreator returnValueParameterDirectionCreator)
        {
            Input = inputOracleParameterDirectionCreator;

            Input.SetDirection(ParameterDirection.Input, this);

            Output = outputOracleParameterDirectionCreator;

            Output.SetDirection(ParameterDirection.Output, this);

            InputOutput = inputOutputParameterDirectionCreator;

            InputOutput.SetDirection(ParameterDirection.InputOutput, this);

            ReturnValue = returnValueParameterDirectionCreator;

            ReturnValue.SetDirection(ParameterDirection.ReturnValue, this);
        }
    }
}
