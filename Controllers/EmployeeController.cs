using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookMyMeal.Models.DTO;
using BookMyMeal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using BookMyMeal.Repositories.Interface;

namespace BookMyMeal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> empLogin(LoginDTO loginPojo)
        {
            var emp = employeeRepository.loginVerification(loginPojo);
            if (emp == null)
            {
                return BadRequest("username or password is incorrect");
            }
            return Ok(emp);
        }

        [HttpGet]
        [Route("emp")]
        public async Task<IActionResult> getEmps()
        {
            var response = employeeRepository.getAll();
            return Ok(response);
        }

        [HttpPut]
        [Route("emp")]
        public async Task<IActionResult> updateEmp(ChangePasswordDTO changePasswordDTO)
        {
            Employee emp = employeeRepository.updatePassword(changePasswordDTO);    
            return Ok(emp);
        }

        [HttpGet]
        [Route("meal")]
        public async Task<IActionResult> getAllmeal()
        {
            var response = employeeRepository.getAllMeal();
            return Ok(response);
        }
    }
}
