using System;
using System.Collections.Generic;
using Utilities.ConsoleUI;

namespace CalculatingAverages
{
    class AverageUnspecifiedScores : Applet
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
                var numbers = AskForGrades();
                var sum = calculations.Sum(numbers);
                var answer = calculations.Average(sum, numbers.Count);
                var grade = calculations.Grade(answer);

                display.SingleLine($"The average grade of your scores is {grade}, ({answer}%).","Press ENTER to continue");

            } while (RunAgain("Would you like to try again?"));
        }

        private List<int> AskForGrades()
        {
            int iterations = 0;
            var numbers = new List<int>();

            do
            {
                while(true)
                {
                    string message = "";
                    var input = display.Question("Please input a number to be added: ",
                                                $"You have currently input {iterations} numbers");

                    if (Int32.TryParse(input, out int result))
                    {
                        if (result >= 0 && result <= 100)
                        {
                            numbers.Add(result);
                            iterations++;
                            break;
                        }
                            message = "Please enter a value from 0 to 100.";

                    }
                    else
                    {
                        message = "That is not a number value.";
                    }

                    display.SingleLine(message, "Press ENTER to try again");
                }
                
            } while(RunAgain("Would you like to enter another grade?"));

            return numbers;
        }
    }
}