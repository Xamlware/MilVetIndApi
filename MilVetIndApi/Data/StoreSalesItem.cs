﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MilVetIndApi.Data
{
	public class StoreSalesItem
	{
		public StoreSalesItem()
		{
		}

		[Key]
		public int PK_StoreSalesItem { get; set; }

		[Required(ErrorMessage = "Store Sales id is required")]
		public int FK_StoreSales { get; set; }

		[Required(ErrorMessage = "Inventory id is required")]
		public int FK_Inventory { get; set; }

		[Required(ErrorMessage = "Quantity is required")]
		public float Quantity { get; set; }

		[Required(ErrorMessage = "Price is required")]
		public float Price { get; set; }

		[Required(ErrorMessage = "Discount is required")]
		public float Discount { get; set; }


	}
}


