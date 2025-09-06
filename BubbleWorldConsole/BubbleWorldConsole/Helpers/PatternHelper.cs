using BubbleWorldConsole.Patterns;

namespace BubbleWorldConsole.Helpers
{
    public static class PatternHelper
    {
        private static string _chosenColor;
        private static string _chosenPattern;

        public static void DrawChosenPattern(string userInput)
        {
            while (true)
            {
                Pattern.ChoosePattern(ref userInput);
                _chosenPattern = userInput;
                _chosenPattern.ToCharArray();

                ColorHelper.ChooseColor(ref userInput);
                _chosenColor = userInput;

                Console.Clear();
                for (int i = 0; i < _chosenPattern.Length; i++)
                {
                    if (_chosenPattern[i] == ' ') Console.Write(_chosenPattern[i]);

                    else
                    {
                        if (_chosenColor == "colorful") ColorHelper.SetRandomColor();

                        Console.Write(_chosenPattern[i]);
                        Thread.Sleep(5);
                    }
                };

                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
