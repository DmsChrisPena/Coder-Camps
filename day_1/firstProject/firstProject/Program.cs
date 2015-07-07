using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstProject.helpers;
using System.IO;
using System.Net.Mail;

namespace firstProject
{
    class Program
    {


        static void Main(string[] args)
        {
            //Change date format
            //Console.WriteLine("Please enter in the date in the following format:");
            //Console.WriteLine("mm/dd/yyyy");

            //string theDate = Console.ReadLine();

            //DateTime newDateTime = Convert.ToDateTime(theDate);

            //Console.WriteLine(newDateTime.ToString("F"));



            //Console.ReadKey();

            //Favorite colors
            //var colors = new string[]
            //{
            //    "red", "blue", "green", "yellow", "orange"
            //};

            //var people = new string[]
            //{
            //    "Chris", "Cade", "Nick", "Dan", "Matt"
            //};

            //for(var i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(people[i] + "'s favorite color is " + colors[i]);
            //}
            //Console.WriteLine("Enter number 1...");
            //var num1 = 0;
            //var newNum1 = int.TryParse(Console.ReadLine(), out num1);
            //int num2 = 0;
            //Console.WriteLine("Enter number 2...");
            //var newNum2 = int.TryParse(Console.ReadLine(), out num2);


            //DoSomething(num1, num2);
            //Console.WriteLine("Is this working?");

            Console.WriteLine("Enter your birthday...");
            Console.WriteLine("mm/dd/yyyy");

            string myBirth = Console.ReadLine();

            DateTime dateBirth = Convert.ToDateTime(myBirth);


            for(var i = 0; i < 100; i++)
            {
                string added6 = dateBirth.AddMonths(i).ToString("D");
                Console.WriteLine(added6);
            }



            Console.ReadKey();

        }

        //static void DoSomething(int firstNumber, int secondNumber)
        //{
        //    int theSum = firstNumber + secondNumber;
        //    Console.WriteLine("The answer is {0}", theSum);
        //    Console.ReadKey();
        //}
    }
}