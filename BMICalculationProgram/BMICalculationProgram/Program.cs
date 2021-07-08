using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMICalculationProgram
{
    public enum Options
    {
        CONSOLEINPUT=1,FILEINPUT
    }
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string displayMessage = $"Enter your choice {(int)Options.CONSOLEINPUT}->Console Input, {(int)Options.FILEINPUT}->File Input";
                Console.WriteLine(displayMessage);
                try
                {
                    Options choice = (Options)Int32.Parse(Console.ReadLine());
                
                    if (choice == Options.CONSOLEINPUT || choice == Options.FILEINPUT)
                        {
                            CheckSwitchCondition checkSwitchCondition = new CheckSwitchCondition();
                            checkSwitchCondition.ExcecuteSwitchCondition(choice);
                            break;
                        }
                    else { Console.WriteLine("Please enter valid input");}
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Enter integer value");
                }

            } while (true);
        }
    }
}
