using AngularMVC5.Models.Ennititis;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC5.Models
{
   public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("AngularDemo")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
