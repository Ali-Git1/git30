using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29___23._04
{
    public class CustomCollection<T> where T : Person
    {

        private static T[] _arr = new T[0];

           
        

        public void add(T value)
        {
           Array.Resize(ref _arr,_arr.Length+1);
            _arr[_arr.Length-1] = value;
           
        }

        public void GetById(int id)
        {
            foreach(var item in _arr)
            {
                if(item.Id == id)
                {
                    Console.WriteLine($" Name{item.Name} Surname{item.SurName} ");
                }

                if(item.Id!=id)
                {
                    Console.WriteLine("Isci tapilmadiirj");
                }
            }
        }
        public void Display()
        {
            foreach(T item in _arr)
            {
                Console.WriteLine($"Id:{item.Id} Name{item.Name} Surname{item.SurName} Age{item.Age}");
            }
        }
    }
}
