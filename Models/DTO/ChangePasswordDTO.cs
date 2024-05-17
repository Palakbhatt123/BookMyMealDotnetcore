namespace BookMyMeal.Models.DTO
{
    public class ChangePasswordDTO
    {
        public string new_pass { get; set; }
        public int empid { get; set; }
        public string old_pass { get; set;}
        public string confirm_pass { get; set;}
    }
}
