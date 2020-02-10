using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementPiisTech2.Model.Model;
using EmployeeManagementPiisTech2.DatabaseContext.DatabaseContext;

namespace EmployeeManagementPiisTech2.Repository.Repository
{
    public class EmployeeRepository
    {
        ProjectDbContext dbContext = new ProjectDbContext();
        public List<Employee> GetAllEmployee()
        {
            using (ProjectDbContext dbContext = new ProjectDbContext())
            {
                return dbContext.Employees.ToList<Employee>();
            }
            
        }
    }
}
