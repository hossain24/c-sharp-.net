using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace c_sharp_test
{
    public class main
    {

        static void Main(string[] args)
        {
            var car = new Car("Porche", "Camera S", "Black");

            Console.WriteLine("The car is {0} : {1} and {3} colored", car.Barnd, car.Model, car.Color);
            
            string[] arr1 = { "maki", "nigiri", "sahimi" };
            string[] arr2 = { "salad", "stick", "maki" };

            var arr3 = arr1.Intersect(arr2);
            var last = arr2.Last();
            foreach (var i in arr3)
            {
                Console.WriteLine("\n" + i + " " + last);
            }

            int[] sample = new int[10];
            int j;

            for (j = 0; j < 10; j++)
            {
                sample[j] = j;
            }

            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("\n[Sample " + j + " ]: " + sample[j]);
            }

            int[] nums = new int[5];
            double avg = 0;

            nums[0] = 15;
            nums[1] = 29;
            nums[2] = 37;
            nums[3] = 43;
            nums[4] = 55;

            for (int k = 0; k < 5; k++)
            {
                avg = avg + nums[k];
            }
            avg = avg / 5;
            Console.WriteLine("\n" + avg);

            int[] calAverage = { 12, 56, 79, 95, 54 };
            int sum = 0;
            int avg2 = 0;

            for (int m = 0; m < 5; m++)
            {
                sum = sum + calAverage[m];
                avg2 = avg2 + calAverage[m];
            }
            avg2 = avg2 / 5;
            Console.WriteLine("The sum of array's elements is " + sum);
            Console.WriteLine("The average of the array's elements is " + avg2);

            string[,] userName = new string[2, 2] { {"Bob", "Alice" }, {"John", "Doe"} };
            Console.WriteLine(userName[1, 1]);

            int[,] towDimArray = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for(int k = 0; k < 4; k++)
                {
                    towDimArray[i, k] = ((i * 4) + i + 1);
                    Console.Write(towDimArray[i, k] + " ");
                }
                Console.WriteLine();
            }

            var hill = new Hill("Green Hill", "Green");
            
            
            Console.WriteLine("The hill name is {0} and it is {1} colored", hill.Name, hill.Color);

            Drive drive = new Drive();

            // drive.distance = 200;
            // drive.time = 5;
            int calSpeed = drive.speed(200, 5);
            Console.WriteLine(calSpeed);

            string loopName = "Hello World";

            for (int i = 0; i <loopName.Length; i++)
            {
                Console.WriteLine(loopName[i]);
            }

            Logic logic = new Logic();

            for (int i = 0; i <10; i++)
            {
                if (logic.isPrime(i) == true) {
                    Console.WriteLine(i + " is a prime number.");
                } else Console.WriteLine(i + " is not a prime number.");
            }

            Console.WriteLine("Maximum size of integer: {0}", int.MaxValue);
            Console.WriteLine("Minimum size of integer: {0}", int.MinValue);

            saySomething();

            Console.ReadLine();

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
