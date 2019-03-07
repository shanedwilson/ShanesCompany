using System;
using System.Collections.Generic;
using System.Text;

namespace ShanesCompany
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime HiredOn { get; set; }

        public void AddFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public void AddLastName(string lastName)
        {
            LastName = lastName;
        }

        public void AddTitle(string title)
        {
            Title = title;
        }

        public void AddHireDate(DateTime hiredOn)
        {
            HiredOn = hiredOn;
        }

        public Employee(string firstName, string lastName, string title, DateTime hiredOn)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            HiredOn = hiredOn;
        }
    }
}
