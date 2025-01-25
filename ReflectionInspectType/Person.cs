using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionInspectType
{
    internal class Person
    {
        public string Name { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
