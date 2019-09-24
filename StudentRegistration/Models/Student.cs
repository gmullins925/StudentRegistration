using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
	public class Student
	{
		[Display(Name = "Student ID Number")]
		public int ID { get; set; }

		[Display(Name = "Student Name")]
		public string Name { get; set; }

		[Display(Name = "Mobile Phone Number")]
		[DataType(DataType.PhoneNumber)]
		public double CellPh { get; set; }

		[Display(Name = "Email address")]
		[Required(ErrorMessage = "The email address is required")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }

		public int Age { get; set; }
	}
}
