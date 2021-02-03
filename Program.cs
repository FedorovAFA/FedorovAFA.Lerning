using System;

namespace FedorovAFA.Lerning
{   
    public class Program
    {

        static void Main()
        {
            ConsoleClear();
            int size = Convert.ToInt32(Console.ReadLine());
            string production = Console.ReadLine();
            string view = Console.ReadLine();
            Sneakers ModelOne = new Sneakers(size, production, view);
            ConsoleClear();
        }
        static void ConsoleClear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}