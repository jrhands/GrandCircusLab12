namespace School.Library
{
    public class Student : Person
    {
        private string _program;
        private int _year;
        private double _fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public Student() : base()
        {
            Program = default(string);
            Year = default(int);
            Fee = default(double);
        }

        public string Program { get { return _program; } set { _program = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        public double Fee { get { return _fee; } set { _fee = value; } }

        public override string ToString()
        {
            return $"Student[{base.ToString()},program={Program},year={Year},fee={Fee}]";
        }
    }
}
