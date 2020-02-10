using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementPiisTech2.Model.Model;
using EmployeeManagementPiisTech2.Repository.Repository;


namespace EmployeeManagementPiisTech2.Bill.Bill
{
    public class EmployeeManager
    {
        EmployeeRepository _employeeRepository=new EmployeeRepository();

        public List<Employee> GetAllEmployee()
        {
            return _employeeRepository.GetAllEmployee();
        }
    }
}
