using System.Globalization;
using System.Reflection.Metadata;

namespace MyProject;
class Exercises6
{
    static void bai_1()
    {
        
        Console.Write("Nhap chuoi");
        string chuoi = Console.ReadLine();
        Console.WriteLine(chuoi);
    }
    static void bai_2()
    {
        int dem = 0;
        Console.Write("Nhap chuoi:");
        string chuoi = Console.ReadLine();
        foreach(char chu in chuoi)
        {
            dem++;
        }
        Console.WriteLine($"chuoi co do dai la: {dem}");
    }
    static void bai_3()
    {
        Console.Write("Nhap chuoi:");
        string chuoi = Console.ReadLine();
        for (int i = 0; i< chuoi.Length; i++)
        {
            Console.WriteLine(chuoi[i]);
        }
    }
    static void bai_4()
    {
        Console.WriteLine("Nhap chuoi:");
        string chuoi = Console.ReadLine();
        for (int i = chuoi.Length - 1; i>=0; i--)
        {
            Console.Write(chuoi[i]);
        }
    }
    static void bai_5()
    {
        bool batdaudem = false;
        int dem = 0;
        Console.Write("Nhap chuoi:");
        string chuoi = Console.ReadLine();
        foreach (char chu in chuoi)
        {
            if (chu != ' ')
            {
                batdaudem=true;//nhan biet khoang trang dau chuoi, gap chu thi bat dau dem
            }
            if (chu == ' ' && batdaudem == true)
            {
                dem++;
                batdaudem = false;
            }
        }

        //xet khoang trang cuoi chuoi
        if (batdaudem == false)
        {
            dem = dem+0;
        }
        else
        {
            dem = dem+1;
        }
        Console.WriteLine($"So tu la: {dem}");
    }
    static void bai_6()
    {
        Console.Write("Nhap chuoi 1:");
        string chuoi_1 = Console.ReadLine();
        Console.Write("Nhap chuoi 2:");
        string chuoi_2 = Console.ReadLine();
        if (chuoi_1 == chuoi_2)
        {
            Console.WriteLine("Hai chuoi giong nhau");
        }
        else
        {
            Console.WriteLine("Hai chuoi khac nhau");
        }
    }
     static void bai_7()
    {
        int alpha = 0;
        int digit = 0;
        int special = 0;
        Console.Write("Nhap chuoi:");
        string chuoi = Console.ReadLine();
        foreach (char chu in chuoi)
        {
            if (chu >= 'A' && chu <= 'Z' || chu >= 'a' && chu <= 'z')
            {
                alpha++;
            }
            else if (chu >= '0' && chu <='9')
            {
                digit++;
            }
            else
            {
                special++;
            }
        }
        Console.WriteLine($"So chu cai: {alpha}");
        Console.WriteLine($"So chu so: {digit}");
        Console.WriteLine($"So ki tu dac biet: {special}");
    }
    static void bai_8()
    {
        int nguyenam = 0;
        int phuam = 0;
        Console.Write("Nhap chuoi");
        string chuoi = Console.ReadLine();
        chuoi = chuoi.ToLower();
        foreach (char chu in chuoi)
        {
            if (chu == 'u' || chu == 'e' || chu == 'o' || chu == 'a' || chu == 'i')
            {
                nguyenam++;
            }
            else
            {
                phuam++;
            }
        }
        Console.WriteLine($"so nguyen am: {nguyenam}");
        Console.WriteLine($"so phu am: {phuam}");
    }
    static void bai_9()
    {
        bool kq = true;
        int soluongchu = 0;
        Console.Write("Nhap chuoi chinh:");
        string chuoi_chinh = Console.ReadLine();
        Console.Write("Nhap chuoi phu");
        string chuoi_phu = Console.ReadLine();
        if (chuoi_phu.Length > chuoi_chinh.Length)
        {
            kq = false;
        }
        else
        {
            for (int i = 0; i <= chuoi_phu.Length - 1; i++)
            {
                foreach (char chu in chuoi_chinh)
                {
                    if (chuoi_phu[i] == chu)
                    {
                        soluongchu++;
                    }
                }
            }
        }
        if (soluongchu == chuoi_phu.Length)
        {
            kq = true;
        }
        else
        {
            kq = false;
        }
        Console.WriteLine($"{kq}");
    }
    static void bai_10()
    {
        int vitridautien = 0;
        bool kq = true;
        int soluongchu = 0;
        Console.Write("Nhap chuoi chinh:");
        string chuoi_chinh = Console.ReadLine();
        Console.Write("Nhap chuoi phu");
        string chuoi_phu = Console.ReadLine();
        if (chuoi_phu.Length > chuoi_chinh.Length)
        {
            kq = false;
        }
        else
        {
            for (int i = 0; i <= chuoi_chinh.Length - 1; i++)
            {
                foreach (char chu in chuoi_phu)
                {
                    if (chuoi_chinh[i] == chu)
                    {
                        vitridautien = i;
                        kq = false;
                        break;
                    }
                }
            if (kq == false)
                {
                    break;
                }
            }
            for (int j = 0; j <= chuoi_chinh.Length - 1; j++)
            {
                foreach (char kitu in chuoi_phu)
                {
                    if (chuoi_chinh[j] == kitu)
                    {
                        soluongchu++;
                        break;
                    }
                }
            }
        }
        if (soluongchu == chuoi_phu.Length)
        {
            kq = true;
        }
        else
        {
            kq = false;
        }
        if (kq == true)
        {
            Console.WriteLine($"Vi tri xuat hien chuoi con: {vitridautien}");
        }
        else
        {
            Console.Write("Ko co chuoi con");
        }
    }
    static void bai_11()
    {
    Console.Write("Nhap mot ky tu: ");
    char kitu = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (kitu >= 'A' && kitu <= 'Z')
    {
        Console.WriteLine("La chu hoa");
    }
    else if (kitu >= 'a' && kitu <= 'z')
    {
        Console.WriteLine("La chu thuong");
    }
    else
    {
        Console.WriteLine("Khong phai chu cai");
    }
}
    static void bai_12()
    {
    int soluonglan = 0;
    bool kq = true;

    Console.Write("Nhap chuoi chinh: ");
    string chuoi_chinh = Console.ReadLine();

    Console.Write("Nhap chuoi phu: ");
    string chuoi_phu = Console.ReadLine();

    if (chuoi_phu.Length > chuoi_chinh.Length || chuoi_phu.Length == 0)
    {
        kq = false;
    }
    else
    {
        for (int i = 0; i <= chuoi_chinh.Length - chuoi_phu.Length; i++)
        {
            kq = true;

            for (int j = 0; j < chuoi_phu.Length; j++)
            {
                if (chuoi_chinh[i + j] != chuoi_phu[j])
                {
                    kq = false;
                    break;
                }
            }

            if (kq == true)
            {
                soluonglan++;
            }
        }
    }

    Console.WriteLine($"So lan xuat hien chuoi con: {soluonglan}");
    }
    static void bai_13()
{
    int vitridautien = -1;
    bool kq;

    Console.Write("Nhap chuoi chinh: ");
    string chuoi_chinh = Console.ReadLine();

    Console.Write("Nhap chuoi phu: ");
    string chuoi_phu = Console.ReadLine();

    Console.Write("Nhap chuoi can chen: ");
    string chuoi_chen = Console.ReadLine();

    for (int i = 0; i <= chuoi_chinh.Length - chuoi_phu.Length; i++)
    {
        kq = true;

        for (int j = 0; j < chuoi_phu.Length; j++)
        {
            if (chuoi_chinh[i + j] != chuoi_phu[j])
            {
                kq = false;
                break;
            }
        }

        if (kq == true)
        {
            vitridautien = i;
            break;
        }
    }

    if (vitridautien != -1)
    {
        chuoi_chinh = chuoi_chinh.Insert(vitridautien, chuoi_chen);
        Console.WriteLine(chuoi_chinh);
    }
    else
    {
        Console.WriteLine("Ko co chuoi con");
    }
}

    public static void Main232(string[] args)
    {
        
    }
}