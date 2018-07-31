namespace School.Library
{
    public class Staff : Person
    {
        private string _school;
        private double _pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public Staff() : base()
        {
            School = default(string);
            Pay = default(double);
        }

        public string School { get { return _school; } set { _school = value; } }
        public double Pay { get { return _pay; } set { _pay = value; } }

        public override string ToString()
        {
            return $"Staff[{base.ToString()},school={School},pay={Pay}]";
        }
    }
}
