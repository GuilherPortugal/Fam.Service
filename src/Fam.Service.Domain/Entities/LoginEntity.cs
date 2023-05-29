using System;

namespace Fam.Service.Domain.Entities
{
    public class LoginEntity : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
