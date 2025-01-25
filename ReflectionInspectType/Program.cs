using System.Reflection;

namespace ReflectionInspectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Person);

            Console.WriteLine($"Class Name: {type.Name}");

            // Get properties
            Console.WriteLine("Properties:");
            foreach (var property in type.GetProperties())
            {
                Console.WriteLine($"- {property.Name} ({property.PropertyType.Name})");
            }

            // Get methods
            Console.WriteLine("Methods:");
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine($"- {method.Name}");
            }
        }
    }
}
