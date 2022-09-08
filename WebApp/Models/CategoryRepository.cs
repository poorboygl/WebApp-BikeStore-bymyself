using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CategoryRepository : BaseRepository
    {
        public CategoryRepository(IDbConnection connetion) : base(connetion) { }
        public IEnumerable<Category> GetCategories()
        {
            string sql = "Select*from Category";
            return connection.Query<Category>(sql);
        }
        public IEnumerable<Statistic> GetStatistics()
        {
            return connection.Query<Statistic>("StatisticCategories", commandType: CommandType.StoredProcedure);
        }
    }

}
