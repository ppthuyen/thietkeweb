using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Nhập kích thước mảng
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhập m: ");
        int m = int.Parse(Console.ReadLine());

        // a) Nhập dữ liệu cho mảng
        int[,] arr1 = new int[n, m];
        int[,] arr2 = new int[n, m];
        
        Console.WriteLine("Nhập dữ liệu cho mảng 1:");
        InputArray(arr1, n, m);
        
        Console.WriteLine("Nhập dữ liệu cho mảng 2:");
        InputArray(arr2, n, m);

        // b) Xuất giá trị các phần tử của mảng
        Console.WriteLine("Mảng 1:");
        PrintArray(arr1, n, m);
        
        Console.WriteLine("Mảng 2:");
        PrintArray(arr2, n, m);

        // c) Cộng hai mảng
        int[,] sumArray = AddArrays(arr1, arr2, n, m);

        Console.WriteLine("Tổng hai mảng:");
        PrintArray(sumArray, n, m);
    }

    // Hàm nhập dữ liệu cho mảng
    static void InputArray(int[,] arr, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Nhập phần tử tại vị trí [{i},{j}]: ");
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Hàm xuất dữ liệu của mảng
    static void PrintArray(int[,] arr, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Hàm cộng hai mảng
    static int[,] AddArrays(int[,] arr1, int[,] arr2, int n, int m)
    {
        int[,] result = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        return result;
    }
}