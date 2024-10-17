using System;

class Program
{
    static void Main(string[] args)
    {
        HinhChuNhat hcn = new HinhChuNhat();
        hcn.Dai = 4.5;
        hcn.Rong = 3.5;
        hcn.Xuat();
        Console.ReadLine();
    }
}

class HinhChuNhat
{
    public double Dai { get; set; }
    public double Rong { get; set; }

    public double Tinhdientich()
    {
        return Dai * Rong;
    }

    public void Xuat()
    {
        Console.WriteLine("Chieu dai: {0}", Dai);
        Console.WriteLine("Chieu rong: {0}", Rong);
        Console.WriteLine("Dien tich HCN: {0}", Tinhdientich());
    }
}
