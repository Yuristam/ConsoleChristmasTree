using System.Media;

namespace WinterInConsole.Christmas_Tree
{
    internal class ChristmasTree
    {
        internal static void DrawChristmasTree()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the level of Christmas Tree:");
                Console.Write(">");
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    for (int i = 0; i < a; i++)
                    {
                        for (int k = i + 1; k < a; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = a - 1; j < a + i + i; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen; //for the green color of tree
                            Console.Write("*");
                            Console.ResetColor();
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < a - 1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow; //for tree root
                    Console.WriteLine("|");
                    Console.ResetColor();
                    Console.WriteLine("\r\nPress any key to get back.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("You entered a wrong symbol, please enter number.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
        //==============================================================================================
        internal static void DrawDecoratedChristmasTree()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the level of Christmas Tree:");
                Console.Write(">");
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    for (int i = 0; i < a; i++)
                    {
                        for (int k = i + 1; k < a; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = a - 1; j < a + i + i; j++)
                        {
                            char c = '*';
                            Random random = new();
                            int r = random.Next(1, 5);
                            if (r == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(c);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(c);
                            }
                            Console.ResetColor();
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < a - 1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow; //for tree root
                    Console.WriteLine("|");
                    Console.ResetColor();
                    Console.WriteLine("\r\nPress any key to get back.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("You entered a wrong symbol, please enter number.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
        //==============================================================================================
        internal static void DrawDecoratedTreeWithMusic()
        {
            while (true)
            {
                // the christmas song part
                if (OperatingSystem.IsWindows())
                {
                    SoundPlayer music = new SoundPlayer(@"Christmas Tree\JINGLE BELLS.wav");
                    music.Load();
                    music.PlayLooping();
                    //music.Play();


                    // the christmas tree part
                    Console.Clear();
                    Console.WriteLine("Enter the level of Christmas Tree:");
                    Console.Write(">");
                    if (int.TryParse(Console.ReadLine(), out int a))
                    {
                        char[] c = new char[] { '*' };
                        for (int i = 0; i < a; i++)
                        {
                            for (int k = i + 1; k < a; k++)
                            {
                                Console.Write(" "); // int k(s)
                            }
                            for (int j = a - 1; j < a + i + i; j++)
                            {
                                Random random = new();
                                int r = random.Next(1, 10);
                                if (i == 0)
                                {
                                    c[0] = '*';
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(c[0]);
                                }
                                else if (r == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(c);
                                }
                                else if (r == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(c);
                                }
                                else if (r == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write(c);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(c); //int j(s)
                                }
                                Console.ResetColor();
                            }
                            Console.WriteLine(); //int i(s)
                        }
                        for (int i = 0; i < a - 1; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkYellow; //for tree root
                        Console.WriteLine("█");
                        Console.ResetColor();
                        Console.WriteLine("\r\nPress any key to get back.");
                        Console.ReadKey();
                        music.Stop(); //to stop the music
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You entered a wrong symbol, please enter number.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
            }
        }
    }
}
