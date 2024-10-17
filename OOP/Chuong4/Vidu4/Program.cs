using System;

class Sinhvien
{
    private string MASV;
    private double DiemCSLT;

    public string getMASV()
    {
        return MASV;
    }

    public void setDiemCSLT(double diemcslt)
    {
        DiemCSLT = diemcslt;
    }

    public void ShowInfo()
    {
        MASV = "1234"; 
        Console.WriteLine("SV Ma so {0} co diem CSLT la: {1} ", MASV, DiemCSLT);
    }
}

class DiemHP
{
    static void Main(string[] args)
    {
        Sinhvien SV1 = new Sinhvien();
        SV1.setDiemCSLT(8);
        SV1.ShowInfo();
        Console.ReadKey(); 
    }
}
