using System;

namespace FedorovAFA.Lerning
{
    class Sneakers : Footwear
    {
        public string View { get; set; }
        public Sneakers(int Size, string Production, string View) : base(Size,Production)
        {
           this.View = View;
            PrintSizeProduction();
        }
        public override void PrintSizeProduction()
        {
            base.PrintSizeProduction();
            Console.WriteLine($"Предназеначен для: {View}");
        }
    }
}
