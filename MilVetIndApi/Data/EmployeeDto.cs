﻿using System;
namespace MilVetIndApi.Data
{
	public class EmployeeDto
	{
		public EmployeeDto()
		{
		}

		public string EmployeeId { get; set; }
		public int PK_District { get; set; }
		public int PK_Region { get; set; }
		public int PK_Store { get; set; }
	}
}
