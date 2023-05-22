using System;

namespace Fam.Service.Models.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

    }
}
