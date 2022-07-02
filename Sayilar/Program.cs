using System;

namespace Sayilar
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Sayilar = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < Sayilar.Length; i++)
            {
                for(int j = 0; j < Sayilar.Length; j++)
                {
                    Console.WriteLine(Sayilar[i]+ " " +Sayilar[j]);
                }
   
            }

        }
    }
}
