using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand1 = new Random();


            int thing = rand1.Next(3);


            Console.WriteLine(thing);

            string myName = @"Chris """""" Pena";
            //int index1 = myName.IndexOf(" ");
            //myName = myName.Remove(index1);

            Console.WriteLine(myName);
            Console.ReadKey();
        }
    }
}
