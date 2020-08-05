using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilVetIndApi.Authentication
{
	public class ApplicationRole : IdentityRole
	{

		private string _name;

		public string Name
		{
			get {
				return _name; 
			}
			set { 
				_name = value; 
			}
		}


		//private string _roleName;
		public ApplicationRole(string name) : base(name)
		{
			this.Name = name;
		}

		public ICollection<ApplicationUserRole> UserRoles { get; set; }
	}
}
