using System;

namespace Fam.Service.Models
{
    public class LoginEntity : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
