using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMVC.Models
{
  public class Contact
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public string Phone { get; set; }

    public bool IsActive { get; set; }
  }
}