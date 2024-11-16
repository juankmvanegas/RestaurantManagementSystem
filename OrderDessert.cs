using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class OrderDessertProcessor : OrderProcessor
    {
        protected override void PrepareOrder()
        {
            Console.WriteLine("Preparando postre, Helado de Vainilla.");
        }
        protected override decimal CalculateTotal()
        {
            decimal total = 10000.0m;
            Console.WriteLine($"Total a pagar: {total}");
            return total;
        }
        protected override bool IsStockAvailable()
        {
            Console.WriteLine("Verificando stock de ingredientes.");
            Console.WriteLine("Sin Stock");
            return false;
        }

    }
    
}
