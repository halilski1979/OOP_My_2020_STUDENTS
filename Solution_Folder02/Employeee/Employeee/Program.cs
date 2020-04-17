using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                string name = line[0];
                decimal salary = decimal.Parse(line[1]);
                string position = line[2];
                string department = line[3];

                Employee employee = new Employee(name, salary, position, department);

                if (line.Length == 5)
                {
                    string check = line[4];

                    if (int.TryParse(check, out int age))
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = check;
                    }
                }
                else if (line.Length == 6)
                {
                    string email = line[4];
                    int age = int.Parse(line[5]);

                    employee.Email = email;
                    employee.Age = age;
                }

                employees.Add(employee);
            }


            //Групиране и сортиране
            var groupBySortedDepartments = employees
                .GroupBy(x => x.Department)
                .OrderBy(x => x.ToList()
                   .Average(y => y.Salary));


            //Взимаме името на отдела с най-висока средна заплата
            var topDepartment = groupBySortedDepartments.Last().Key;



            Console.WriteLine($"Highest Average Salary: {topDepartment}");

            foreach (var e in employees.OrderByDescending(x => x.Salary))
            {
                if (e.Department == topDepartment)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
