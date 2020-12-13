using System;

namespace FacadePattern
{
    /// <summary>
    /// This is the Salary Database Service, that Adds and Update Salary details of an employee in the database
    /// </summary>
    public class SalaryDbService
    {
        public void AddSalaryDetails(int employeeId)
        {
            Salary salary = new Salary();
            salary.EmployeeId = employeeId;
            salary.Basic = 56543;
            salary.Incentives = 45656;
            Console.WriteLine($"Salary for EmployeeId# [{employeeId}] - Basic: {salary.Basic}  Incentives: {salary.Incentives} added to the database");
        }

        public void UpdateSalaryDetails(Salary salary)
        { 
            Console.WriteLine($"Salary for EmployeeId# [{salary.EmployeeId}] - Basic: {salary.Basic}  Incentives: {salary.Incentives} updated to the database"); 
        }
    }
}
