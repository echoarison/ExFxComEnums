
namespace ExFxComposicaoEnum.Etities
{
    internal class Product
    {

        //atributos Propreties
        private string _name;
        private double _price;

        //Construtor
        public Product()
        {
        }

        public Product(string name, double price)
        {

            _name = name;
            _price = price;

        }

        //Get e Set
        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        public double Price 
        {

            get { return _price; }

            set { _price = value; }

        }

    }
}
