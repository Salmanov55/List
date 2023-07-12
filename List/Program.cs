using System;
using System.Collections.Generic;

namespace List
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var pr1 = new Person()
            {
                Name ="Ali",
                Surname = "Salmanov",
                Age = 20
            };
            var pr2 = new Person() 
            {
                Name = "Hesen",
                Surname = "Kerimov",
                Age = 20
            };
            var pr3 = new Person()
            {
                Name = "Huseyn",
                Surname = "Ferzeli",
                Age = 19
            };
            var pr4 = new Person()
            {
                Name = "Tahir",
                Surname = "Allahverdiyev",
                Age = 19
            };
            var pr5 = new Person()
            {
                Name = "Mahir",
                Surname = "Teyibov",
                Age = 20
            };
            var pr6 = new Person()
            {
                Name = "Nihat",
                Surname = "Mustafayev",
                Age = 20
            };
            var pr7 = new Person()
            {
                Name = "Elnur",
                Surname = "Azizov",
                Age = 20
            };
            var pr8 = new Person()
            {
                Name = "Rovsen",
                Surname = "Talibov",
                Age = 20
            };
            var pr9 = new Person()
            {
                Name = "Vaqif",
                Surname = "Qarayev",
                Age = 20
            };
            var pr10 = new Person()
            {
                Name = "Qurban",
                Surname = "Azizli",
                Age = 30
            };

            var person = new List<Person>();
            person.Add(pr1);
            person.Add(pr2);
            person.Add(pr3);
            person.Add(pr4);
            person.Add(pr5);
            person.Add(pr6);
            person.Add(pr7);


            Console.WriteLine("Enter name");
            string name = (Console.ReadLine());
            var result = person.Find(x => x.Name == name);

            if (result == null)
            {
                Console.WriteLine("Not Found");
            }
            else 
            {
                Console.WriteLine("Found"); 
            }

        }
    }
}
