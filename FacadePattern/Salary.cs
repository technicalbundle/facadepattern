namespace FacadePattern
{
    /// <summary>
    /// This is a model class that represents a Salary of an employee
    /// </summary>
    public class Salary
    {
        public int EmployeeId { get; set; }
        public decimal Basic { get; set; }
        public decimal Incentives { get; set; }
    }
}
