using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Class
{
    class Milk:Product
    {
        public double Volume;
        public double FatRate;
        public Milk(string name,double price,double volume, double fatRate,byte purchase) :base(name, price,purchase)
        {
            Volume = volume;
            FatRate = fatRate;
            Console.Write("Yagliliq faizini daxil edin: ");
            FatRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Almaq istdeyiniz miqdari daxil edin: ");
            Purchase= Convert.ToByte(Console.ReadLine());


        }
        public override void Sell()
        {
            TotalSaled += Purchase;
            Console.WriteLine("Satilan mehsul sayi: " + TotalSaled);

            if (count > 0)
            {

                count -= Purchase;
                TotalIncome += Price*Purchase;
                
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
