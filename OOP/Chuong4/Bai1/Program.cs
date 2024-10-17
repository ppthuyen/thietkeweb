using System;
class Phanso
{
    private int Tuso;
    private int Mauso;
    public Phanso()
    {
        Tuso = 0;
        Mauso = 1;
    }
    public Phanso ( int tuso, int mauso )
    {
        Tuso = tuso;
        Mauso = mauso;
    }

    public void Nhap()
    {
        Console.WriteLine("Tu so:");
        Tuso = int.Parse(Console.ReadLine());
        while (true)
        {
            Console.WriteLine("Mau so:");
            Mauso = int.Parse(Console.ReadLine());
            if (Mauso == 0)
            {
                Console.WriteLine("Nhap lai!");
            }
            else break;
        }
    }
    public Phanso Cong(Phanso ps)
    {
        Phanso kqua = new Phanso();
        kqua.Tuso = Tuso * ps.Mauso + ps.Tuso *Mauso;
        kqua.Mauso = Mauso * ps.Mauso;
        return kqua;
     }
     public Phanso Tru(Phanso ps)
     {
        Phanso kqua = new Phanso();
        kqua.Tuso = Tuso * ps.Mauso - ps.Tuso *Mauso;
        kqua.Mauso = Mauso * ps.Mauso;
        return kqua;
     }
     public Phanso Nhan(Phanso ps)
     {
        Phanso kqua = new Phanso();
        kqua.Tuso = Tuso * ps.Tuso ;
        kqua.Mauso = Mauso * ps.Mauso;
        return kqua;
     }
     public Phanso Chia(Phanso ps)
     {
        Phanso kqua = new Phanso();
        kqua.Tuso = Tuso * ps.Mauso;
        kqua.Mauso = Mauso * ps.Tuso;
        return kqua;
     }
     public void Xuat()
    {
        if (Tuso == Mauso)
        {
            Console.WriteLine("Ket qua = 1");
        }
        else if (Tuso == 0)
        {
            Console.WriteLine("Ket qua = 0");
        }
        else if (Mauso == 1)
        {
            Console.WriteLine("Ket qua = {0}", Tuso);
        }
        else Console.WriteLine("Ket qua = " + Tuso + "/" + Mauso);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Phan so A");
        Phanso phansoA = new Phanso();
        phansoA.Nhap();

        Console.WriteLine("Phan so B");
        Phanso phansoB = new Phanso();
        phansoB.Nhap();

        Phanso Cong = phansoA.Cong(phansoB);
        Phanso Tru = phansoA.Tru(phansoB);
        Phanso Nhan = phansoA.Nhan(phansoB);
        Phanso Chia = phansoA.Chia(phansoB);
        Cong.Xuat();
        Tru.Xuat();
        Nhan.Xuat();
        Chia.Xuat();
    }
}