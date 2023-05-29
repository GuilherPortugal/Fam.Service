using System;

namespace Fam.Service.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public int CourseType { get; set; }
    }
}
