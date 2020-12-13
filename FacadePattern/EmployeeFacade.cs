namespace FacadePattern
{

    /// <summary>
    /// This is the Facade class that combines all the three database services and provides a
    /// APIs AddNewEmployee and UpdateEmployee as per Client's requirement and hide the implementation details from the client
    /// that it is calling all the related service to fulfill the client's requirement
    /// </summary>
    public class EmployeeFacade
    {
        private EmployeeDbService employeeDbService;
        private ProjectDbService projectDbService;
        private SalaryDbService salaryDbService;

        public EmployeeFacade()
        {
            employeeDbService = new EmployeeDbService();
            projectDbService = new ProjectDbService();
            salaryDbService = new SalaryDbService();
        }

        public int AddNewEmployee(Employee employee)
        {
            var employeeId = employeeDbService.AddEmployee(employee);
            salaryDbService.AddSalaryDetails(employeeId);
            projectDbService.AddProjectDetails(employeeId);
            return employeeId;
        }

        public void UpdateEmployee(Employee employee, Salary salary, Project project)
        {
            employeeDbService.UpdateEmployeeDetails(employee);
            salaryDbService.UpdateSalaryDetails(salary);
            projectDbService.UpdateProjectDetails(project);
        }
    }
}
