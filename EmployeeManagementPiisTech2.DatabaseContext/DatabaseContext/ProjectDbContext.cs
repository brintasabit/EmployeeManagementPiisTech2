using EmployeeManagementPiisTech2.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementPiisTech2.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
    }
}
