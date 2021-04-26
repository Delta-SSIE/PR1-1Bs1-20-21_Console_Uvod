using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_List_filtrovaní_dat
{
    enum Sex { Male, Female};
    class Person
    {
        public Person(string name, int age, Sex sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public Sex Sex { get; private set; }

        public override string ToString()
        {
            return $"{Name} ({(Sex == Sex.Male ? "Male" : "Female")} {Age})";
        }

        public static void PrintPeople(Person[] people)
        {
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
        }

        public static Person[] GetWomen(Person[] people)
        {
            List<Person> womenList = new List<Person>();

            foreach (Person p in people)
            {
                if (p.Sex == Sex.Female)
                    womenList.Add(p);
            }

            return womenList.ToArray();
        }
    }

}
