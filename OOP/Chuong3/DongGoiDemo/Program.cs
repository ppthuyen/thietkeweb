namespace DongGoiDemo;
class Program
{
    static void Main(string[] args)
    {
        Nguoi nguoi1=new Nguoi();
        nguoi1.Ten = "Loi"; //set
        nguoi1.NamSinh=2004;
        System.Console.WriteLine(nguoi1.Ten); //get
        //nguoi1.In();

    }
}
