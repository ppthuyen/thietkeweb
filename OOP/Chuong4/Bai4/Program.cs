using System;
class TTSV
{
    public string ID, Hoten, Group;
    public static int dem=0;
    public DiemTP DiemSV;
    public TTSV()
    {
        dem++;
        DiemSV = new DiemTP();
    }
    public void NhapTTSV()
    {
        
        Console.Write("Nhap ma sinh vien = ");
        ID=Console.ReadLine();
        Console.Write("Nhap ho ten sinh vien = ");
        Hoten=Console.ReadLine();
        Console.Write("Nhap lop sinh hoat = ");
        Group=Console.ReadLine();
        
    }
    public static void Xuatsoluong()
    {
       Console.WriteLine("So luong sinh vien co trong lop hoc phan OOP: {0}",dem);
        
    }
    public void XuatThongTinVaDiem()
    {
        Console.WriteLine("Ma sinh vien: {0}, Ho ten: {1}, Lop: {2}",ID, Hoten, Group);
        Console.WriteLine("Diem trung binh mon OOP: {0}", DiemSV.TinhdiemTB());
    }
}
class DiemTP
{
    public double TP1, TP2, TP3;
    public void NhapDTP()
    {
        Console.Write("Nhap diem TP1 = ");
        TP1=double.Parse(Console.ReadLine());
        Console.Write("Nhap diem TP2 = ");
        TP2=double.Parse(Console.ReadLine());
        Console.Write("Nhap diem TP3 = ");
        TP3=double.Parse(Console.ReadLine());
    }
    public double TinhdiemTB()
    {
        return TP1*0.1+TP2*0.3+TP3*0.6;
        
    }
    
    
}
class QuanLy
{
    static void Main()
    {
        TTSV svien = new TTSV();
        TTSV svien1 = new TTSV();

        svien.NhapTTSV();
        svien.DiemSV.NhapDTP();
        svien1.NhapTTSV();
        svien1.DiemSV.NhapDTP();

        TTSV.Xuatsoluong();
        svien.XuatThongTinVaDiem();       
        
        svien1.XuatThongTinVaDiem();
    }
}