using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_test
{
    public class Logic
    {
        public bool isPrime(int p)
        {
            if (p <= 1) return false;

            for (int i = 2; i <= p/i; i++)
            {
                if ((p % i) == 0) return false;
            }

            return true;
        }
    }
}
