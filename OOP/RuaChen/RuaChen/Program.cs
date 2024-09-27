using System;
namespace RuaChen
{
    class Program 
    {
            static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Nhập số người chơi n
        //Mỗi người chọn một số: nhập vào dạng 1 - Nam, 2 - lan, 3 - Tuấn
        Console.WriteLine("Lựa chọn của người chơi, vd: 1-Nam, 2-Lan,...");
        string LuaChon = Console.ReadLine();
        Console.WriteLine("Kết quả lựa chọn: \n"+LuaChon);
        //Phát sinh một số ngẫu nhiên: 1..n
        int A;
        Random rd = new Random(); //phát sinh số
        A = rd.Next(1,101);
        //In ra kết quả người phải rửa chén(số ngẫu nhiên)
        
    }
    }

}