using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your height in meters");
            float bmiHeight = float.Parse(Console.ReadLine());


            System.Console.WriteLine("Enter your weight in kilograms");
            float bmiWeight = float.Parse(Console.ReadLine());

            BMICalculation bmi = new BMICalculation(bmiHeight, bmiWeight);
            float height    =  bmi.getHeight();
            float weight    =  bmi.getWeight();
            float bmiValue  =  bmi.bmicalculation();

            BMIValueDisplay bmiDisplay = new BMIValueDisplay();
            bmiDisplay.display(bmiValue);
        }
    }
}
