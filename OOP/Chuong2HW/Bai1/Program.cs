using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // a) Nhập dữ liệu cho mảng
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // b) Xuất giá trị các phần tử của mảng
        Console.WriteLine("Các phần tử trong mảng:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // c) Tìm phần tử có giá trị lớn nhất, nhỏ nhất
        int max = arr.Max();
        int min = arr.Min();
        Console.WriteLine($"Phần tử lớn nhất: {max}");
        Console.WriteLine($"Phần tử nhỏ nhất: {min}");

        // d) Đếm số phần tử là số chẵn
        int evenCount = arr.Count(x => x % 2 == 0);
        Console.WriteLine($"Số phần tử là số chẵn: {evenCount}");

        // e) Tìm số nguyên tố trong mảng
        Console.WriteLine("Các số nguyên tố trong mảng:");
        foreach (int item in arr)
        {
            if (IsPrime(item))
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();

        // f) Sắp xếp mảng tăng dần
        Array.Sort(arr);
        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
