using System.Threading.Tasks;
using Fam.Service.Models.Dtos;

namespace Fam.Service.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDto> GetAsync(string login, string password);
    }
}
