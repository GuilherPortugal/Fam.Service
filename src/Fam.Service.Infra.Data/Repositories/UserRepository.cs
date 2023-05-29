using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Fam.Service.Models.Dtos;
using Fam.Service.Repository.Interfaces;
using Microsoft.Data.SqlClient;

namespace Fam.Service.Repository
{
    public class UserRepository : IUserRepository
    {
        private string strConnection = "Server=DESKTOP-C4LDS6R\\SQLSERVER2022;Database=Fam;User Id=Guilherme;Password=1234;";

        public async Task<UserDto> GetAsync(string login, string password)
        {
            var sql = $"SELECT id, login, password FROM users WHERE login = '{login}' AND password = '{password}'";

            using (var con = new SqlConnection(strConnection))
            {
                var result = await con.QueryAsync<UserDto>(sql, null);

                return result.FirstOrDefault();
            }
        }
    }
}

