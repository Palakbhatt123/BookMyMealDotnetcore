using Microsoft.AspNetCore.Mvc;
using BookMyMeal.Models;

namespace BookMyMeal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly BookMyMealContext _dbcontext;
        public WeatherForecastController(BookMyMealContext _context)
        {
            _dbcontext=_context;

        }

        [HttpGet]
        [Route("emp")]
        public async Task<IActionResult> getEmps()
        {
            try {
                List<Employee> listEmp = _dbcontext.Employees.ToList();
                return Ok(listEmp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
