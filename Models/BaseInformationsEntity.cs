using System;

namespace Fam.Service.Models
{
    public class BaseInformationsEntity : BaseEntity
    {
      public string Name { get;set; }
      public string RegistrationNumber { get; set; }
      public DateTime DateOfBirth { get; set; }
      public string Address { get; set; }
      public int NumberAddress { get; set; }
      public string Country { get; set; }
      public int Sex { get; set; } 
      public string Photograph { get; set; }
    }
}
