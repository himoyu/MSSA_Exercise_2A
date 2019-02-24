using System;
using System.Collections.Generic;
using Utilities.ConsoleUI;

namespace CalculatingAverages
{
    class AverageSpecificScores : Applet
    {
        private new string title = "Average a Specified Number of Grade Scores";

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
                var iterations = AskForNumberOfGrades();
                var numbers = AskForGrades(iterations);
                var sum = calculations.Sum(numbers);
                var answer = calculations.Average(sum, numbers.Count);
                var grade = calculations.Grade(answer);

                display.SingleLine($"The average grade of your scores is {grade}, ({answer}%).","Press ENTER to continue");

            } while (RunAgain("Would you like to try again?"));
        }

        private int AskForNumberOfGrades()
        {
            while(true)
            {
                var interationInput = display.Question("How many grades would like to input: ", "Enter a number value and press ENTER");
                string message;

                if(Int32.TryParse(interationInput, out int result))
                {
                    if(result > 0)
                    {
                        return result;
                    }
                    message = "Please input a number greater than 0.";
                }
                else
                {
                    message = "That is not a number.";
                }
                display.SingleLine(message,"Press ENTER to try again");
            }
        }
    }
}