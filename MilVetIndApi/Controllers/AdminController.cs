using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using MilVetIndApi.Authentication;
using MilVetIndApi.Authentication.Models;

namespace MilVetIndApi.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class AdminController : ControllerBase
	{
		private readonly UserManager<ApplicationUser> userManager;
		private readonly RoleManager<ApplicationRole> roleManager;
		private readonly IConfiguration _configuration;

		public AdminController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IConfiguration configuration)
		{
			this.userManager = userManager;
			this.roleManager = roleManager;
			_configuration = configuration;
		}


		[HttpGet]
		[Route("user")]
		public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetUser()
		{
			var users = await userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToListAsync();
			return users;
		}

		[HttpGet]
		[Route("role")]
		public async Task<ActionResult<IEnumerable<ApplicationRole>>> GetRoles()
		{
			var roles = await roleManager.Roles.ToListAsync();
			return roles;
		}


		[HttpPut]
		[Route("role")]
		public async Task<ActionResult<IEnumerable<ApplicationRole>>> AddRole([FromBody] Role role)
		{ 
			var isName = await roleManager.RoleExistsAsync(role.Name);
			if (!isName)
			{
				try
				{
					await roleManager.CreateAsync(new ApplicationRole(role.Name));
					return Ok(new Response { Status = "Success", Message = "Role '" + role.Name + "' created successfully!" });
				}
				catch (Exception e)
				{
					var message = e.Message;
					return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = e.Message });
				}
			}

			return StatusCode(StatusCodes.Status302Found, new Response { Status = "Error", Message = "Role already exisits" });
		}

		[HttpGet]
		[Route("userRole")]
		public async Task<ActionResult<IEnumerable<string>>> GetUserRoles([FromBody] UserRole userRole)
		{
			var userExists = await userManager.FindByNameAsync(userRole.Username);
			if (userExists == null)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User not found!" });
			}

			try
			{
				var list = await userManager.GetRolesAsync(userExists);
				return Ok(list);
			}
			catch (Exception e)
			{
				var message = e.Message;
				return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = e.Message });
			}
		}


		[HttpPut]
		[Route("userRole")]
		public async Task<ActionResult<IEnumerable<ApplicationRole>>> AddUserToRole([FromBody] UserRole userRole)
		{
			var userExists = await userManager.FindByNameAsync(userRole.Username);
			if (userExists == null)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User not found!" });
			}

			var roleExists = await roleManager.FindByNameAsync(userRole.RoleName);
			if (roleExists == null)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Role not found!" });
			}

			
			var list = await userManager.GetRolesAsync(userExists);
			if (list.Contains(userRole.RoleName))
			{
				return Ok(new Response { Status = "Success", Message = "User already has " + userRole.RoleName + " role."});
			}
			try
			{
				await userManager.AddToRoleAsync(userExists, roleExists.Name);
				return Ok(new Response { Status = "Success", Message = "User added to role " + roleExists.Name });
			}
			catch (Exception e)
			{
				var message = e.Message;
				return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = e.Message });
			}
		}

		//	return StatusCode(StatusCodes.Status302Found, new Response { Status = "Error", Message = "Role already exisits" });
		//}


		//    //[HttpPost]
		//    //public async Task<IActionResult> GetUsers()
		//    //{
		//    //    var users = await userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToListAsync();
		//    //    return (IActionResult)users;

		//    //    //InputModel inputModel = new InputModel();
		//    //    //foreach (var v in users)
		//    //    //{
		//    //    //    inputModel = new InputModel();
		//    //    //    var roles = await userManager.GetRolesAsync(v);
		//    //    //    inputModel.Email = v.UserName;
		//    //    //    inputModel.role = "";
		//    //    //    foreach (var r in roles)
		//    //    //    {
		//    //    //        if (!inputModel.role.Contains(","))
		//    //    //        {
		//    //    //            inputModel.role = r;
		//    //    //        }
		//    //    //        else
		//    //    //        {
		//    //    //            inputModel.role = "," + r;
		//    //    //        }
		//    //    //    }
		//    //    //    Input2.Add(inputModel);
		//    //}
	}
}