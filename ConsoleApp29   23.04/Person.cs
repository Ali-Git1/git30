using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29___23._04
{
    public class Person
    {

        public static int nId = 0;

        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public int Age { get; set; }
        public Person(string name, string surname, int age)
        {
            nId++;
            Name = name;
            SurName = surname;
            Age = age;
            Id=nId;
         
        }

    }
}
