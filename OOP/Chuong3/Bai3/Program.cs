class Organization
{
    public string Name;
    public string Country;
    public string City;
    public string Address;
    public string Telephone;

    public Organization(string TenDN, string Quocgia, string Thanhpho, string Diachi, string SDT)
    {
        Name = TenDN;
        Country = Quocgia;
        City = Thanhpho;
        Address = Diachi;
        Telephone = SDT;
    }

    ~Organization()
    {
    }

    public Organization()
    {
        Console.Write("Nhap ten Doanh nghiep: ");
        Name = Console.ReadLine();
        Console.Write("Nhap quoc gia: ");
        Country = Console.ReadLine();
        Console.Write("Nhap thanh pho: ");
        City = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        Address = Console.ReadLine();
        Console.Write("Nhap so dien thoai: ");
        Telephone = (Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine("Doanh nghiep ten: {0}, Quoc gia: {1}, Thanh pho: {2}, Dia chi: {3}, SDT: {4}", Name,Country,City,Address,Telephone);
    }

    public bool Ktra()
    {
        foreach(char kt in Telephone)
        {
            if (kt < '0' & kt > '9')
                return false;
        }
        if (Name == null || Country == null || City == null || Address == null || Telephone == null || Telephone.Length != 10)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

class Program
{
    static void Main()
    {
        Organization vd1 = new Organization("A","Viet Nam", "Da Nang","20 Nguyen Huu Tho","0123456789");
        if (vd1.Ktra())
        {
            vd1.Xuat();
        }
        else
        {
            Console.WriteLine("Nhap thong tin loi");    
        }

        Organization vd2 = new Organization();
        if (vd2.Ktra())
        {
            vd2.Xuat();
        }
        else
        {
            Console.WriteLine("Nhap thong tin loi");    
        }
    }
}

//rồi