using System.Globalization;
using System.Reflection.Metadata;

namespace MyProject;

class Exercises20
{
    static int cong(int a, int b)
    {
        return a + b;
    }
    static bool kiemtrachan(int n)
    {
        if (n%2==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static int kiemtramax(int a, int b, int c)
    {
            if (a>b && b>c||a>c && c>b)
        {
            return a;
        }
        else if (b>a && a>c || b>c && c>a)
        {
            return b;
        }
        else
        return c;
    }
    static long giaithua(int n)
    {
        int nhan = 1;
        for (int i = 1; i<=n; i++)
        {
            nhan=nhan*i;
        }
        return nhan;
    }
    static string daonguocchuoi(string chuoi)
    {
        char[] mang = chuoi.ToCharArray();
        Array.Reverse(mang);
        string chuoimoi = new string (mang);
        return chuoimoi;
    }
    static bool kiemtrasonguyento(int n)
    {
        if (n<2)
        {
            return false;
        }
        int so_uoc =0;
        for (int i = 1; i<=n/2; i++)
        {
            if (n%i==0)
            {
                so_uoc++;
            }
            else
            {
                so_uoc = so_uoc+0;
            }
        }
        if (so_uoc==1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void infibonacci(int n)
    {
        int so_n_tru_2 = 0;
        int so_n_tru_1 = 1;
        Console.Write($"{so_n_tru_2} {so_n_tru_1}");
        for (int i = 1; i<=n-2; i++)
        {
            int so_dang_tinh = so_n_tru_2+so_n_tru_1;
            Console.Write($" {so_dang_tinh}");
            so_n_tru_2=so_n_tru_1;
            so_n_tru_1=so_dang_tinh;

        }
    }
    static int demnguyenam(string chuoi)
    {
        char[] mang = chuoi.ToCharArray();
        int dem = 0;
        foreach (char tu in mang)
        {
            if ('a' == tu || 'u' == tu || 'e' == tu || 'o' == tu || 'i' == tu)
            {
                dem++;
            }
            else
            {
                dem=dem+0;
            }
        }
        return dem;
    }
    static double tinhluythua(double x, int y)
    {
        double tong = 1;
        if (y==0)
        {
            return 1d;
        }
        for (int i = 1; i <=y; i++)
        {
            tong = tong*x;
        }
        return tong;
    }
    static double tinhtrungbinh(int[] arr)
    {
        int sum = 0;
        foreach (int ptu in arr)
        {
            sum = sum + ptu;
        }
        return (double)sum/arr.Length;
    }
    static bool kiemtradoixung(string chuoi)
    {
        char[] mang = chuoi.ToCharArray();
        Array.Reverse(mang);
        string chuoimoi = new string (mang);
        if (chuoimoi==chuoi)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static double celsiustofarenheit(double c)
    {
        double f = 1.8*c + 32;
        return f;
    }
    static int timmin(int[] arr)
    {
        int so_nho_nhat = arr[0];
        for (int i = 1; i<=arr.Length; i++)
        {
            if (arr[i] < so_nho_nhat)
            {
                so_nho_nhat=arr[i];
            }
        }
        return so_nho_nhat;
    }
    static int chuyenthanhmangroiconglaicacsovoinhau(int so)
    {
        int temp = so;
        int count = 0;
        if (so ==0)
        {
            count = 1;
        }
        else
        {
            while (temp > 0)
            {
            count++;
            temp = temp/10;  
            }
        }
        temp = so;
        int[] mang = new int[count];
        int sum = 0;
        for (int i = count - 1; i>=0; i--)
        {
            mang[i] = temp%10;
            temp = temp / 10;
        }
        foreach (int ptu in mang)
        {
            sum = sum+ptu;
        }
        return sum;
    }
    static void sapxepmangtangdan(int[] arr)
    {
        int temp=0;
        int dem = 0;
        while (dem<arr.Length-1)
        {
            for (int i = 0; i<arr.Length-1; i++)
        {
           
            if (arr[i+1] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
            }
            else
            {
                dem++;
            }
        }
        }
        }
    static string xoatrunglap (string chuoi)
    {
        string ketqua = "";
        for (int i = 0; i< chuoi.Length; i++)
        {
            char kytu = chuoi[i];
            if (ketqua.IndexOf(kytu) == -1)
            {
                ketqua = ketqua + kytu;
            }
        }
        return ketqua;
    }
    static int ucln(int a, int b)
    {
        
        int so_chia = b%a;
        int so_bi_chia = a;
        int temp;
        while (so_bi_chia%so_chia!=0)
        {
            {
                temp = so_chia;
                so_chia = so_bi_chia%so_chia;
                so_bi_chia = temp;
            }
            
        }
        return so_chia;
    }
     static string decimaltobinary(int n)
    {

        int dem = 0;
        int temp = n;
        while (n/2 !=0)
        {
            n=n/2;
            dem++;
        }
        dem = dem+1;
        n = temp;
        int[] mang = new int[dem];
        mang[0] = 1;
        int so_du;
        for (int i = dem-1; i>=1; i--)
        {
            so_du = n%2;
            mang[i] = so_du;
            n=n/2;
        }
        string ketqua = string.Join("", mang);
        return ketqua;
    }
    static bool kiemtranamnhuan(int year)
    {
        if (year%100==0 && year%400 ==0)
        {
            return true;
        }
        else if (year%100 ==0 && !(year%400==0))
        {
            return false;
        }
        else if (year%4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
     static int demsotu(string sentence)
    {
        string chuoimoi = sentence.Trim();
        int dem = 0;
        foreach (char ptu in chuoimoi)
        {
            if (ptu == ' ')
            {
                dem++;
            }
        }
        return dem+1;
    } 

    public static void Main(string[] args)
    {
        
    }

}