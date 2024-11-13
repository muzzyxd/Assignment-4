using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        public class Person
        {
         
            protected string firstName;
            protected string lastName;

            public Person(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

           
            public string GetFullName()
            {
                return $"{firstName} {lastName}";
            }
        }

       
        public class Employee : Person
        {
            
            private string employeeId;

           
            public Employee(string firstName, string lastName, string employeeId)
                : base(firstName, lastName)
            {
                this.employeeId = employeeId;
            }

    
            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"Full Name: {GetFullName()}, Employee ID: {employeeId}");
            }
        }
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Ahmed", "Khan", "1001");
            employee1.DisplayEmployeeInfo();

            Employee employee2 = new Employee("Abdul", "Rehman", "1002");
            employee2.DisplayEmployeeInfo();

            Console.ReadLine();
        }
    }
}
