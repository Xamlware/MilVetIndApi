using System;
using System.ComponentModel.DataAnnotations;

namespace MilVetIndApi.Data
{
	public class Inventory
	{
		public Inventory()
		{
		}

		[Key]
		public int PK_Inventory { get; set; }

	}
}
