#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeService.Models;

namespace EmployeeService.Data
{
    public class EmployeeServiceContext : DbContext
    {
        public EmployeeServiceContext (DbContextOptions<EmployeeServiceContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeService.Models.Employee> Employee { get; set; }
    }
}
