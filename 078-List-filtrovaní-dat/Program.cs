using System;
using System.Collections.Generic;

namespace _078_List_filtrovaní_dat
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person("Susan", 17, Sex.Female),
                new Person("John", 31, Sex.Male),
                new Person("Steve", 8, Sex.Male),
                new Person("Timmy", 46, Sex.Male),
                new Person("Janet", 65, Sex.Female),
                new Person("Mary", 3, Sex.Female),
                new Person("Lissa", 37, Sex.Female),
                new Person("Tony", 82, Sex.Male),
            };

            //Person[] kids = ???

            List<Person> kidsList = new List<Person>();
            foreach (Person p in people)
            {
                if (p.Age < 18)
                    kidsList.Add(p);
            }

            Person[] kids = kidsList.ToArray();
            
            Person.PrintPeople(kids);
            Person.PrintPeople(Person.GetWomen(people));
        }


    }
}
