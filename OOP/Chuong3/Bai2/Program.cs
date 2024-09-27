using System;
namespace bai2chuong4
{
    class Meo
    {
        string Ten;
        string Giong;
        string GioiTinh;
        int Tuoi; 
        public  static int Dem=0; 
        public Meo(string ten="", string giong="", string gioitinh="", int tuoi=0)
        {
            Ten = ten;
            Giong = giong;
            GioiTinh = gioitinh;
            Tuoi = tuoi;
            Dem++;

        }
        
        public Meo()
        {
            Dem++;
            Console.Write("Ten: ");
            Ten = Console.ReadLine();
            Console.Write("Giong: ");
            Giong = Console.ReadLine();
            Console.Write("Gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Tuoi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Be meo ten la {0}, giong {1}, gioi tinh {2}, {3} tuoi",Ten, Giong, GioiTinh,Tuoi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Meo meo1 = new Meo();           
            Meo meo2 = new Meo();
            Meo meo3 = new Meo();
            meo1.Xuat();
            meo2.Xuat();
            meo3.Xuat();
            Console.WriteLine("So luong: "+Meo.Dem );
        }
        
    }
}
