namespace WebApplication3.Models.Domain
{
    public class Employee // this will be used for the Dbset in DAL
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long Salary { get; set; }

        public DateOnly DoB { get; set; }
    }
}
