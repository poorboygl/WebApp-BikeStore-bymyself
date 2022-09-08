using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WebApp.Models
{
    public class AccountRepository : BaseRepository
    {
        public AccountRepository(IDbConnection connetion) : base(connetion) { }
        static byte[] Hash(string plaintext)
        {
            HashAlgorithm hash = HashAlgorithm.Create("SHA512");
            return hash.ComputeHash(Encoding.ASCII.GetBytes(plaintext));
        }
        public Account SignIn(SignInModel obj)
        {
            string sql = "select AccountID, Username, Email From Account where Username = @Usr And Password = @Pwd";
            return connection.QuerySingleOrDefault<Account>(sql, new { obj.Usr, Pwd = Hash(obj.Pwd) });
        }
    }
}
