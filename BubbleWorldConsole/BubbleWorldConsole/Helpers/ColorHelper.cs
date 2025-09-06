namespace BubbleWorldConsole.Helpers;

public class ColorHelper
{

    private static Random _rnd = new Random();
    private static int _colorNum;

    public static void SetRandomColor()
    {
        _colorNum = _rnd.Next(0, 15);

        switch (_colorNum)
        {
            case 0: Console.ForegroundColor = ConsoleColor.Black; break;
            case 1: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
            case 2: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
            case 3: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
            case 4: Console.ForegroundColor = ConsoleColor.DarkRed; break;
            case 5: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
            case 6: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
            case 7: Console.ForegroundColor = ConsoleColor.Gray; break;
            case 8: Console.ForegroundColor = ConsoleColor.DarkGray; break;
            case 9: Console.ForegroundColor = ConsoleColor.Blue; break;
            case 10: Console.ForegroundColor = ConsoleColor.Green; break;
            case 11: Console.ForegroundColor = ConsoleColor.Cyan; break;
            case 12: Console.ForegroundColor = ConsoleColor.Red; break;
            case 13: Console.ForegroundColor = ConsoleColor.Magenta; break;
            case 14: Console.ForegroundColor = ConsoleColor.Yellow; break;
            case 15: Console.ForegroundColor = ConsoleColor.White; break;
        }
    }

    public static void SetChosenColor(string userInput)
    {
        switch (userInput)
        {
            case "dark blue": Console.ForegroundColor = ConsoleColor.DarkBlue; break;
            case "dark green": Console.ForegroundColor = ConsoleColor.DarkGreen; break;
            case "dark cyan": Console.ForegroundColor = ConsoleColor.DarkCyan; break;
            case "dark red": Console.ForegroundColor = ConsoleColor.DarkRed; break;
            case "dark magenta": Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
            case "dark yellow": Console.ForegroundColor = ConsoleColor.DarkYellow; break;
            case "gray": Console.ForegroundColor = ConsoleColor.Gray; break;
            case "dark gray": Console.ForegroundColor = ConsoleColor.DarkGray; break;
            case "blue": Console.ForegroundColor = ConsoleColor.Blue; break;
            case "green": Console.ForegroundColor = ConsoleColor.Green; break;
            case "cyan": Console.ForegroundColor = ConsoleColor.Cyan; break;
            case "red": Console.ForegroundColor = ConsoleColor.Red; break;
            case "magenta": Console.ForegroundColor = ConsoleColor.Magenta; break;
            case "yellow": Console.ForegroundColor = ConsoleColor.Yellow; break;
            case "white": Console.ForegroundColor = ConsoleColor.White; break;
            case "random": SetRandomColor(); break;

            default:
                Console.Clear();
                Console.WriteLine("Sorry, there is no such color");
                Task.Delay(1000);
                break;
        }
    }

    public static void ChooseColor(ref string userInput)
    {
        Console.Clear();
        Console.Write(
            "Choose color:\r\n" +
            "1. Random\r\n" +
            "2. DarkBlue\r\n" +
            "3. DarkGreen\r\n" +
            "4. DarkCyan\r\n" +
            "5. DarkRed\r\n" +
            "6. DarkMagenta\r\n" +
            "7. DarkYellow\r\n" +
            "8. Gray\r\n" +
            "9. DarkGray\r\n" +
            "10. Blue\r\n" +
            "11. Green\r\n" +
            "12. Cyan\r\n" +
            "13. Red\r\n" +
            "14. Magenta\r\n" +
            "15. Yellow\r\n" +
            "16. White\r\n" +
            "17. Colorful\r\n" +
            ">");

        userInput = Console.ReadLine().ToLower().Trim();

        ColorHelper.SetChosenColor(userInput);
    }
}
