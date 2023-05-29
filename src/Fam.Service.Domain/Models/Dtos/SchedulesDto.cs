using System;

namespace Fam.Service.Domain.Models
{
    public class SchedulesDto
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public DateTime SheduleStart { get;set;}
        public DateTime SheduleEnd { get; set; }
    }
}