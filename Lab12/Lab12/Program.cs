using School.Library;
using System;
using System.Collections.Generic;


namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Jacob Hands", "Jacob's Address Here"),
                new Staff("The Janitor", "Janitor's Address Here", "Wheaton Warrenville South", 15.25),
                new Student("Ferris Bueller", "Bueller's Address Here", "Computer Science", 1986, 999999999.98),
                new Person(),
                new Staff(),
                new Student()
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }

            Console.Read();
        }
    }
}
