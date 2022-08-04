using System.Globalization; //mudando o formato da "," para "."

namespace ExFxComposicaoEnum.Etities
{
    internal class OrderItem
    {

        //atributos Propreties
        private int _quantity;
        private double _price;
        private Product _product; //class composicao

        //Construtor
        public OrderItem() { 
        
        }

        public OrderItem(int quantity, double price, Product product) 
        {
            _quantity = quantity;
            _price = price;
            _product = product;
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

        public Product Product
        {

            get { return _product; }

            set { _product = value; }

        }

        //method
        public double SubTotal() {

            double subTotal = 0.0;

            //a operação do subtotal
            subTotal = Quantity * Price;

            return subTotal;

        }

        //override
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
