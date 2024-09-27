using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap vao so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        int S1 = 0;
        for (int i = 1; i <= n; i++)
        {
            S1 += i;
        }

        double S2 = 0.0;
        for (int i = 1; i <= n; i++)
        {
            S2 += 1.0 / i;
        }

        Console.WriteLine("Tong S1 = " + S1);
        Console.WriteLine("Tong S2 = " + S2);
    }
}
