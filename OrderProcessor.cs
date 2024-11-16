using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public abstract class OrderProcessor
    {
        public void ProcessOrder()
        {
            TakeOrder();
            if (IsStockAvailable())
            {
                ConfirmOrder();
                PrepareOrder();

                if (ConfirmPayment())
                {
                    SuccessPayment();
                }
                else
                {
                    FailPayment();
                }
            }
            else
            {
                CancelOrder();
            }
        }
        protected void TakeOrder()
        {
            Console.WriteLine("Tomando orden.");
        }
        protected abstract void PrepareOrder();

        protected abstract decimal CalculateTotal();
        protected virtual bool IsStockAvailable()
        {
            return true;
        }

        protected virtual bool ConfirmPayment()
        {
            return true;
        }
        protected void SuccessPayment()
        {
            Console.WriteLine("Pago Procesado.");
        }

        protected void FailPayment()
        {
            Console.WriteLine("Pago fallido, debe lavar los platos.");
        } 
        protected void ConfirmOrder()
        {
            Console.WriteLine("Orden confirmada.");
        }

        protected void CancelOrder()
        {
            Console.WriteLine("Orden cancelada.");
        }

    }
}
