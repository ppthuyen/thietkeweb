using System;
class SoPhuc
{
    float PhanAo;
    float PhanThuc;
    public SoPhuc(float PhanAo,float PhanThuc)
    {
        this.PhanAo=PhanAo;
        this.PhanThuc=PhanThuc;
    }
    public SoPhuc(){
        PhanAo=0;
        PhanThuc=0;
    }
    public void Nhap()
    {
        Console.Write("Phan ao = ");
        PhanAo = float.Parse(Console.ReadLine());
        Console.Write("Phan thuc = ");
        PhanThuc=float.Parse(Console.ReadLine());
    }
    public SoPhuc Cong(SoPhuc sp)
    {
        SoPhuc kqua = new SoPhuc();
        kqua.PhanAo=PhanAo + sp.PhanAo;
        kqua.PhanThuc=PhanThuc + sp.PhanThuc;
        return kqua;
    }
    public SoPhuc Tru(SoPhuc sp)
    {
        SoPhuc kqua = new SoPhuc();
        kqua.PhanAo=PhanAo - sp.PhanAo;
        kqua.PhanThuc=PhanThuc - sp.PhanThuc;
        return kqua;
    }
    public SoPhuc Nhan(SoPhuc sp)
    {
        SoPhuc kqua = new SoPhuc();
        kqua.PhanAo=(PhanAo * sp.PhanAo) - (PhanThuc * sp.PhanThuc);
        kqua.PhanThuc= (PhanAo * sp.PhanThuc) + (PhanThuc * sp.PhanAo);
        return kqua;
    }
    public SoPhuc Chia(SoPhuc sp)
    {
        SoPhuc kqua = new SoPhuc();
        kqua.PhanAo= ((PhanAo * sp.PhanAo) + (PhanThuc * sp.PhanThuc)) / ((sp.PhanAo * sp.PhanAo) + (sp.PhanThuc * sp.PhanThuc));
        kqua.PhanThuc=((PhanAo * sp.PhanAo) - (PhanThuc * sp.PhanThuc)) / ((sp.PhanAo * sp.PhanAo) + (sp.PhanThuc * sp.PhanThuc));
        return kqua;
    }
    public void Xuat()
    {
        Console.WriteLine("Ket qua = {0} + {1}i",PhanAo,PhanThuc);
    }

}
class Program
{
    static void Main(string[] args)
    {
        SoPhuc sophucA = new SoPhuc();
        sophucA.Nhap();
        SoPhuc sophucB = new SoPhuc();
        sophucB.Nhap();

        SoPhuc Cong = sophucA.Cong(sophucB);
        SoPhuc Tru = sophucA.Tru(sophucB);
        SoPhuc Nhan = sophucA.Nhan(sophucB);
        SoPhuc Chia = sophucA.Chia(sophucB);
        Cong.Xuat();
        Tru.Xuat();
        Nhan.Xuat();
        Chia.Xuat();
    }
}