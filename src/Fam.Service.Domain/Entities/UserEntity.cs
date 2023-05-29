using System;

namespace Fam.Service.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

    }
}
