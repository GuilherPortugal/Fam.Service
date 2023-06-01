using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fam.Service.Domain.Entities
{
    public  class Absences : BaseEntity
    {
      public string SheduleId { get; set; }
      public string StudentId { get; set; }
      public int NumberAbsences { get; set; }
    }
}
