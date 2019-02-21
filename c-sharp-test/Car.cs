using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace c_sharp_test
{
    public class Car
    {
        public static void carDetail(string Brand, string Model, string Color)
        {
            Console.WriteLine("The car details: \n Brand: {0} \n Model: {1} \n Color: {2}", Brand, Model, Color);
        }

        public static void saySomething()
        {
            string name = "";
            Console.Write("Enter your fist name: ");
            name = Console.ReadLine();
            Console.Write("Hello {0} ", name);
        }

    }

}
