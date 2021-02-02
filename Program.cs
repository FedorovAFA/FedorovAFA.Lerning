using System;

namespace FedorovAFA.Lerning
{   
    public class Program
    {

        static void Main(string[] args)
        {
            int  o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================================");
            Console.WriteLine(o);
            ConsoleClear();
        }
        static void ConsoleClear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}