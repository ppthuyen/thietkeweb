using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap ho ten: ");
        string hoTen = Console.ReadLine();
        Console.Write("Nhap diem thi: ");
        double diemThi = double.Parse(Console.ReadLine());

        string hoTenInHoa = hoTen.ToUpper();

        string xepLoai;

        if (diemThi >= 8)
        {
            xepLoai = "Gioi";
        }
        else if (diemThi >= 6.5)
        {
            xepLoai = "Kha";
        }
        else if (diemThi >= 5)
        {
            xepLoai = "Trung binh";
        }
        else
        {
            xepLoai = "Yeu";
        }

        Console.WriteLine("Ho ten hoc sinh: " + hoTenInHoa);
        Console.WriteLine("Xep loai: " + xepLoai);
    }
}
