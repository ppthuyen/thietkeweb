using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sach
{
    public class Book
    {
        public string Name{ get; set; }
        //danh sách tên tác giả
        public static int SIZE=10;
        int numOfAuthors=1;
        string [] authors=new string[SIZE]; //field
        public string [] Authors{ get{return authors;} set{authors=value;} }  //property
        //khai báo indexer gần giống property
        public string this [int index]{
            get{
                string temp="";
                if(index>=0&&index<SIZE) //index hợp lệ
                {
                    temp=authors[index];
                }  
                return temp; }
            set{
                if(index>=0&&index<SIZE)
                    authors[index] = value;}  
        }
        //construtor
        public Book(string name,string[] authors){
            this.Name = name;
            this.Authors = authors;
        }
        public Book()
        {
           
        }
        //phương thức nhập Book
        public void Nhap(){
            System.Console.Write("Nhập tên của sách: ");
            Name=Console.ReadLine();
            System.Console.Write("Nhập số lượng tác giả: ");
            numOfAuthors=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<numOfAuthors;i++){
                System.Console.Write($"Nhập tác giả thứ {i+1}:");
                authors[i]=Console.ReadLine();
            }
        }
        public void Xuat(){
            System.Console.WriteLine("Thông tin của cuốn sách: ");
            System.Console.WriteLine("Tên sách: "+Name);
            System.Console.WriteLine("Danh sách tác giả: ");
            for(int i=0;i<numOfAuthors;i++){          
                System.Console.WriteLine($"{i+1}: {authors[i]}");
            }
        }
    }
}