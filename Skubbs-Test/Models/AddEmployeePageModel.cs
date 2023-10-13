using System;
using System.ComponentModel.DataAnnotations;

namespace Skubbs_Test.Models
{
	public class AddEmployeePageModel
	{
		[Required]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Required]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "Date of Birth")]
		public DateTime DateOfBirth { get; set; }
	}
}
