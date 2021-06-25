using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class BMIConsoleDisplay
    {
        public void UnderWeight(float bmiValue)
        {
            System.Console.Write("Your weight is " + bmiValue + " underweight");
        }

        public void OverWeight(float bmiValue)
        {
            System.Console.Write("Your weight is " + bmiValue + " overweight ");
        }

        public void Healthy(float bmiValue)
        {
            System.Console.WriteLine("Your weight is " + bmiValue + " healthy");
        }
    }
}
