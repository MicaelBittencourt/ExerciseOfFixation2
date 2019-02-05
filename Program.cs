using System;
using System.Collections.Generic;
using System.Globalization;
using ConsoleApp1.Entities;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<People> people = new List<People>();
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Induvidual or campany (i/c)? ");
                char iOrC = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string pName = Console.ReadLine();
                Console.Write("Anual Income: ");
                double aI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (iOrC == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double hE = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    people.Add(new Physical(pName, aI, hE));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int nE = int.Parse(Console.ReadLine());
                    people.Add(new Legal(pName, aI, nE));
                }
                
            }
            Console.WriteLine("TAXES PAID: ");
            foreach (People per in people)
            {
                Console.WriteLine(per.ToString());
                sum += per.Tax();
            }

            Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
