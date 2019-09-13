using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] highscores = new int[100];
            Random random = new Random();

            for (int i = 0; i < highscores.Length; i++)
            {
                highscores[i] = random.Next(0, 10001);
            }

            for (int j = 0; j < highscores.Length; j++)
            {
                for (int k = 0; k < highscores.Length; k++)
                {
                    if (k != j && highscores[j] == highscores[k])
                    {
                        Console.WriteLine("No");                        
                    }
                    else
                    {
                        Console.WriteLine("Yes");
                    }
                }
            }
        }
    }
}