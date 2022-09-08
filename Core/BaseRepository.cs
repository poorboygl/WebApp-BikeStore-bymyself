using System;
using System.Collections.Generic;
using System.Data;

namespace Core
{
    public abstract class BaseRepository<T>
    {
        protected IDbConnection connection;
        public BaseRepository(IDbConnection connection)
        {
            this.connection = connection;
        }
        protected int Save(string sql, DynamicParameter parameter, CommandType commandType=CommandType.Text)
        {
            using (IDbCommand command =connection.CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = commandType;
                parameter.Handle(command);
                return command.ExecuteNonQuery();
            }
        }
        public T FetchOne(string sql, DynamicParameter parameter, CommandType commandType=CommandType.Text)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = commandType;
                parameter.Handle(command);
                using (IDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        return Fetch(reader);
                    };
                    return default(T);
                }
            }
        }
        public List<T> FetchAll(string sql,IRowMapper<T> mapper, CommandType commandType=CommandType.Text)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = commandType;
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<T> list = new List<T>();
                    while (reader.Read())
                    {
                        list.Add(mapper.MapRow(reader));
                    }
                    return list;
                }
            }
        }
        public List<T> FetchAll(string sql, DynamicParameter parameter, CommandType commandType=CommandType.Text)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = commandType;
                if (parameter !=null)
                {
                    parameter.Handle(command);
                }
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<T> list = new List<T>();
                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }
                    return list;
                }
            }
        }
        protected abstract T Fetch(IDataReader reader);
    }

}
