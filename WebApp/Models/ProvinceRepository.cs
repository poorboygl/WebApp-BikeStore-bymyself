using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ProvinceRepository : BaseRepository
    {
        public ProvinceRepository(IDbConnection connetion) : base(connetion) { }
        public IEnumerable<Province> GetProvinces()
        {
            return connection.Query<Province>("Select * from Province");
        }
    }
}
