using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new List<int>();
            Random r = new Random();
            for (int x = 0; x < 10; x++)
            {
                int num = r.Next(0, 100);
                Numbers.Add(num);
            }
            foreach(var number in Numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine("-----------------------");


            Console.WriteLine("Average or random numbers is : {0}", Numbers.Average());
            Numbers.Insert(10,0);
            var index = Numbers.IndexOf(0);
            Console.WriteLine("index of position 0 is: {0}", index);
            var count = Numbers.Count();
            Console.WriteLine("count is: {0}", count);
            Console.WriteLine("-----------------------");


            Console.WriteLine("Collection using a list of Objects");
            var Student = new List<Person>
            {
                new Person() { FirstName = "Joe", LastName = "Bloggs", Age = 23 },
                new Person() { FirstName = "Steve", LastName = "May", Age = 22 },
                new Person() { FirstName = "Jack", LastName = "Jones", Age = 24 },
                new Person() { FirstName = "Tom", LastName = "Jones", Age = 23 },
            };
            Console.WriteLine("numbers of  objects is :{0}", Student.Count());
            foreach (var student in Student)
            {
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
                Console.WriteLine(student.Age);
                Console.WriteLine("-----------------------");
            }
        Console.ReadLine();
        }
    }
}
