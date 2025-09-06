using BubbleWorldConsole.Helpers;

namespace BubbleWorldConsole
{
    public class Bubbles
    {
        private static Random rnd = new Random();
     
        public static void DrawBubbles()
        {
            Console.CursorVisible = false;
            Console.Clear();

            for (int i = 0; i < 3600; i++)
            {
                // uncomment below if you want background color to be white
                //Console.BackgroundColor = ConsoleColor.White;
                Console.Write(' ');
            }

            while (true)
            { 
                Console.SetCursorPosition(rnd.Next(0, 120), rnd.Next(0, 28));

                ColorHelper.SetRandomColor();

                Console.Write('o'); // change the symbol
                Thread.Sleep(30);  // change the speed
            }
        }
    }
}
