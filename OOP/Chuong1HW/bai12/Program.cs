using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Cac so nguyen duong tu 1 đen " + n + ":");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        int tong = 0;
        for (int i = 1; i <= n; i++)
        {
            tong += i;
        }

        double trungBinhCong = (double)tong / n;

        Console.WriteLine("Tong cac so tu 1 den " + n + ": " + tong);
        Console.WriteLine("Trung binh cong cac so tu 1 den " + n + ": " + trungBinhCong);
    }
}
