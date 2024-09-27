using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguyen n: ");
        int n = int.Parse(Console.ReadLine());

        if (IsPrime(n))
        {
            Console.WriteLine(n + " la so nguyen to.");
        }
        else
        {
            Console.WriteLine(n + " khong phai la so nguyen to.");
        }
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false; 
            }
        }
        return true;
    }
}
