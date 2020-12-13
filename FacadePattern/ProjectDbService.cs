using System;

namespace FacadePattern
{
    /// <summary>
    /// This is the Project Database Service that Adds and Updates project details of an employee in the database
    /// </summary>
    public class ProjectDbService
    {
        public void AddProjectDetails(int employeeId)
        {
            Project project = new Project();
            project.EmployeeId = employeeId;
            project.Department = "NO-DEPARTMENT";
            Console.WriteLine($"EmployeeId# [{employeeId}] allocated to [{project.Department}] department");
        }

        public void UpdateProjectDetails(Project project)
        {
            Console.WriteLine($"[Updated] EmployeeId# [{project.EmployeeId}] allocated to [{project.Department}] department"); 
        }
    }
}
