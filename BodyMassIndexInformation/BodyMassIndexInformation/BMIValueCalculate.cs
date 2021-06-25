using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class BMIValueCalculate
    {
        BMIConsoleDisplay display = new BMIConsoleDisplay();
        public void BmiCompute(float bmiValue)
        {
            if (bmiValue < 18.5)
                display.UnderWeight(bmiValue);

            else if (bmiValue >= 25)
                display.OverWeight(bmiValue);

            else
                display.Healthy(bmiValue);
        }
    }
}
