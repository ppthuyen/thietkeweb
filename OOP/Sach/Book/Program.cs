using System.Text;
namespace Sach;

class Program
{
    static void Main(string[] args)
    {
       Console.InputEncoding=Encoding.Unicode;
       Console.OutputEncoding=Encoding.Unicode;
       Book book1= new Book();
       book1.Name="Sách 1";
    //    book1.Authors[0]="Nguyễn Văn A";
    //    book1.Authors[1]="Trần Thị B";
        book1[0]="Nguyễn Văn A";
        book1[1]="Trần Thị B";
       //
       System.Console.WriteLine("Thông tin sách: ");
       System.Console.WriteLine(book1.Name);
    //    System.Console.WriteLine(book1.Authors[0]);
    //    System.Console.WriteLine(book1.Authors[1]);
    System.Console.WriteLine(book1[0]);
    System.Console.WriteLine(book1[1]);
     //indexer: dùng book1-đối tượng như là một mảng
     //book1[0] chứa tên tác giả thứ nhất
     //book1[1] chứa tên tác giả thứ nhất

       Book book2= new Book();
       book2.Nhap();
       book2.Xuat();
    }
}