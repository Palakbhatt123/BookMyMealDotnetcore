using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookMyMeal.Models;
using BookMyMeal.pojo;

namespace BookMyMeal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly BookMyMealContext _context;
        public EmployeeController(BookMyMealContext _context)
        {
            this._context = _context;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> empLogin(LoginPojo loginPojo)
        {
            
            var dbEmp = _context.Employees.Where(u=> u.Username== loginPojo.username && u.Password== loginPojo.password).FirstOrDefault();
            if (dbEmp == null)
            {
                return BadRequest("username or password is incorrect");
            }
            return Ok(dbEmp);
        }
    }
}
