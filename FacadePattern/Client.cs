using System;

namespace FacadePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            var facade = new EmployeeFacade();
            var employee = new Employee { FirstName = "John", LastName = "Doe" }; 
            
            facade.AddNewEmployee(employee);
            Console.WriteLine();

            employee.FirstName = "Jonny";
            var updatedSalary = new Salary { EmployeeId = employee.Id, Basic = 999999, Incentives = 22222 };
            var updatedProject = new Project { EmployeeId = employee.Id, Department = "Finance" };

            facade.UpdateEmployee(employee, updatedSalary, updatedProject);
        }
    }
}
