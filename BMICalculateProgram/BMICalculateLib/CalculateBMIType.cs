using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculateLib
{
    public static class CalculateBMIType
    {
        public static float height;
        public static float weight;
        public static float bmiValue;

        public static float BmiCalculation(float height,float weight)
        {
           return bmiValue = weight / height;
        }
    
    }
}
