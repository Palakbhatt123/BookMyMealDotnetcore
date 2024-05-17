using BookMyMeal.Models;
using BookMyMeal.Models.DTO;

namespace BookMyMeal.Repositories.Interface
{
    public interface IEmployeeRepository
    {
        Employee loginVerification(LoginDTO loginDTO);
        List<Employee> getAll();
        Employee updatePassword(ChangePasswordDTO changePasswordDTO);
        List<Meal> getAllMeal();
    }
}
