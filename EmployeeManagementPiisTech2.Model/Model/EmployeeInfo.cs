using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementPiisTech2.Model.Model
{
    public class EmployeeInfo
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Email Required!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password Required!")]
        public string Password { get; set; }
    }
}
