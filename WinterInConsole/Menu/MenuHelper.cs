using System.Media;

namespace WinterInConsole.Menu
{
    public static class MenuHelper
    {
        public static void PrintMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Happy New Year!");

            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write('=');
            }

            Console.Write(
                "Main menu\r\n" +
                "1) Draw Christmas Tree (without decoration).\r\n" +
                "2) Draw Christmas Tree (with decoration and music)\r\n" +
                "3) Snowing\r\n" +
                "4) Exit\r\n" +
                ">");
            Console.ResetColor();
        }

        public static void WrongInputValidation()
        {
            Console.WriteLine("You entered wrong data, please enter correctly.");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static void PlayMusic(SoundPlayer music)
        {
            if (OperatingSystem.IsWindows())
            {
                music.Load();
                music.PlayLooping();
                //music.Play();
            }
        }

        public static void StopMusic(SoundPlayer music)
        {
            music.Stop();
        }
    }
}
