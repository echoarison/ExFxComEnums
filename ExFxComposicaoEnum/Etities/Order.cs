using System;
using System.Text;
using ExFxComposicaoEnum.Etities.Enums;
using System.Collections.Generic;

namespace ExFxComposicaoEnum.Etities
{
    internal class Order
    {
        //atributos propreties
        private DateTime _moment;
        private OrderStatus _status;
        private List<OrderItem> _orderItens = new List<OrderItem>();    //para não da null List e class composicao
        private Client _client; //class composicao

        //Construto
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            _moment = moment;
            _status = status;
            _client = client;
        }

        //get e set
        public DateTime Moment
        {
            get { return _moment; }

            set { _moment = value; }
        }

        public OrderStatus Status
        {
            get { return _status; }

            set { _status = value; }

        }

        public List<OrderItem> OrderItens
        {
            get { return _orderItens; }

            set { _orderItens = value; }

        }

        public Client Client
        {
            get { return _client; }

            set { _client = value; }

        }

        //Methods
        public void AddItem(OrderItem item)
        {

            //adicionando na list
            OrderItens.Add(item);

        }

        public void RemoveItem(OrderItem item)
        {

            //removendo na list
            OrderItens.Remove(item);

        }

        public double Total() {

            double sumTotal = 0.0;

            //operação para somar tudo
            foreach (OrderItem item in OrderItens)
            {
                sumTotal += item.SubTotal();
            }

            return sumTotal;

        }

        //override
        public override string ToString()
        {

            /**
             * 
             * Usando o StringBuilder para construir o texto
             * 
             **/
            StringBuilder sb = new StringBuilder();

            //construindo o texto
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (" + Client.BrithDate.ToString() + ") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items: ");

            //Acessando a list com foreach
            foreach (OrderItem item in OrderItens)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
