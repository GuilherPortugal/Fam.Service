using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fam.Service.Models
{
    public class SchedulesEntity : BaseEntity
    {
        public string Description { get; set; } 
        public DateTime SheduleStart { get; set; }
        public DateTime SheduleEnd { get; set; }
    }
}
