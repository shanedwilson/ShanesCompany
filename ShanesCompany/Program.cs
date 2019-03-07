using System;
using System.Collections.Generic;

namespace ShanesCompany
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string CompanyName { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        /*
        Create a constructor method that accepts two arguments:
        1. The name of the company
        2. The date it was created

         The constructor will set the value of the public properties
        */

        public Company (string companyName, DateTime createdOn)
        {
            CompanyName = companyName;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        // Create a method that allows external code to add an employee
        public void addEmployee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        // Create a method that allows external code to remove an employee
        public void removeEmployee(Employee exEmployee)
        {
            Employees.Remove(exEmployee);
        }

        public void listEmployees(List<Employee> employees)
        {
            foreach(Employee employee in employees)
                Console.WriteLine(employee.FirstName);
        }
        static void Main(string[] args)
        {
            Company bigTech = new Company("Big Tech", DateTime.Now);

            Employee shane = new Employee("Shane D", "Wilson", "Junior Dev", DateTime.Now);
            Employee nazz = new Employee("Nazz", "Wilson", "Teenager", DateTime.Now);
            Employee stacye = new Employee("Stacye", "Wilson", "President", DateTime.Now);

            bigTech.addEmployee(shane);
            bigTech.addEmployee(stacye);
            bigTech.addEmployee(nazz);

            bigTech.listEmployees(bigTech.Employees);

            Console.ReadKey();
        }
    }
}
