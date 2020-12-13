using System;

namespace FacadePattern
{
    /// <summary>
    /// This is a model class that represents an Employee
    /// </summary>
    public class Employee
    {
        Random random = new Random();

        public Employee()
        {
            Id = random.Next(1111, 999999);
        } 

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
