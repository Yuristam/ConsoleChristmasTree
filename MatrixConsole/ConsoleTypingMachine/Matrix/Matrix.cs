namespace ConsoleTypingMachine.Matrix;

public class Matrix
{
    public static void ShowMatrix()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        string neo = "Wake up, Neo.";
        neo.ToCharArray();
        
        for (int i = 0; i < neo.Length; i++)
        {
            Console.Write(neo[i]);
            Thread.Sleep(50);
        };
        
        Console.WriteLine();

        string[] neo2 = new string[] {
                "The Matrix has you.",
                "Follow the White Rabbit."
            };

        for (int i = 0; i < neo2.Length; i++)
        {
            Thread.Sleep(1000);
            Console.Clear();
        
            neo2[i].ToCharArray();
            
            for (int j = 0; j < neo2[i].Length; j++)
            {
                Console.Write(neo2[i][j]); 
                Thread.Sleep(50);
            };
            
            Console.WriteLine();
        }
        
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Knock, knock, Neo.");
        Thread.Sleep(1000);
        Console.ResetColor();
    }
}
