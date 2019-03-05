using System.Collections.Generic;
using Utilities.ConsoleUI;

namespace CalculatingAverages
{
    class Program
    {
        public static ColorPreset colorPreset;

        private static List<IMenuItem> menuItems;
        private static Menu mainMenu;

        static void Main(string[] args)
        {
            InitializeClasses();

            while (true)
            {
                do
                {
                    mainMenu.Display();

                } while (mainMenu.Selecting());

                menuItems[mainMenu.CurrentSelection()].Run();
            }
        }

        private static void InitializeClasses()
        {
            colorPreset = ColorPreset.Sprite;
            menuItems = new List<IMenuItem>();

            var sumNumbers = new SumNumbers();
            menuItems.Add(sumNumbers);

            var averageTenScores = new AverageTenScores();
            menuItems.Add(averageTenScores);

            var averageSpecificScores = new AverageSpecificScores();
            menuItems.Add(averageSpecificScores);

            var averageUnspecifiedScores = new AverageUnspecifiedScores();
            menuItems.Add(averageUnspecifiedScores);

            var exit = new Exit();
            menuItems.Add(exit);

            mainMenu = new Menu(menuItems, "Calculating Averages", colorPreset);
        }
    }
}
