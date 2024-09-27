using System;
using System.ComponentModel;
namespace bai4chuong3
{
    class Triangle
    {
        public int a,b,c;
        public Triangle (int canh1,int canh2,int canh3)
        {
            a = canh1;
            b = canh2;
            c = canh3;

        }
        public Triangle(){}
        public void Nhap()
        {
            Console.Write("a = ");
            a=int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b=int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c=int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Canh a = {0}, canh b = {1}, canh c = {2} ", a, b, c);
        }
        public double Chuvi()
        {
            return a+b+c;
        }
        public double Dientich()
        {
            double p=(a+b+c)/2;
            double S= Math.Sqrt(p*(p-a)*(p-b)*(p*c));
            return S;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tg = new Triangle();
            while (true)
            {
                Console.WriteLine("Bam 1 de nhap cac canh tam giac");
                Console.WriteLine("Bam 2 de tinh chu vi va dien tich");
                Console.WriteLine("Bam 3 de xuat cac gia tri tam giac");
                Console.WriteLine("Bam 0 de thoat");
                int bam = int.Parse(Console.ReadLine());
                switch (bam)
                {
                    case 1:
                        tg.Nhap();
                        break;
                    case 2:
                        if (tg.a + tg.b > tg.c & tg.a+ tg.c > tg.b & tg.b +tg.c > tg.a)
                        {
                            Console.WriteLine("Chu vi tam giac la: {0}",tg.Chuvi());
                            Console.WriteLine("Dien tich tam giac la: {0}",tg.Dientich());
                        }
                        else
                        {
                            Console.WriteLine("Khong hop le");
                        }
                        break;
                    case 3:
                        tg.Xuat();
                        break;
                    case 0:
                        return;
                }
            }

        }
    }
}