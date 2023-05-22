using System;

namespace Fam.Service.Models
{
    public class StudentsEntity : BaseInformationsEntity
    {
        public string UserId{ get; set; }
        public string ClassId { get; set; }
        public DateTime Period { get; set; }
        public string RA { get; set; }
    }
}
