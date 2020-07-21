using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MilVetIndApi.Authentication;
using MilVetIndApi.Data;

namespace MilVetIndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeIdController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeIdController(ApplicationDbContext context)
        {
			_context = context;
        }

        //GET: api/Store/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetNewEmployeeId(int id)
        {
            var employee = _context.Employee.FirstOrDefault(e => e.PK_Employee == id);
            var store = _context.Store.First<Store>(e => e.PK_Store == employee.FK_Store);

            if (store == null || employee == null)
            {
                return NotFound();
            } 
            else
            {

                var empInt = store.LastId + 1;
				var empId = store.StoreAbbreviation + "00" + empInt.ToString();

                //update store lastid
                store.LastId = empInt;

                //Created new employee record
                var emp = new Employee();
                emp.EmployeeId = empId;
                emp.FK_Store = store.PK_Store;
                //emp.PK_Employee = user.PK_Employee;

                _context.Employee.Add(emp);
                await _context.SaveChangesAsync();

            return empId;
        }
    }

       /* [HttpPost()]
        public async Task<IActionResult> GetNewEmployeeId(int userId)
        {
            var store = _context.Store.Any(e => e.PK_Store == user.FK_Store);
            var districtId = store.
            return Content("use");
        }*/
    }
}
