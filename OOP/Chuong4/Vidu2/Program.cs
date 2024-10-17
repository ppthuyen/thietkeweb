namespace C4Vd2
{
    class Hinhchunhat
    {
        private double _dai;
        private double _rong;
        public Hinhchunhat(double dai, double rong)
        {
            _dai = dai;
            _rong = rong;
        }
        public double Tinhdientich()
        {
            return _dai * _rong;
        }
        public void Xuat()
        {
            Console.WriteLine("Chieu Dai: {0}", _dai);
            Console.WriteLine("Chieu Rong: {0}", _rong);
            Console.WriteLine("Dien tich HCN: {0}", Tinhdientich());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hinhchunhat hcn = new Hinhchunhat(5.5, 3.5);
            hcn.Xuat();
            Console.ReadLine();
        }
    }
}