using System.Media;
using WinterInConsole.Menu;

namespace WinterInConsole.Christmas_Tree
{
    public class ChristmasTree
    {
        private static Random _random = new Random();

        public static void DrawChristmasTree()
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
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("*");
                            Console.ResetColor();
                        }

                        Console.WriteLine();
                    }

                    for (int i = 0; i < a - 1; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("|");
                    Console.ResetColor();
                    Console.WriteLine("\r\nPress any key to get back.");
                    Console.ReadKey();

                    break;
                }
                else
                {
                    MenuHelper.WrongInputValidation();
                }
            }
        }

        public static void DrawChristmasTreeWithMusic()
        {
            while (true)
            {
                SoundPlayer music = new SoundPlayer(@"Christmas Tree\JINGLE BELLS.wav");
                MenuHelper.PlayMusic(music);

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
                            Console.Write(" ");
                        }

                        for (int j = a - 1; j < a + i + i; j++)
                        {
                            int randomNumber = _random.Next(1, 10);

                            if (i == 0)
                            {
                                c[0] = '*';
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(c[0]);
                            }
                            else if (randomNumber == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(c);
                            }
                            else if (randomNumber == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
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

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("|");
                    Console.ResetColor();
                    Console.WriteLine("\r\nPress any key to get back.");
                    Console.ReadKey();

                    MenuHelper.StopMusic(music);
                    break;
                }
                else
                {
                    MenuHelper.WrongInputValidation();
                }
            }
        }
    }
}
