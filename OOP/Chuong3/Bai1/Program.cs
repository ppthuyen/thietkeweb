using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;
namespace bai1chuong3
{
    public class Sach
    {
        public string Tensach;
        public string Tacgia;
        public int NamXB;
        public int Soluong;

        public Sach (string tensach, string tacgia,int namXB, int soluong)
        {
            Tensach = tensach;
            Tacgia = tacgia;
            NamXB = namXB;
            Soluong = soluong;
            
        }
        public Sach(){}

        public void Nhap()
        {
            Console.Write("Ten sach: ");
            Tensach = Console.ReadLine();
            Console.Write("Ten tac gia: ");
            Tacgia = Console.ReadLine();
            Console.Write("Nam xuat ban: ");
            NamXB = Convert.ToInt32(Console.ReadLine());
            Console.Write("So luong: ");
            Soluong = Convert.ToInt32(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write("Ten sach: {0}\nTac gia: {1}\nNam xuat ban: {2}\nSo luong: {3}",Tensach, Tacgia, NamXB, Soluong);            
        }
        ~Sach()
        {}
    }
    class Program
    {
        static void Main(string[] args)
        {
            string tensach = "Truyen Kieu";
            string tacgia = "Nguyen Du";
            int namXB = 1814;
            int soluong = 1000;
            Sach sach = new Sach(tensach, tacgia, namXB, soluong);
            sach.Xuat();
            Console.WriteLine();
            Sach sach1 = new Sach();
            sach1.Nhap();
            sach1.Xuat();
        }
    }

}
