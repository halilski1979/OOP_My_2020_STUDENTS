using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght1 = double.Parse(Console.ReadLine());
            double width1 = double.Parse(Console.ReadLine());
            double height1 = double.Parse(Console.ReadLine());

            Box b = new Box(lenght1,width1,height1);
            Console.WriteLine($"Palna: {b.PalnaPovarhnina()}");
            Console.WriteLine($"Okolna: {b.Okolna()}");
            Console.WriteLine($"Obem: {b.ObemV(lenght1,width1,height1)}");
        }
    }
}
