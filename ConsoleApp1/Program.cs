using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(/*string[] args*/)
        {
            int[] highscores = new int[10000];
            Random random = new Random();
            int count = 0;
            int randomIndex;
            bool isNotUnique;
            for (int c = 0; c < 5000; c++)
            {
                isNotUnique = false;
                for (int i = 0; i < highscores.Length; i++)
                {
                    highscores[i] = 0;
                }

                for (int r = 0; r < 100; r++)
                {
                    randomIndex = random.Next(0, highscores.Length);
                    highscores[randomIndex]++;
                    //randomIndex = 0;
                }

                for (int j = 0; j < highscores.Length; j++)
                {
                    if (highscores[j] > 1)
                    {
                        //Console.WriteLine("Yes");
                        //count++;
                        isNotUnique = true;
                    }
                    else
                    {
                        //Console.WriteLine("No");
                    }
                }
                if(isNotUnique)
                {
                    count++;
                }
            }
            Console.WriteLine(count + " van de 5000 checks was niet uniek");
            Console.WriteLine((count * 100) / 5000 + "% van de check was dus niet uniek");
        }
    }
}