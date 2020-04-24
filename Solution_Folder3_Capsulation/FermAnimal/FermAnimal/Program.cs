using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            // Chicken
            Chicken chicken = new Chicken(name, age);

            // Print
            Console.WriteLine(chicken.CalculateProductPerDay());
        }
    }
}
