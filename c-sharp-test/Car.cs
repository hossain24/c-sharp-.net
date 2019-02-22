using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace c_sharp_test
{
    public class Car
    {
        public string Barnd;
        public string Model;
        public string Color;

        public Car(string brand, string model, string color)
        {
            this.Barnd = brand;
            this.Model = model;
            this.Color = color;
        }

    }

}
