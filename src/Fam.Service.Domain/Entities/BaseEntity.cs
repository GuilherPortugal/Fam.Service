using System;

namespace Fam.Service.Domain.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int Deleted { get; set; }
    }
}
