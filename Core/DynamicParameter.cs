using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class DynamicParameter
    {
        Dictionary<string, Parameter> parameter = new Dictionary<string, Parameter>();
        public void Add(string name, object value=null, DbType dbbType = DbType.String, ParameterDirection direction = ParameterDirection.Input)
        {
            parameter[name] = new Parameter
            {
                Name = name,
                Value = value,
                DbType = dbbType,
                Direction = direction
            };
        }
        public void Handle(IDbCommand command)
        {
            foreach (Parameter item in parameter.Values)
            {
                IDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = item.Name;
                parameter.Value = item.Value;
                parameter.Direction = item.Direction;
                parameter.DbType = item.DbType;
                command.Parameters.Add(parameter);
            }
        }
    }
}
