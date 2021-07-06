using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReadUserInputsLib
{
    public static class ReadUserInputsType
    {
        public static int GetUserHeight()
        {
            int height = int.Parse(ReadFromConsole("Enter your height in meter:"));
            return height;
        }

        public static int GetUserWeight()
        {
            int weight = int.Parse(ReadFromConsole("Enter your weight in kg:"));
            return weight;
        }
        private static string ReadFromConsole(string message)
        {

            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

       


    }
}
