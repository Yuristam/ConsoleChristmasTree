namespace WinterInConsole.Snowing
{
    internal class Snow
    {
        public int X { get; set; }
        public char Symbol { get; set; }

        public Snow(int x, char symbol)
        {
            X = x;
            Symbol = symbol;
        }
        public void DrawSnow()
        {
            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(X, i);
                    Console.WriteLine(Symbol);
                    Task.Delay(100).Wait();
                    Console.SetCursorPosition(X, i);
                    Console.WriteLine(' ');
                }
            }
        }
        public static void Snowing()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Random random = new Random();
                    Snow snow = new(random.Next(31, 80), '*');
                    snow.DrawSnow();
                }
            }
        }
    }
}
