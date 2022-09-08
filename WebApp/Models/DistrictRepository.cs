using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class DistrictRepository : BaseRepository
    {
        public DistrictRepository(IDbConnection connetion) : base(connetion) { }
        public IEnumerable<District> GetDistricts(string providerID)
        {
            return connection.Query<District>("Select * from District where ProvinceID = @id", new { id = providerID });
        }
    }
}
