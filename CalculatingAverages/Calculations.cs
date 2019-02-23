using System;
using System.Collections.Generic;

namespace CalculatingAverages
{
    class Calculations
    {
        public int Sum(List<int> numbers)
        {
            int total = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                total += numbers[i];
            }

            return total;
        }

        public int Average(int sum, int amount)
        {
            return sum / amount;
        }

        public string Grade(int gradeValue)
        {
            switch(gradeValue)
            {
                case int value when value > 89:
                return "A";
                case int value when value < 90 && value > 79:
                return "B";
                case int value when value < 80 && value > 69:
                return "C";
                case int value when value < 70 && value > 59:
                return "D";
                case int value when value < 60:
                return "F";
                default:
                return null;
            }
        }
    }
}
