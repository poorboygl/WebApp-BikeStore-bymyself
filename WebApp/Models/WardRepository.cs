using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class WardRepository : BaseRepository
    {
        public WardRepository(IDbConnection connetion) : base(connetion) { }
        public IEnumerable<Ward> GetWards(string districtID)
        {
            return connection.Query<Ward>("Select * from Ward where DistrictID = @id", new { id = districtID });
        }
    }
}
