using System;

class Program
{
    static void Main()
    {
        int so;

        do
        {
            Console.Write("Nhap so nguyen: ");
            so = int.Parse(Console.ReadLine());

            if (so <= 0)
            {
                Console.WriteLine("So vua nhap khong phai la so nguyen duong. Vui long nhap lai.");
            }
        } while (so <= 0);

        Console.WriteLine("So nguyen duong ban da nhap: " + so);
    }
}
