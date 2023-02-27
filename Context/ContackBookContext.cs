using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNetMVC.Context
{
  public class ContackBookContext : DbContext
  {
    public ContackBookContext(DbContextOptions<ContackBookContext> options) : base(options)
    {

    }

    public DbSet<Contact> Contacts { get; set; }
  }
}