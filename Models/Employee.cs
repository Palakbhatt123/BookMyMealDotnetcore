using System;
using System.Collections.Generic;

namespace BookMyMeal.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; } = null!;
        public string? Username { get; set; }
        public string Password { get; set; } = null!;
        public int? DeptId { get; set; }
    }
}
