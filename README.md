A simple console application to implement the Facade Pattern using the below-given requirement.

__Requirement Description__

Let us assume we have an existing three database services which offer two methods for adding and updating items into the database (data is not being actually saved to the database just a mockup). They are as follows:

__EmployeeDbService:__ The class exposes two methods that allow to add a new Employee and Update the same in the database.

__ProjectDbService:__ This class exposes two methods that allow to add and update Project details for an employee.

__SalaryDbService:__ This class exposes two methods that allow to add and update the Salary details of an employee.

The above-mentioned database services are individual services and can be called independent of each other.

The client is not interested in calling these individual services instead it wants to have just two methods.

When a new employee is added, related project and salary details should also be created in the database.

A single method should be exposed to update employee, project, and salary details.
