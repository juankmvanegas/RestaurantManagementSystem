using System;

namespace RestaurantManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueOrdering = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al sistema de pedidos del restaurante.");
                Console.WriteLine("Seleccione el tipo de pedido:");
                Console.WriteLine("1. Comida");
                Console.WriteLine("2. Bebida");
                Console.WriteLine("3. Postre");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese su elección: ");

                string choice = Console.ReadLine();
                OrderProcessor orderProcessor = null;

                switch (choice)
                {
                    case "1":
                        orderProcessor = new OrderFoodProcessor();
                        break;
                    case "2":
                        orderProcessor = new OrderBeverageProcessor();
                        break;
                    case "3":
                        orderProcessor = new OrderDessertProcessor();
                        break;
                    case "4":
                        Console.WriteLine("Gracias por visitar nuestro restaurante. ¡Hasta luego!");
                        continueOrdering = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        continue;
                }

                if (orderProcessor != null)
                {
                    Console.WriteLine("\nProcesando su pedido...");
                    orderProcessor.ProcessOrder();
                }

                if (choice != "4")
                {
                    Console.WriteLine("\n¿Desea realizar otro pedido? (s/n): ");
                    string continueChoice = Console.ReadLine().ToLower();
                    if (continueChoice != "s")
                    {
                        Console.WriteLine("Gracias por visitar nuestro restaurante. ¡Hasta luego!");
                        continueOrdering = false;
                    }
                }

            } while (continueOrdering);
        }
    }
}

