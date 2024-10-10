namespace DongGoiDemo
{
    public class Nguoi
    {
        private String ten;
            int namSinh=2005;
        public String Ten{get { return ten; } set { ten = value;}}
        public int NamSinh{get { return namSinh; } 
                set { 
                    if (value >= 1900)
                        namSinh = value;
                    else System.Console.WriteLine("Nam sinh sai");} }
        public void In()
        {
            System.Console.WriteLine($"Nguoi có ten={ten}, nam sinh={namSinh}");
        }

    }
}