using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SBooksEmployee.Models
{
    public class Employee
    {
        [Display(Name = "Employee ID")]
        public string EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string EmpEmail { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        public string EmpFName { get; set; }

        [Display(Name = "MI")]
        public string EmpMI { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        public string EmpLName { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your zip code.")]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        [Display(Name = "Phone")]
        [PhoneAttribute]
        public string Phone { get; set; }


        public bool EmpActive { get; set; }
        public bool Managers { get; set; }


      //  public virtual List<Reorder> Reorders { get; set; }
    }
}


