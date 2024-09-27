using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so thu nhat: ");
        int so1 = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        int so2 = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thu ba: ");
        int so3 = int.Parse(Console.ReadLine());

        int soNhoNhat = so1;

        if (so2 < soNhoNhat)
        {
            soNhoNhat = so2;
        }

        if (so3 < soNhoNhat)
        {
            soNhoNhat = so3;
        }
        Console.WriteLine("So nho nhat trong 3 so la: " + soNhoNhat);
    }
}
