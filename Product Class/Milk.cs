using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Class
{
    class Milk:Product
    {
        public double Volume;
        public double FatRate;
        public Milk(string name,double price,double volume, double fatRate) :base(name, price)
        {
            Volume = volume;
            FatRate = fatRate;

        }
        public override void Sell()
        {
            TotalSaled = ++countSaled;
            Console.WriteLine("Satilan mehsul sayi: " + TotalSaled);

            if (count > 0)
            {
               
                count--;
                TotalIncome += Price;
                Console.WriteLine($"Qalan mehsul sayi: {count}");
                Console.WriteLine($"Satisdan gelen umumi gelir: {TotalIncome}");
               

            }
            else
            {
                Console.WriteLine("Mehsul depoda yoxdur");
            }

           
        }


    }
}
