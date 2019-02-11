using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_test
{
    public class Drive
    {
        public int distance;
        public int time;

        public int speed(int distance, int time)
        {
            return distance * time;
        }
    }
}
