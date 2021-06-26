using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class ReadUserInputs
    {
        /*    public float UserHeightInput()
            {
                System.Console.WriteLine("Enter your height in meters");
                float bmiHeight = float.Parse(Console.ReadLine());
                return bmiHeight;

            }
            public float UserWeightInput()
            {
                System.Console.WriteLine("Enter your weight in kilograms");
                float bmiWeight = float.Parse(Console.ReadLine());
                return bmiWeight;
            }
           */

        public int GetUserHeight()
        {
            int height = int.Parse(this.ReadFromConsole("Enter your height in meter:"));
            return height;
        }

        public int GetUserWeight()
        {
            int weight = int.Parse(this.ReadFromConsole("Enter your weight in kg:"));
            return weight;
        }
        private string ReadFromConsole(string message)
        {

            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
