using System;

namespace FedorovAFA.Lerning
{
    public class Program
    {


        // TODO:  такие коментарии мо


        static void Main()
        {
            Console.WriteLine("                                 Нажмите Enter для начала работы");
            ConsoleClear();
            var ListCheck = new Check(0, 0);

            Sneakers ModelOne = new Sneakers(42, "Китай", "Бега", 3434, "Boost");
            var sum = ListCheck + ModelOne;
            Console.WriteLine(sum);
            
            Sneakers ModelTwo = new Sneakers(36, "Тайвань", "Деловые", 231, "Mister BIN");                        
            sum = sum + ModelTwo;
            Console.WriteLine(sum);
            ConsoleClear();
        }
        static void ConsoleClear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}