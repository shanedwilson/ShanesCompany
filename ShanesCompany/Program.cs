using System;
using System.Collections.Generic;

namespace ShanesCompany
{
    class Program
    { 
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
