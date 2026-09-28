namespace MyProject;

class Exercises5
{
    static int[] mang = {2, 3, 5, 7};
    static double tinhtrungbinh()
    {
        double sum = 0;
        foreach (int so in mang)
        {
            sum = sum + so;
        }
        return sum/mang.Length;
    }
    static bool chuagiatri(int giatri)
    {
        foreach(int so in mang)
        {
            if (so == giatri)
            {
                return true;
            }
        
        }
        return false;
    }
    static int timchiso(int giatri)
    {
        for (int i = 0; i < mang.Length; i++)
        {
            if (mang[i] == giatri)
            {
                return i;
            }
        }
        return -1;
    }
    static int[] xoaphantu(int giatri)
    {
        int dem = 0;
        foreach(int so in mang)
        {
            if (so != giatri)
            {
                dem++;
            }
        }
        int[] mangketqua = new int[dem];
        int chiso = 0;
        foreach (int so in mang)
        {
            if (so!=giatri)
            {
                mangketqua[chiso] = so;
                chiso++;
            }
        }
        return mangketqua;
    }
    static int[] timmaxvamin(int max, int min)
    {
        max = mang[0];
        min = mang[0];
        int[] mangketqua = new int[2];
        foreach (int so in mang)
        {
            if (so > max)
            {
                max = so;
            }
            if (so<min)
            {
                min = so;
            }
        }
        mangketqua[0] = max;
        mangketqua[1] = min;
        return mangketqua;
    }
    static int[] daonguocmang()
    {
        int[] mangketqua = new int[mang.Length];
        for (int i = 0; i<mang.Length; i++)
        {
            mangketqua[i] = mang[mang.Length - 1 - i];
        }
        return mangketqua;
    }
    static void timtrunglap()
    {
        for (int i = 0; i < mang.Length; i++)
        {
            for (int j = i+1; j<mang.Length; j++)
            {
                if (mang[i] == mang[j])
                {
                    Console.WriteLine($"{mang[i]}");
                    break;
                }
            }
        }
    }
    static int[] xoatrunglap()
    {
        int[] temp = new int [mang.Length];
        int demduynhat = 0;
        for (int i = 0; i<mang.Length; i++)
        {
            bool datontai = false;
            for (int j = 0; j<demduynhat; j++)
            {
                if (mang[i] == temp[i])
                {
                    datontai = true;
                    
                    break;
                }
                
            }
            if (datontai == false)
            {
                temp[demduynhat] = mang[i];
                demduynhat++;
            }
        }
        int[] mangketqua = new int [demduynhat];
        for (int i = 0; i<demduynhat; i++)
        {
            mangketqua[i] = temp[i];
        }
        return mangketqua;
    }
    static int [] bubble()
    {
        int[] mangketqua = mang.ToArray();
        for (int i = 0; i<mangketqua.Length -1; i++)
         {
            for (int j = 0; j < mangketqua.Length-1-i; j++)
            {
                if (mangketqua[j] > mangketqua[j+1])
                {
                    int temp = mangketqua[j];
                    mangketqua[j] = mangketqua[j+1];
                    mangketqua[j+1] = temp;
                }
            }
        }
        return mangketqua;
    }
    static bool linearsearch (string chuoi, string tu)
    {
        string[] mangtu = chuoi.Split(' ');
        for (int i = 0; i<mangtu.Length; i++)
        {
            if (mangtu[i] == tu)
            {
                return true;
            }
        }
        return false;
    }
    static int[,] taomatranngaunhien(int n, int m)
    {
        int[,] matran = new int [n, m];
        Random rnd = new Random();
        for (int dong = 0; dong<n; dong++)
        {
            for (int cot = 0; cot<m; cot++)
            {
                matran[dong, cot] = rnd.Next(1, 100);
            }
        }
        return matran;
    }
    static void inmatran(int[,] matran)
    {
        int nhieu_dong = matran.GetLength(0);
        int nhieu_cot = matran.GetLength(1);
        for (int dong = 0; dong<nhieu_dong; dong++)
        {
            for (int cot = 0; cot < nhieu_cot; cot++)
            {
                Console.Write(matran[dong, cot] + "\t");
            }
            Console.WriteLine();
        }
    }
    static void indongcotthui(int[,] matran, int i)
    {
       int nhieu_dong = matran.GetLength(0);
            int nhieu_cot = matran.GetLength(1);

           
            if (i >= 0 && i < nhieu_dong)
            {
                Console.Write($"\nDong thu {i}: ");
                for (int cot = 0; cot < nhieu_cot; cot++)
                {
                    Console.Write(matran[i, cot] + " ");
                }
            }

            if (i >= 0 && i < nhieu_cot)
            {
                Console.Write($"\nCot thu {i}: ");
                for (int dong = 0; dong < nhieu_dong; dong++)
                {
                    Console.Write(matran[dong, i] + " ");
                }
                Console.WriteLine();
            }
    }
    static int timgiatrilonnhat(int[,] matran)
    {
        int max = matran[0, 0]; 
            int nhieu_dong = matran.GetLength(0);
            int nhieu_cot = matran.GetLength(1);

            for (int dong = 0; dong < nhieu_dong; dong++)
            {
                for (int cot = 0; cot < nhieu_cot; cot++)
                {
                    if (matran[dong, cot] > max)
                    {
                        max = matran[dong, cot];
                    }
                }
            }
            return max;
    }
    static void timnhonhatdongcot(int[,] matran, int i)
    {
        int nhieu_dong = matran.GetLength(0);
            int nhieu_cot = matran.GetLength(1);

            if (i >= 0 && i < nhieu_dong)
            {
                int min_dong = matran[i, 0];
                for (int cot = 1; cot < nhieu_cot; cot++)
                {
                    if (matran[i, cot] < min_dong)
                    {
                        min_dong = matran[i, cot];
                    }
                }
                Console.WriteLine($"\nGia tri nho nhat tren dong {i} la: {min_dong}");
            }

            if (i >= 0 && i < nhieu_cot)
            {
                int min_cot = matran[0, i];
                for (int dong = 1; dong < nhieu_dong; dong++)
                {
                    if (matran[dong, i] < min_cot)
                    {
                        min_cot = matran[dong, i];
                    }
                }
                Console.WriteLine($"Gia tri nho nhat tren cot {i} la: {min_cot}");
            }
    }
    static int[,] chuyenvimatran(int[,] matran)
    {
        int nhieu_dong = matran.GetLength(0);
            int nhieu_cot = matran.GetLength(1);
            
            int[,] matran_chuyenvi = new int[nhieu_cot, nhieu_dong]; 

            for (int dong = 0; dong < nhieu_dong; dong++)
            {
                for (int cot = 0; cot < nhieu_cot; cot++)
                {
                    matran_chuyenvi[cot, dong] = matran[dong, cot];
                }
            }
            return matran_chuyenvi;
    }
    static void induongcheo(int[,] matran)
    {
        int nhieu_dong = matran.GetLength(0);
            int nhieu_cot = matran.GetLength(1);

            if (nhieu_dong == nhieu_cot)
            {
                Console.WriteLine("\nCac duong cheo cua ma tran vuong");
                
                Console.Write("Duong cheo chinh: ");
                for (int k = 0; k < nhieu_dong; k++)
                {
                    Console.Write(matran[k, k] + " ");
                }

                Console.Write("\nDuong cheo phu: ");
                for (int k = 0; k < nhieu_dong; k++)
                {
                    Console.Write(matran[k, nhieu_dong - 1 - k] + " ");
                }
                Console.WriteLine();
            }
        }

    
public static void Main(string[] args)
    {
        Console.Write("Nhap so dong N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot M: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matran = taomatranngaunhien(n, m);
            Console.WriteLine("Ma tran vua tao:");
            inmatran(matran);
    }
}