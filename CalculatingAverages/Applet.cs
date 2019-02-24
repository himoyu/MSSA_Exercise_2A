using System;
using System.Collections.Generic;
using Utilities.ConsoleUI;

namespace CalculatingAverages
{
    public class Applet : IMenuItem
    {
        protected Display display;

        protected string title;
        protected int totalRows = 4;

        public virtual void Run()
        {
            //entry point for the applet
        }

        public virtual string Title()
        {
            return title;
        }

        protected List<int> AskForGrades(int iterations)
        {
            var numbers = new List<int>();

                for (int i = 0; i < iterations; i++)
                {
                    while(true)
                    {
                        string message;
                        var input = display.Question("Please input a number to be added: ", 
                                                    $"You have currently input {i} numbers");

                        if(Int32.TryParse(input, out int result))
                        {
                            if(result >= 0 && result <= 100)
                            {
                                numbers.Add(result);
                                break;
                            }
                            
                            message = "Please enter a value from 0 to 100.";
                            
                        }
                        else
                        {
                            message = "That is not a number value.";
                        }

                        display.SingleLine(message,"Press ENTER to try again");

                    }
                }
            return numbers;
        }

        protected bool RunAgain()
        {
            var runAgainList = new List<IMenuItem>
            {
                new Option("Yes"),
                new Option("No")
            };

            var runAgainMenu = new Menu(runAgainList, "Would you like to try again?", Program.colorPreset);
            do
            {
                runAgainMenu.Display();

            } while (runAgainMenu.Selecting());

            return runAgainMenu.CurrentSelection() == 0;
        }
    }
}
