using System;

class Hoanvi
{
    static void Hoan_vi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Trong phuong thuc Hoan_vi: a={0}, b={1}", a, b);
    }

    static void Main(string[] args)
    {
        int x = 3;
        int y = 4;
        Console.WriteLine("Truoc khi goi phuong thuc Hoan_vi: x={0}, y={1}", x, y);
        Hoan_vi(ref x, ref y); 
        Console.WriteLine("Sau khi goi phuong thuc Hoan_vi: x={0}, y={1}", x, y);

        Console.ReadKey(); 
    }
}
