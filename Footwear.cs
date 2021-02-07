using System;

namespace FedorovAFA.Lerning
{
    public abstract class Footwear
    {
        public int Size { get; set; }
        public string Production { get; set; }
        public Footwear(int size, string production) 
        {
            if (string.IsNullOrWhiteSpace(production))
            {
                throw new ArgumentNullException(nameof(production));
            }
            this.Size = size;
            this.Production = production;
        }
        public virtual void PrintSizeProduction() 
        {
            Console.WriteLine($"Размер:{Size} \nПроизводитель: {Production}");
        }

    }
}
