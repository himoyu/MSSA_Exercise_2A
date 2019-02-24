using System.Collections.Generic;
using System.Linq;

namespace CalculatingAverages
{
    class Calculations
    {
        public int Sum(List<int> numbers)
        {
            return numbers.Sum();
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
