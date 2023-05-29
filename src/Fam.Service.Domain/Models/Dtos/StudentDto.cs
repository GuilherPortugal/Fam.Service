using System;
using System.Collections.Generic;

namespace Fam.Service.Domain.Models
{
    public class StudentDto
    {
        public string Id { get; set; }
        public string ClassId { get; set; }
        public string UserId { get; set; }
        public string Course { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int NumberAddress { get; set; }
        public string Country { get; set; }
        public int Sex { get; set; }
        public int ClassPeriod { get; set; }
        public string Email { get; set; }
        public List<SchedulesDto> Shedules { get; set; }
    }
}
