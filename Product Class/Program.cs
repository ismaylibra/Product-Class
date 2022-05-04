using System;

namespace Product_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Milk PallSud = new Milk("Pall Sud",2.5,1.0,1.5,10);
            PallSud.Sell();
            Milk Milla = new Milk("Milla",2.2,1.5,0.5,50);
            Milla.Sell();
        }
    }
}
