using System;
namespace C3Vd9
{
    class IndexedNames
    {
        //khai báo một mảng chuỗi
        private string[] namelist = new string[size];
        static public int size = 10;
        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "None";
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Nguyen Van An";
            names[1] = "Tran Van Bao";
            names[2] = "Le Van Chinh";
            names[3] = "Ngo Van Danh";
            names[4] = "Nguyen Thi Hoa";
            names[5] = "Ho Truc Linh";
            names[6] = "Pham Ha Trang";
            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}