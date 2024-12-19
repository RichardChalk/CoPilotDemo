using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoPilotDemo
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int? Age { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Street}, {City}, {State}, {PostalCode}, {Country}");
        }

        public static Person CreatePersonFromUserInput()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine() ?? string.Empty;

            Person person = new Person(firstName, lastName);

            Console.Write("Enter age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                person.Age = age;
            }

            Console.Write("Enter street: ");
            person.Street = Console.ReadLine();

            Console.Write("Enter city: ");
            person.City = Console.ReadLine();

            Console.Write("Enter state: ");
            person.State = Console.ReadLine();

            Console.Write("Enter postal code: ");
            person.PostalCode = Console.ReadLine();

            Console.Write("Enter country: ");
            person.Country = Console.ReadLine();

            return person;
        }
    }
}

