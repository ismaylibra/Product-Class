using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Class
{
    abstract class Product
    {
        public string Name;
        public double Price;
        public static double TotalIncome;
        public static int TotalSaled=0;
        public static int countSaled = 0;
        public static int count=100;
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract void Sell();
        
    }
}
