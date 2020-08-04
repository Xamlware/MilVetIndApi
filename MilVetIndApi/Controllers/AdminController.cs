using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MilVetIndApi.Authentication;

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