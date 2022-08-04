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

        //Construto
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            _moment = moment;
            _status = status;
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
    }
}
