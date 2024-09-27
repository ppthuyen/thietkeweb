namespace GameDoanSo;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; //tiếng việt
        int A;
        Random rd = new Random(); //phát sinh số
        A = rd.Next(1,101);


        Console.WriteLine("Nhập vào 1 số B: ");
        for (int i = 1; i <= 7; i++)
        {
            int B = int.Parse(Console.ReadLine());
            if (B == A)
            {
                Console.WriteLine("Bạn đã trúng thưởng.");
                break;
            }
            else if (B > A) {Console.WriteLine("Bạn đã đoán số lớn hơn");}
            else if (B < A) {Console.WriteLine("Bạn đã đoán số nhỏ hơn");}
            if (i==7) {Console.WriteLine("Bạn thua rùi");}
        }
        Console.WriteLine(A);
    }
}