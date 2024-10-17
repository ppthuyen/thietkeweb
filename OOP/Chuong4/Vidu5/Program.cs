using System;

class Hocsinh
{
    private string ten;
    public string TEN
    {
        get { return ten; }
        set { ten = value; }
    }

    public static int Count = 0;

    public Hocsinh()
    {
        Console.Write("Nhap ho ten hoc sinh: ");
        ten = Console.ReadLine();
        Count++;
    }
}

class SodoHocsinh
{
    static void Main()
    {
        Console.WriteLine("So luong hoc sinh ban dau: " + Hocsinh.Count);
        Hocsinh hs1 = new Hocsinh();
        Console.WriteLine("So luong hoc sinh hien tai: " + Hocsinh.Count);
        Hocsinh hs2 = new Hocsinh();
        Console.WriteLine("So luong hoc sinh hien tai: " + Hocsinh.Count);
        
        // Dừng màn hình để xem kết quả
        Console.ReadKey();
    }
}
