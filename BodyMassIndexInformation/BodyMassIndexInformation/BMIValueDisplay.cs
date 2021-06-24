using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class BMIValueDisplay
    {
        public void display(float bmiValue)
        {
            if (bmiValue < 18.5)
            {
                System.Console.Write("Your weight is " + bmiValue + " UnderWeight");
            }
            else if (bmiValue >= 25)
            {
                System.Console.Write("Your weight is " + bmiValue + " overweight ");
            }
            else
            {
                System.Console.WriteLine("Your weight is " + bmiValue + " healthy");
            }

        }
    }
}
