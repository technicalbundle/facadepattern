using System;

namespace FacadePattern
{
    /// <summary>
    /// This is a Employee database service that have two method to Add and Update Employee details to the database
    /// </summary>
    public class EmployeeDbService
    {
        public int AddEmployee(Employee employee)
        {
            Console.WriteLine($"[New Employee] - Id# [{employee.Id}] FirstName# {employee.FirstName}  LastName# {employee.LastName} added to the database");
            return employee.Id;
        }

        public void UpdateEmployeeDetails(Employee employee)
        {
            Console.WriteLine($"[Update Employee] - Id# [{employee.Id}] FirstName# {employee.FirstName}  LastName# {employee.LastName} added to the database"); 
        } 
    }
}
