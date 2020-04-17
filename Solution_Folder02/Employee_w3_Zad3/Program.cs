using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_w3_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> spisakSlujiteli = new List<Employee>();
            Console.Write("Брой служители: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                int godini =-1;
                string elPoshta = "n/a";

                    string ime = linia[0];
                    double zaplata = int.Parse(linia[1]);
                    string dlajnost = linia[2];
                    string otdel = linia[3];

                Employee edinSlujitel = new Employee();
                edinSlujitel.Name = ime;
                edinSlujitel.Salary = zaplata;
                edinSlujitel.Department = dlajnost; 
                edinSlujitel.Position =otdel;

                if (linia.Count == 6)
                {
                    elPoshta = linia[4];
                    godini = int.Parse(linia[5]);
                    edinSlujitel.Age = godini;
                    edinSlujitel.Email = elPoshta;
                }
                //Проверка за 5 и 6 позиция
                if (linia.Count == 5)
                {
                    if (int.TryParse(linia[4], out godini))
                    {
                        //godini = -1;
                        edinSlujitel.Age = godini;
                                               
                    }
                    else
                    {
                        godini = -1;
                        edinSlujitel.Age = godini;

                        if (!string.IsNullOrEmpty(linia[4]))
                        {
                            elPoshta = linia[4];
                            edinSlujitel.Email = elPoshta;
                        }
                    }

                }
                               

                spisakSlujiteli.Add(edinSlujitel);
            }

            foreach (var item in spisakSlujiteli)
            {
                Console.WriteLine($"{item.Name} {item.Salary}  {item.Email} {item.Age}");
            }
            




        }
    }
}
