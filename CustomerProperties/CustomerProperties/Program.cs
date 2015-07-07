using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperties
{

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Birthday { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {


            Customer sally = new Customer
            {
                FirstName = "Sally",
                LastName = "Williams",
                Age = 23,
                Birthday = 2028
            };

            Customer mike = new Customer
            {
                FirstName = "Mike",
                LastName = "Harrison",
                Age = 10,
                Birthday = 2019
            };

            Console.WriteLine(" {0} {1} \n Age: {2} \n Birthday: {3} ", sally.FirstName, sally.LastName, sally.Age, sally.Birthday);
            Console.WriteLine("\n {0} {1} \n Age: {2} \n Birthday: {3} ", mike.FirstName, mike.LastName, mike.Age, mike.Birthday);
            Debug.Assert(mike.Age == 10, "Sally is 10.");
            Debug.Assert(sally.Age == 23, "Sally is 23.");
            Debug.Assert(mike.Age > 5 && sally.Age > 21, "Mike or Sally are too young.");





            Console.ReadKey();
        }
    }
}
