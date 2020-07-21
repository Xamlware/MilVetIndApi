using System;
using System.ComponentModel.DataAnnotations;

namespace MilVetIndApi.Data
{
	public class Employee
	{
		public Employee()
		{
		}

		[Key]
		public int PK_Employee { get; set; }

		//[Required(ErrorMessage = "User Id Required")]
		//public int FK_User { get; set; }

		

	}
}
