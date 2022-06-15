using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Nella", "Virtanen", "nella.virtanen@gmail.com", new DateTime(1997, 10, 10));
            Person person2 = new Person("Eki", "Ojala", "eki@gmail.com", new DateTime(1986, 12, 30));
            Person person3 = new Person("Elviira", "Aho", "ahoelviira@hotmail.com", new DateTime(1981, 1, 8));
            Person person4 = new Person("Veikka", "Virtanen", "veikka.virtanen@gmail.com", new DateTime(1982, 7, 23));
            Person person5 = new Person("Risto-Pekka", "Järvinen", "jarvinen@hotmail.com", new DateTime(1978, 12, 2));

            Dictionary<int, string> ages = new Dictionary<int, string>();
            ages.Add(person1.Age(person1.Birthday), person1.Name);
            ages.Add(person2.Age(person2.Birthday), person2.Name);
            ages.Add(person3.Age(person3.Birthday), person3.Name);
            ages.Add(person4.Age(person4.Birthday), person4.Name);
            ages.Add(person5.Age(person5.Birthday), person5.Name);

            double ave = ages.Keys.Average();
            int aveINT = Convert.ToInt32(ave);
            Console.WriteLine("Keskiarvo {0}", aveINT);
            var result = ages.Where(a => a.Key > aveINT);

            foreach (var item in result)
            {
                Console.WriteLine("Keskiarvon yli: {0}", item);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name;
        public string LastName;
        public string Email;
        public DateTime Birthday;

        public Person(string name, string lastName, string email, DateTime birthday)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Birthday = birthday;
        }
        public Person(string name, string lastName, string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public Person(string name, string lastName, DateTime birthday)
        {
            Name = name;
            LastName = lastName;
            Birthday = birthday;
        }

        public int Age(DateTime birthday)
        {
            int age = 0;
            age = DateTime.Now.Subtract(birthday).Days;
            age = age / 365;
            return age;
        }
    }
}
