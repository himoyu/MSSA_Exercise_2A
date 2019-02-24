using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.ConsoleUI;

namespace CalculatingAverages
{
    public class SumNumbers : Applet
    {
        private new string title = "Sum of Numbers";

        public override string Title()
        {
            return title;
        }

        public override void Run()
        {
            display = new Display(title, totalRows, Program.colorPreset);

             do
            {
                var numbers = new List<int>();

                for (int i = 0; i < 10; i++)
                {
                    while(true)
                    {
                        var input = display.Question("Please input a number to be added: ", 
                                                    $"You have currently input {i} numbers");

                        if(Int32.TryParse(input, out int result))
                        {
                            numbers.Add(result);
                            break;
                        }
                        else
                        {
                            display.SingleLine("That is not a number value.","Press ENTER to try again");
                        }
                    }
                } 

                var answer = numbers.Sum();
                display.SingleLine($"The sum of your input is {answer}.","Press ENTER to continue");

            } while (RunAgain());

        }
    }
}