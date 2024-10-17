using System;

namespace C4Vd3
{
    class Shape
    {
        protected int _rong;
        protected int _dai;

        public void SetRong(int rong)
        {
            _rong = rong;
        }

        public void SetDai(int dai)
        {
            _dai = dai;
        }

        public void Xuat()
        {
            Console.WriteLine("rong = {0}, dai = {1}", _rong, _dai);
        }
    }

    class hcn : Shape
    {
        public int TinhDientich()
        {
            return (_rong * _dai);
        }
    }

    class hcnTester
    {
        static void Main(string[] args)
        {
            hcn hcn = new hcn();
            hcn.SetRong(5);
            hcn.SetDai(7);
            hcn.Xuat();
            Console.WriteLine("Total area: {0}", hcn.TinhDientich());
            Console.ReadKey();
        }
    }
}
