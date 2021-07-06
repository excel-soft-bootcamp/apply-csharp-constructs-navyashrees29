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

            float height = ReadUserInputsLib.ReadUserInputsType.GetUserHeight();
            float weight = ReadUserInputsLib.ReadUserInputsType.GetUserWeight();

            float bmiValue = BMICalculateLib.CalculateBMIType.BmiCalculation(height, weight);

            string message = BMIValueValidateLib.ValidateBMIValueType.BmiValueValidate(bmiValue);

            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(message);
        }
    }
}
