using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace day2Project
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Enter social security number
            //Console.Write("Social Security Number:");
            //var ssn = Console.ReadLine();

            //// Validate social security number
            //if (!Regex.IsMatch(ssn, @"^\d{3}-?\d{2}-?\d{4}$"))
            //{
            //    Console.WriteLine("Invalid social security number!");
            //} else
            //{
            //    Console.WriteLine("You entered it in correctly");
            //}

            var colors = new string[]
            {
                "Red", "Blue", "Green"
            };

            Array.Sort(colors);
            var names = new string[3];


            names[0] = "Chris";
            names[1] = "Matt";
            names[2] = "Cade";
            Array.Sort(names);


            for (var i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("{0}'s favorite color is {1}", names[i], colors[i]);
            }


            //pause
            Console.ReadKey();



        }
    }
}
