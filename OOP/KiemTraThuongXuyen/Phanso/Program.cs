using System;

public class Phanso
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public Phanso()
    {
        TuSo = 0;
        MauSo = 1; 
    }

    public Phanso(int tuSo, int mauSo)
    {
        if (mauSo == 0)
        {1  
            throw new ArgumentException("Mẫu số không được bằng 0");
        }
        this.TuSo = tuSo;
        this.MauSo = mauSo;
    }

    ~Phanso() 
    {
    }

    public void Nhap()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập tử số: ");
        TuSo = int.Parse(Console.ReadLine());
        
        do
        {
            Console.Write("Nhập mẫu số (khác 0): ");
            MauSo = int.Parse(Console.ReadLine());
        } while (MauSo == 0);
    }

    public void Xuat()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Phân số: {TuSo}/{MauSo}");
    }

    public Phanso Cong(Phanso ps)
    {
        Phanso ketQua = new Phanso();
        
        ketQua.TuSo = this.TuSo * ps.MauSo + ps.TuSo * this.MauSo;
        ketQua.MauSo = this.MauSo * ps.MauSo;

        return ketQua;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Phanso ps1 = new Phanso();
        Phanso ps2 = new Phanso();
        
        Console.WriteLine("Nhập phân số thứ nhất:");
        ps1.Nhap();
        Console.WriteLine("Nhập phân số thứ hai:");
        ps2.Nhap();

        Phanso ketQua = ps1.Cong(ps2);
    
        Console.WriteLine("Kết quả của phép cộng là:");
        ketQua.Xuat();
    }
}
