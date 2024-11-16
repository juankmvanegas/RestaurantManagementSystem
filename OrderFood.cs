using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class OrderFoodProcessor : OrderProcessor
    {
        protected override void PrepareOrder()
        {
            Console.WriteLine("Preparando comida, Hamburguesa con papas.");
        }
        protected override decimal CalculateTotal()
        {
            decimal total = 35000.0m;
            Console.WriteLine($"Total a pagar: {total}");
            return total;
        }

        protected override bool IsStockAvailable()
        {
            Console.WriteLine("Verificando stock de ingredientes.");
            return true;
        }
    }
}
