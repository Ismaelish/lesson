using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.DAL; // added because we use the dbcontext for contractor
using WebApplication3.Models;
using WebApplication3.Models.Domain; // added because we declare a variable called employee from employee model

namespace WebApplication3.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MvcDemoDbContext mvcDemodbContext; // from contractor

        //CONSTRACTOR , INJECTING, BASTA GANUN
        public EmployeesController(MvcDemoDbContext mvcDemodbContext)//EmployeesController(dbcontext name)
        {
            this.mvcDemodbContext = mvcDemodbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index() // this is for listing
        {
            var employeeList = await mvcDemodbContext.Employees.ToListAsync();
            return View(employeeList);
        }

        [HttpGet]
        public IActionResult Add() // to view added employee
        {
            return View(); //then add this to _layout.cshtml
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest) // Add(modelName   name) to save added data
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                DoB = addEmployeeRequest.DoB
            };
            await mvcDemodbContext.Employees.AddAsync(employee); //para sa var employee
            await mvcDemodbContext.SaveChangesAsync(); // to save changest to the database

            return RedirectToAction("Index");
        }

    }
}
