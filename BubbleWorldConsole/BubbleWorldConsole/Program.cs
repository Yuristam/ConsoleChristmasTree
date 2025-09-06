using BubbleWorldConsole;
using BubbleWorldConsole.Helpers;

Console.Title = "World of Bubbles";

Console.Write(
    "Enter the drawing pattern:\r\n" +
    "1. Pattern (type 'pattern')\r\n" +
    "2. Bubbles (type whatever you want)\r\n" +
    ">");

string userInput = Console.ReadLine().ToLower().Trim();

if (userInput == "pattern")
{
    PatternHelper.DrawChosenPattern(userInput);
}
else
{
    Bubbles.DrawBubbles();
}
