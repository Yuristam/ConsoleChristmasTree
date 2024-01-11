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
                    Console.SetCursorPosition(X, i);
                    Console.Write(Symbol);
                    Task.Delay(300).Wait();
                    Console.SetCursorPosition(X, i);
                    Console.Write(' ');
            }
        }
        public static void Snowing()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (true)
            {
                Random random = new Random();
                Snow snow = new(random.Next(31, 80), '*');
                
                for (int i = 0; i < 10; i++)
                {
                    snow.DrawSnow();
                }
            }
        }
    }
}
