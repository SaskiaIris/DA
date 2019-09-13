using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] birthdates = new int[100];
            Random random = new Random();

            for (int i = 0; i < birthdates.Length; i++)
            {
                birthdates[i] = random.Next(0, 10001);
            }

            for (int j = 0; j < birthdates.Length; j++)
            {
                for (int k = 0; k > birthdates.Length; k++)
                {
                    if (k != j && birthdates[j] == birthdates[k])
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }

            }          
        }
    }
}