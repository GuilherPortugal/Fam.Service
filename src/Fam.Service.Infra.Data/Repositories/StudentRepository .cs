using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Fam.Service.Domain.Models;
using Fam.Service.Models.Dtos;
using Fam.Service.Repository.Interfaces;
using Microsoft.Data.SqlClient;

namespace Fam.Service.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private string strConnection = "Server=DESKTOP-C4LDS6R\\SQLSERVER2022;Database=Fam;User Id=Guilherme;Password=1234;";

        public async Task<StudentDto> GetAsync(string registrationNumber)
        {
            using (var con = new SqlConnection(strConnection))
            {
                var sql = $@"select a.userId, 
                                    a.classId,
                                    a.ra, 
                                    a.name, 
                                    a.registrationNumber, 
                                    a.dateOfBirth, 
                                    a.address, 
                                    a.numberAddress, 
                                    a.country, 
                                    a.sex,
                                    b.id,
                                    b.name as Course,
                                    b.period as ClassPeriod
                               from students a
                              inner join class b 
                                 on b.id = a.classId
                              where a.registrationNumber = '{registrationNumber}'
                                and a.deleted = 0";

                var result = await con.QueryAsync<StudentDto>(sql, null);

                var student = result.FirstOrDefault();

                var schedulesSql = $@"select b.id, 
                                             b.description, 
                                             b.sheduleStart, 
                                             b.sheduleEnd
                                        from classSchedules a
                                       inner join Schedules b
                                          on b.id = a.SheduleId
                                       WHERE a.classId = '{student.ClassId}'";


                student.Shedules = (await con.QueryAsync<SchedulesDto>(schedulesSql, null)).ToList();

                return student;
            }
        }
    }
}
