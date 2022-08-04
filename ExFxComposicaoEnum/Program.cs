using System;
using System.Globalization;
using ExFxComposicaoEnum.Etities;
using ExFxComposicaoEnum.Etities.Enums;

namespace ExFxComposicaoEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pegando os dados do cliente
            Console.WriteLine("Enter Cliente Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDare = DateTime.Parse(Console.ReadLine());    //convertendo uma string em date
            Console.WriteLine();
            Console.Write("Status: ");
            string status = Console.ReadLine();
            Console.WriteLine();

            //instanciando o cliente
            Client client = new Client(name, email, birthDare);

            //"instanciando o status"
            OrderStatus os = Enum.Parse<OrderStatus>(status);   //convertir o string para Enum

            //pegando os dados dos produtos
            Console.Write("How many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());

            //instanciando o order
            Order order = new Order(DateTime.Now, os, client);

            Console.WriteLine();

            //fazendo um for para pegar a quantidade solicitado
            for (int i = 0; i < qtd; i++)
            {

                Console.WriteLine($"Enter #{i + 1} product data:");
                Console.Write("Product name: ");
                string namePrd = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Product quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //istanciando o produto
                Product product = new Product(namePrd,price);

                //instanciando os objetos dos ietns do pedido
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);

                Console.WriteLine();


            }

            //exibindo para o usuario
            Console.WriteLine();
            Console.WriteLine(order);
            Console.WriteLine("Total: $" + order.Total().ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
