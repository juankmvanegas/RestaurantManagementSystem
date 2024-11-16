using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class OrderBeverageProcessor : OrderProcessor
    {
        protected override void PrepareOrder()
        {
            Console.WriteLine("Preparando bebida, Soda Saborizada.");
        }
        protected override decimal CalculateTotal()
        {
            decimal total = 15000.0m;
            Console.WriteLine($"Total a pagar: {total}");
            return total;
        }

        protected override bool IsStockAvailable()
        {
            Console.WriteLine("Verificando stock de ingredientes.");
            return true;
        }

        protected override bool ConfirmPayment()
        {
            Console.WriteLine("Confirmando pago con tarjeta de crédito.");
            Console.WriteLine("Tarjeta rechazada.");

            return false;
        }
    }
}
