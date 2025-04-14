using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NtandoMabuthoStudyGroupP2.Models
{
	public class Student
	{
        [Required(ErrorMessage = "Student Number is required")]
        [RegularExpression(@"^\d{4,10}$", ErrorMessage = "Student Number must be between 4 and 10 digits")]
        [Display(Name = "STUDENT NUMBER")]
        public int StudentNumber { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name can only contain letters")]
        [Display(Name = "NAME")]
        public string FirstNaam { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [StringLength(50, ErrorMessage = "Surname cannot be longer than 50 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Surname can only contain letters")]
        [Display(Name = "SURNAME")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "EMAIL ADDRESS")]
        public string Email { get; set; }

        
    }
}
