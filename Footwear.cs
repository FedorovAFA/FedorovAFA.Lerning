using System;

namespace FedorovAFA.Lerning
{
    public abstract class Footwear
    {
        public int Size { get; set; }
        public string Production { get; set; }
        public decimal Price { get; set; }
        public Footwear(int size, string production, decimal Price)
        {
            this.Price = Price;
            this.Size = size;
            this.Production = production;

        }
        public virtual void PrintSizeProduction()
        {
            Console.WriteLine($"Размер:{Size} \nПроизводитель: {Production} \nЦена:{Price}$");
        }

    }
}
