using System;

namespace Fam.Service.Models
{
    public class UserEntity : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

    }
}
