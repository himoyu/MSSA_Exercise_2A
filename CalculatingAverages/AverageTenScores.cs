using System;
using System.Collections.Generic;
using Utilities.ConsoleUI;

namespace CalculatingAverages
{
    class AverageTenScores : Applet
    {
        private new string title = "Average Ten Grade Scores";

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
                var numbers = AskForInput(10);
                var sum = calculations.Sum(numbers);
                var answer = calculations.Average(sum, numbers.Count);
                var grade = calculations.Grade(answer);

                display.SingleLine($"The average grade of your scores is a(n) {grade}, ({answer}%).","Press ENTER to continue");

            } while (RunAgain());
        }
    }
}