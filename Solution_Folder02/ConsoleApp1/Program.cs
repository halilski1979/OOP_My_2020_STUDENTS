using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            try
            {
                int n = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Nekorektni danni");
            }
            
        }
    }
}
