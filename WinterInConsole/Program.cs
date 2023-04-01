using WinterInConsole.Christmas_Tree;
using WinterInConsole.Snowing;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to my console app!");
    for (int i = 0; i < Console.BufferWidth; i++)
    {
        Console.Write('=');
    }
    Console.ResetColor();

    // the Main Menu of the program
    Console.WriteLine("Main menu\r\n" +
                      "1) Draw Christmas Tree (without decoration).\r\n" +
                      "2) Draw Christmas Tree (with decoration).\r\n" +
                      "3) Draw Christmas Tree (with decoration and music)\r\n" +
                      "4) Snowing\r\n" +
                      "5) Exit");
    Console.Write(">");

    string input = Console.ReadLine().Trim().ToLower();

    switch (input)
    {
        case "1":
            ChristmasTree.DrawChristmasTree();
            break;
        case "2":
            ChristmasTree.DrawDecoratedChristmasTree();
            break;
        case "3":
            ChristmasTree.DrawDecoratedTreeWithMusic();
            break;
        case "4":
            Console.Clear();
            Snow.Snowing();
            break;
        case "5":
            Environment.Exit(0);
            break;
        default:
            Console.Clear();
            Console.WriteLine("Please, write something that is in the list above.");
            Thread.Sleep(1000);
            Console.Clear();
            break;
    }
}
