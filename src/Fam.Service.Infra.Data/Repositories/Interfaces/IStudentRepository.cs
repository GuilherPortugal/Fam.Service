using System.Threading.Tasks;
using Fam.Service.Domain.Models;
using Fam.Service.Models.Dtos;

namespace Fam.Service.Repository.Interfaces
{
    public interface IStudentRepository
    {
        Task<StudentDto> GetAsync(string registrationNumber);
    }
}
