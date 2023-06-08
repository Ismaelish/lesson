namespace WebApplication3.Models
{
    public class AddEmployeeViewModel //declaration of columns to be viewed in Add.cshtml
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public long Salary { get; set; }

        public DateOnly DoB { get; set; }
    }
}
