using System;
using System.Collections.Generic;

namespace FedorovAFA.Lerning
{
    class Check
    {
        public decimal Sum { get; set; }
        public int Quantity { get; set; }
        public Check(decimal Sum, int Quantity)
        {

            this.Sum = Sum;
            this.Quantity = Quantity;
            PrintCheckList();
        }

        public void PrintCheckList()
        {
            Console.WriteLine($"Сумма:{Sum}$ Количество:{Quantity}");
            Console.WriteLine("=============================================================");
        }

        public static Check operator +(Check List, Sneakers Model)
        {
            int quantity = List.Quantity + 1;

            decimal sum = List.Sum + Model.Price;
            var Score = new Check(sum, quantity);
            return Score;
        }

    }
}

