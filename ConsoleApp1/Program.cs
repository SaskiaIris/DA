using System;
using System.Diagnostics;
using System.Threading;

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
            int aantalRuns = 100000;
            Stopwatch stopwatch = new Stopwatch();
            //TimeSpan[] runTijd = new TimeSpan[aantalRuns];
            TimeSpan totaleTijd = 0;
            TimeSpan gemiddeldeTijd;
            stopwatch.Start();

            for (int z = 0; z < aantalRuns; z++)
            {
                Thread.Sleep(1);
                isNotUnique = false;
                for (int i = 0; i < highscores.Length; i++)
                {
                    highscores[i] = random.Next(0, 10000);
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
                if (isNotUnique)
                {
                    count++;
                }
                stopwatch.Stop();
                //runTijd[z] = stopwatch.Elapsed;
                totaleTijd += stopwatch.Elapsed;
                //Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

            }
            gemiddeldeTijd = totaleTijd / aantalRuns;
            Console.WriteLine("De gemiddelde runtijd was: " + gemiddeldeTijd);
            //Console.WriteLine(count + " of the runned checks was not unique");
            //Console.WriteLine((count * 100) / 5000 + "% of the runned checks was not unique");
        }
    }
}
