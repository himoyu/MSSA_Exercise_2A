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
            var calculations = new Calculations();

             do
            {
                var numbers = AskForGrades(10);
                var answer = calculations.Sum(numbers);

                display.SingleLine($"The sum of your input is {answer}.","Press ENTER to continue");

            } while (RunAgain());

        }
    }
}