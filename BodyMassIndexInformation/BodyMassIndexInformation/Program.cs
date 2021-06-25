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

            ReadUserInputs userInput = new ReadUserInputs();
            float bmiHeight = userInput.UserHeightInput();
            float bmiWeight = userInput.UserWeightInput();

            BMICalculate bmi = new BMICalculate(bmiHeight, bmiWeight);
            float bmiValue = bmi.BmiCalculation();

            BMIValueCalculate bmiValueCalculate = new BMIValueCalculate();
            bmiValueCalculate.BmiCompute(bmiValue);

        }
    }
}
