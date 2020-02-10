using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Xunit.Sdk;

namespace EmployeeManagementPiisTech2.Model.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "First Name Required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required!")]
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public int Age { get; set; }
        [Required(ErrorMessage = "Sex Required!")]
        public string Sex { get; set; }
        [Required(ErrorMessage = "Current Salary Required!")]
        public double CurrentSalary { get; set; }
        public double LastRevisedSalary { get; set; }
        public string JoinDate { get; set; }
        public bool IsCurrentEmployee { get; set; }
        public string LastSalaryIncrementDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        [DisplayName("Profile")]
        public string ImagePath { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }
        public Employee()
        {
            ImagePath = "~/AppFiles/ImageFiles/Default.png";
        }
    }
}
