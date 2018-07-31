namespace School.Library
{
    public class Person
    {
        private string _name;
        private string _address;

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Person()
        {
            Name = default(string);
            Address = default(string);
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public override string ToString()
        {
            return $"Person[name={Name},address={Address}]";
        }
    }
}
