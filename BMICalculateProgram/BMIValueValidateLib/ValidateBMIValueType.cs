using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIValueValidateLib
{
    public static class ValidateBMIValueType
    {
        public static string BmiValueValidate(float bmiValue)
        {
            if (bmiValue < 18.5)
                return bmiValue+ "Underweight";

            else if (bmiValue >= 25)
                return bmiValue+ "Overweight";

            else
                return bmiValue+ "healthy";
        }
    }
}
