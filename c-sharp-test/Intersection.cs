using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace c_sharp_test
{
    public class Intersection
    {
        static void Hello ()
        {
            string[] arr1 = { "maki", "nigiri", "sahimi" };
            string[] arr2 = { "salad", "stick", "maki" };

            var arr3 = arr1.Intersect(arr1);
            foreach(var i in arr3)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

        }

    }
}
