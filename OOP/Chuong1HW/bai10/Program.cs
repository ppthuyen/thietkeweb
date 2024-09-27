using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap nam duong lich: ");
        int n = int.Parse(Console.ReadLine());

        if (namnhuan(n))
        {
            Console.WriteLine(n + " la nam nhuan.");
        }
        else
        {
            Console.WriteLine(n + " khong phai la nam nhuan.");
        }
    }

    static bool namnhuan(int n)
    {

        if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
