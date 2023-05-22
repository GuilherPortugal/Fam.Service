using System;

namespace Fam.Service.Models
{
    public class TeachersClassEntity
    {
        public string Id { get; set; }
        public string TeacherId { get; set; }
        public string ClassId {get; set; }
        public string ClassScheduleId { get; set; }
    }
}
