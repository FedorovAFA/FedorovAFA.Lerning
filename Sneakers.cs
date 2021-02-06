using System;

namespace FedorovAFA.Lerning
{
    class Sneakers : Footwear
    {
        public string Name { get; set; }
        public string View { get; set; }
        public Sneakers(int Size, string Production, string View, decimal Price, string Name) : base(Size, Production, Price)
        {
            this.Name = Name;
            this.View = View;
            PrintSizeProduction();
        }
        public override void PrintSizeProduction()
        {
            base.PrintSizeProduction();
            Console.WriteLine($"Предназеначен для {View} \nНазвание:{Name}");
            Console.WriteLine("=============================================================");
        }

    }
}
