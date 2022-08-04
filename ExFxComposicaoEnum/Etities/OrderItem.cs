
namespace ExFxComposicaoEnum.Etities
{
    internal class OrderItem
    {

        //atributos Propreties
        private int _quantity;
        private double _price;

        //Construtor
        public OrderItem() { 
        
        }

        public OrderItem(int quantity, double price) 
        {
            _quantity = quantity;
            _price = price;
        }

        //Get e Set
        public int Quantity
        {
            get { return _quantity; }

            set { _quantity = value; }
        }

        public double Price
        {

            get { return _price; }

            set { _price = value; }

        }

        //method
        public double SubTotal() {

            double subTotal = 0.0;

            //a operação do subtotal
            subTotal = Quantity * Price;

            return subTotal;

        }

    }
}
