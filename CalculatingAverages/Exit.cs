using System;

namespace CalculatingAverages
{
    class Exit : Applet
    {
        private new string title = "Exit";

        public override void Run()
        {
            Console.Clear();
            Environment.Exit(0);
        }

        public override string Title()
        {
            return title;
        }   
    }
}
