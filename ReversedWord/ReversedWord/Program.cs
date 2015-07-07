using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedWord
{
    class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }



        public decimal CalculateTax()
        {
            return (this.Price * .08m) + this.Price;
        }
    }

    class Compwnents
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string BothName()
        {
            return this.Name + "\n" + this.Description;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ////Reverse sentence
            //Console.WriteLine("Please enter your sentence...");

            //var myStatement = Console.ReadLine();
            //string[] splitArray = myStatement.Split(' ');
            //Array.Reverse(splitArray);

            //var newSentence = string.Join(" ", splitArray);

            //Console.WriteLine(newSentence);

            //Console.ReadKey();

            //var movies = new string[] {
            //    "Forest Gump", "Pokemon Movie", "How to train your dragon"
            //};

            //foreach (var movie in movies)
            //{
            //    Console.WriteLine(movie);
            //}

            Product product1 = new Product
            {
                Price = 10m,
                Name = "Pens"
            };

            Product product2 = new Product
            {
                Price = 20m,
                Name = "Paper"
            };
            Console.WriteLine("{0} is worth {1:c}... but with tax it is {2:c}", product2.Name, product2.Price, product2.CalculateTax());
            Console.WriteLine("{0} is worth {1:c}... but with tax it is {2:c}", product1.Name, product1.Price, product1.CalculateTax());

            Compwnents myCompwnents = new Compwnents
            {
                Name = "Ionic",
                Description = "Make mobile apps with angularjs, html, css, and bootstrap"
            };

            Console.WriteLine(myCompwnents.Name + " - " + myCompwnents.Description);

            

            Console.ReadKey();
        }


    }
}
