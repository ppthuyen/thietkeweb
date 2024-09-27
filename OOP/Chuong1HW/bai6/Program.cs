using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine());

        if (b == 0)
        {
            if (c == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem.");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
        }
        else
        {
            double x = -c / b;
            Console.WriteLine("Nghiem cua phuong trinh la: x = " + x);
        }
    }
}
