using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fam.Service.Domain.Entities
{
    public class ClassScheduleEntity : BaseEntity
    {
        public string SheduleId { get; set; } 
        public string ClassId { get; set; }
    }
}
