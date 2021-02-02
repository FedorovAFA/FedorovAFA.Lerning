using System;
using System.Collections.Generic;

namespace FedorovAFA.Lerning
{   
    public class Program
    {
        static void Main(string[] args)
        {
            int Count;

            List<int> list = new List<int>();
            
            list.Add(Convert.ToInt32( Console.ReadLine()));
            list.Add(Convert.ToInt32(Console.ReadLine())); 
            list.Add(Convert.ToInt32(Console.ReadLine()));
            list.Add(Convert.ToInt32(Console.ReadLine()));
            Count  = list.Count;
            Console.WriteLine(Count);
            for (int i = 0; list.Count <i ; ++)
            {
                 
            }
        }
        static void ConsoleClear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}