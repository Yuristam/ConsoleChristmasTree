using WinterInConsole.Christmas_Tree;
using WinterInConsole.Menu;
using WinterInConsole.Snowing;

while (true)
{
    MenuHelper.PrintMenu();

    string input = Console.ReadLine().Trim().ToLower();

    switch (input)
    {
        case "1": ChristmasTree.DrawChristmasTree(); break;
        case "2": ChristmasTree.DrawChristmasTreeWithMusic(); break;
        case "3": Console.Clear(); Snow.Snowing(); break;
        case "4": Environment.Exit(0); break;

        default: MenuHelper.WrongInputValidation(); break;
    }
}
