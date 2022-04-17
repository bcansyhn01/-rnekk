using System;
using System.Collections.Generic;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[25];

            for (int i = 0; i < 25; i++)
            {
                Random r = new Random();
                int sayilar = r.Next(100, 250);
                arr[i] = sayilar;
                
            }
           
            List<int> arr2 = new List<int>();
            foreach (int a in arr)
            {
                if (a % 3 == 0 && a % 5 == 0)
                {
                    arr2.Add(a);
                }
                
            }
            foreach (int item in arr)
            {
                int sayac = 0;
                foreach (int item2 in arr)
                {
                    if (item == item2) { sayac++; }
                }
                Console.WriteLine("{0} sayısında {1} tane", item, sayac);
            }

            foreach (int b in arr2)
            {

                Console.WriteLine("3 ve 5 e bölünür:" + b);
            }
            if(arr2.Count == 0)
            {
                Console.WriteLine("3 ve 5 e bölünen sayı yok");
            }
            Console.ReadKey();
        }

    }
}
