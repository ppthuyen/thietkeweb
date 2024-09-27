using System;

class Program
{
    // Hàm nhập phân số
    static void InputFraction(out int numerator, out int denominator)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập tử số: ");
        numerator = int.Parse(Console.ReadLine());

        Console.Write("Nhập mẫu số: ");
        denominator = int.Parse(Console.ReadLine());

        Normalize(ref numerator, ref denominator);
    }

    // Hàm cộng hai phân số
    static void AddFractions(int num1, int denom1, int num2, int denom2, out int resultNum, out int resultDenom)
    {
        resultNum = num1 * denom2 + num2 * denom1;
        resultDenom = denom1 * denom2;
        Normalize(ref resultNum, ref resultDenom);
    }

    // Hàm trừ hai phân số
    static void SubtractFractions(int num1, int denom1, int num2, int denom2, out int resultNum, out int resultDenom)
    {
        resultNum = num1 * denom2 - num2 * denom1;
        resultDenom = denom1 * denom2;
        Normalize(ref resultNum, ref resultDenom);
    }

    // Hàm nhân hai phân số
    static void MultiplyFractions(int num1, int denom1, int num2, int denom2, out int resultNum, out int resultDenom)
    {
        resultNum = num1 * num2;
        resultDenom = denom1 * denom2;
        Normalize(ref resultNum, ref resultDenom);
    }

    // Hàm chia hai phân số
    static void DivideFractions(int num1, int denom1, int num2, int denom2, out int resultNum, out int resultDenom)
    {
        resultNum = num1 * denom2;
        resultDenom = denom1 * num2;
        Normalize(ref resultNum, ref resultDenom);
    }

    // Hàm chuẩn hóa phân số
    static void Normalize(ref int numerator, ref int denominator)
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
    }

    // Hàm tính ước số chung lớn nhất (GCD)
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Hàm hiển thị phân số dạng (A/B)
    static void DisplayFraction(int numerator, int denominator)
    {
        Console.WriteLine($"({numerator}/{denominator})");
    }

    // Hàm hiển thị phân số dưới dạng số thập phân
    static void DisplayDecimal(int numerator, int denominator)
    {
        Console.WriteLine($"Dạng số thập phân: {(double)numerator / denominator}");
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Nhập hai phân số
        int num1, denom1, num2, denom2;
        Console.WriteLine("Nhập phân số thứ nhất:");
        InputFraction(out num1, out denom1);

        Console.WriteLine("Nhập phân số thứ hai:");
        InputFraction(out num2, out denom2);

        // Thực hiện các phép toán
        int resultNum, resultDenom;

        // Cộng phân số
        AddFractions(num1, denom1, num2, denom2, out resultNum, out resultDenom);
        Console.WriteLine("\nKết quả cộng:");
        DisplayFraction(resultNum, resultDenom);
        DisplayDecimal(resultNum, resultDenom);

        // Trừ phân số
        SubtractFractions(num1, denom1, num2, denom2, out resultNum, out resultDenom);
        Console.WriteLine("\nKết quả trừ:");
        DisplayFraction(resultNum, resultDenom);
        DisplayDecimal(resultNum, resultDenom);

        // Nhân phân số
        MultiplyFractions(num1, denom1, num2, denom2, out resultNum, out resultDenom);
        Console.WriteLine("\nKết quả nhân:");
        DisplayFraction(resultNum, resultDenom);
        DisplayDecimal(resultNum, resultDenom);

        // Chia phân số
        DivideFractions(num1, denom1, num2, denom2, out resultNum, out resultDenom);
        Console.WriteLine("\nKết quả chia:");
        DisplayFraction(resultNum, resultDenom);
        DisplayDecimal(resultNum, resultDenom);
    }
}
