using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMICalculationProgram
{
    public class CheckSwitchCondition
    {
        public void ExcecuteSwitchCondition(Options choice)
        {
            switch (choice)
            {
                case Options.CONSOLEINPUT:
                    float height = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserHeight();
                    float weight = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserWeight();

                    float bmiValue = BMICalculateLib.CalculateBMIValueType.BmiCalculation(height, weight);

                    string message = BMIValueValidateLib.ValidateBMIValueType.ValidateBMIValue(bmiValue);

                    ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(message);
                    break;

                case Options.FILEINPUT:
                    try
                    {
                        string path = @"C:\Users\navyashrees\Desktop\BMICalculation.txt";
                        //Console.WriteLine("Enter File Path");
                        //string path = Console.ReadLine();
                        Console.WriteLine("Name\t Height\t Weight\t BMI Value\t Result\t");
                        string[] lines = File.ReadAllLines(path);
                        foreach (string line in lines)
                        {
                            string[] columns = line.Split(',');
                            string name = columns[0];
                            float heightValue = float.Parse(columns[1]);
                            float weightValue = float.Parse(columns[2]);

                            float getBmiValue = BMICalculateLib.CalculateBMIValueType.BmiCalculation(heightValue, weightValue);

                            string getMessage = BMIValueValidateLib.ValidateBMIValueType.ValidateBMIValue(getBmiValue);

                            Object[] printData = new Object[5];
                            printData[0] = name;
                            printData[1] = heightValue;
                            printData[2] = weightValue;
                            printData[3] = getBmiValue;
                            printData[4] = getMessage;

                            for (int i = 0; i < printData.Length; i++)
                            {
                                Console.Write(printData[i]+"\t");
                            }
                            Console.WriteLine();
                        }
                    }

                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("InValid Path,Please Check");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
            }
        }
    }
}
