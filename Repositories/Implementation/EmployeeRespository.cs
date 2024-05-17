using BookMyMeal.Models;
using BookMyMeal.Models.DTO;
using BookMyMeal.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookMyMeal.Repositories.Implementation
{
    public class EmployeeRespository : IEmployeeRepository
    {
        private readonly BookMyMealContext _context;
        public EmployeeRespository(BookMyMealContext _context)
        {
            this._context = _context;
        }

        public List<Employee> getAll()
        {
            //List<Employee> listEmp = _context.Employees.ToList();
            return this._context.Employees.ToList();
        }

        public List<Meal> getAllMeal()
        {
            return _context.Meals.ToList();
        }

        public Employee loginVerification(LoginDTO loginDTO)
        {
            Employee emp=_context.Employees.Where(u => u.Username == loginDTO.username && u.Password == loginDTO.password).FirstOrDefault();
            return emp;
        }

        public Employee updatePassword(ChangePasswordDTO changePasswordDTO)
        {
            Employee emp = _context.Employees.Where(u => u.EmpId == changePasswordDTO.empid).FirstOrDefault();
            emp.Password=changePasswordDTO.new_pass;
            _context.SaveChanges();
            return emp;
        }
    }
}
