using System.Threading.Tasks;
using Fam.Service.Models.Dtos;
using Fam.Service.Repository.Interfaces;
using Microsoft.Data.SqlClient;

namespace Fam.Service.Repository
{
    public class UserRepository : IUserRepository
    {
        private string strConnection = "Server=DESKTOP-C4LDS6R\\SQLSERVER2022;Database=Fam;User Id=Guilherme;Password=1234;";

        public async Task<UserDto> Get(string login, string password)
        {
            var sql = $"SELECT id, login, password FROM users WHERE login = '{login}' AND password = '{password}'";

            using (var con = new SqlConnection(strConnection))
            {
                await con.OpenAsync();

                using (var cmd = new SqlCommand(sql, con))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        var user = new UserDto
                        {
                            Id = reader["id"].ToString(),
                            Login = reader["login"].ToString(),
                            Password = reader["password"].ToString()
                        };

                        return user;
                    }
                }
            }

            return null; // Se o usuário não for encontrado, retorna null
        }
    }
}
