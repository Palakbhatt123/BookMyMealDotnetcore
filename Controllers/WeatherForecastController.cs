using BookMyMeal.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
