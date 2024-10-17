using System;

class People
{
    int old;
    string name;
    double height;

    public People(string name, int old, double height)
    {
        Console.WriteLine("\n--- Goi ham xay dung ---");
        this.name = name;
        this.old = old;
        this.height = height;
    }

    public void Show()
    {
        Console.WriteLine("Name: " + name + "\nOld: " + old + "\nHeight: " + height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        People p1 = new People("Nguyen Van A", 20, 180);
        p1.Show();
        
        Console.ReadKey();
    }
}
