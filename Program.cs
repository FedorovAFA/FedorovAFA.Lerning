using System;

namespace FedorovAFA.Lerning
{   
    public class Program
    {

        static void Main(string[] args)
        {
            ConsoleClear();
            int  o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================================");
            Console.WriteLine($"Введенное число : {o}") ;
            ConsoleClear();
        }
        static void ConsoleClear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}