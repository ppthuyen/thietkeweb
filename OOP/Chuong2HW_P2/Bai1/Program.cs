namespace Dice;
class dice
{
    public int MatXucXac;
    public int A; // random mat xuc xac
    public void Nhap()
    {
        Console.WriteLine("Moi ban nhap mat xuc xac");
        MatXucXac = int.Parse(Console.ReadLine());
    }
    public void random()
    {
        Random rd = new Random();
        A = rd.Next(1, MatXucXac +1);
    }
    public void xuat()
    {
        Console.WriteLine("Mat xuc xac la: " + A);
    }
}
class Program
{
    static void Main(string[] args)
    {
        dice Nguoi1 = new dice();
        Nguoi1.Nhap();
        Nguoi1.random();
        Nguoi1.xuat();
    }
}