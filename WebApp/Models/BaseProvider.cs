using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public abstract class BaseProvider
    {
        IConfiguration configuration;
        IDbConnection connection;
        protected IDbConnection Connection
        {
            get
            {
                if (connection is null)
                {
                    connection = new SqlConnection(configuration.GetConnectionString("StoreDapper"));
                }
                return connection;
            }
        }
        public BaseProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }
}
