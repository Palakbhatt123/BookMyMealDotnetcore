using System;
using System.Collections.Generic;

namespace BookMyMeal.Models
{
    public partial class Meal
    {
        public int MealId { get; set; }
        public string MealName { get; set; } = null!;
        public string MealType { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string MealDay { get; set; } = null!;
        public int? MealPrice { get; set; }
    }
}
