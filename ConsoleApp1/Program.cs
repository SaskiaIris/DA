using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] highscores = new int[100];
            Random random = new Random();
            int count = 0;
            bool isNotUnique;

            for (int z = 0; z < 5000; z++)
            {
                isNotUnique = false;
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
                            //Console.WriteLine("No");
                            //count++;
                            isNotUnique = true;
                        }
                        else
                        {
                            //Console.WriteLine("Yes");                           
                        }
                    }
                }
                if(isNotUnique)
                {
                    count++;
                }
                
            }
            Console.WriteLine(count + " of the runned checks was not unique");
            Console.WriteLine((count * 100) / 5000 + "% of the runned checks was not unique");
        }
    }
}