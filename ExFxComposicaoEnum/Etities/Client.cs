using System;

namespace ExFxComposicaoEnum.Etities
{
    internal class Client
    {
        //atributos Proprities
        private string _name;
        private string _email;
        private DateTime _brithDate;

        //Construtor
        public Client()
        {
        }

        public Client(string name, string email, DateTime brithDate)
        {

            _name = name;
            _email = email;
            _brithDate = brithDate;

        }

        //Get e Set(Proprities)
        public string Name
        {

            get { return _name; }

            set { _name = value; }

        }

        public string Email
        {
            get { return _email; }

            set { _email = value; }
        }

        public DateTime BrithDate
        {
            get { return _brithDate; }

            set { _brithDate = value; }
        }
    }
}
