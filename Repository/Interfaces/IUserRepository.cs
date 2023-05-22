using System.Threading.Tasks;
using Fam.Service.Models.Dtos;

namespace Fam.Service.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDto> Get(string login, string password);
    }
}
