using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;

namespace MyProject;
class Exercises7
{
    static void bai_1()
    {
        string tenfile = "blank.txt";
        File.Create(tenfile).Close();

    }
    static void bai_2()
    {
        string tenfile = "blank.txt";
        if (File.Exists(tenfile))
        {
            File.Delete(tenfile);
        }
        else
        {
            Console.WriteLine("File ko co");
        }
    }
    static void bai_3()
    {
        string tenfile = "noi_dung.txt";
        string noidung = "abcxyz";
        File.WriteAllText(tenfile, noidung);
    }
    static void bai_4()
    {
        string tenfile = "file_doc.txt";
        string noidung = "abcd";
        File.WriteAllText(tenfile, noidung);
        File.ReadAllText(tenfile);

    }
    static void bai_5()
    {
        string tenfile = "file_mang.txt";
        string[] mang = ["ab", "bc", "cd"];
        File.WriteAllLines(tenfile, mang);
    }
    static void bai_6()
    {
        string tenfile = "noi_dung.txt";
        File.AppendAllText(tenfile, "abcd");

    }
    static void bai_7()
    {
        string tenfile1 = "file_goc.txt";
        string tenfile2 = "file_copy.txt";
        File.WriteAllText(tenfile1, "abcd");
        File.Copy(tenfile1, tenfile2);
    }
    static void bai_8()
    {
        string tenfile1 = "file_cu.txt";
        string tenfile2 = "file_moi.txt";
        File.WriteAllText(tenfile1, "abcdxyz");
        File.Move(tenfile1, tenfile2);
    }
    static void bai_9()
    {
        string tenfile = "line.txt";
        string[] mang = ["abc", "xyz"];
        File.WriteAllLines(tenfile, mang);
        using (StreamReader sr = new StreamReader(tenfile))
        {
            string firstline = sr.ReadLine();
            Console.WriteLine(firstline);
        }

    }
    static void bai_10()
    {
        string tenfile = "dong_cuoi.txt";
        string[] mang = ["ab", "bc"];
        File.WriteAllLines(tenfile, mang);
        string[] doc_mang = File.ReadAllLines(tenfile);
        Console.WriteLine(doc_mang[doc_mang.Length-1]);
    }
    static void bai_11()
    {
        string tenfile = "ndong_cuoi.txt";
        string[] mang = ["ab", "bc", "xy", "yz", "zc"];
        File.WriteAllLines(tenfile, mang);
        string[] doc_mang = File.ReadAllLines(tenfile);
        Console.Write("Nhap n dong cuoi:");
        int n = int.Parse(Console.ReadLine());
        if (n>doc_mang.Length)
        {
            n = doc_mang.Length;
        }
        for (int i = doc_mang.Length - n; i <= doc_mang.Length-1; i++)
        {
            Console.WriteLine(doc_mang[i]);
        }
    }
    static void bai_12()
    {
        string tenfile = "docdongcuthe.txt";
        string[] mang = ["ab", "bc", "xy", "yz", "zc"];
        File.WriteAllLines(tenfile, mang);
         string[] doc_mang = File.ReadAllLines(tenfile);
         Console.Write("Nhap so dong can doc");
         int n = int.Parse(Console.ReadLine());
         Console.WriteLine(doc_mang[n-1]);
    }
    static void bai_13()
    {
        string tenfile = "docdongcuthe.txt";
        string[] mang = ["ab", "bc", "xy", "yz", "zc"];
        File.WriteAllLines(tenfile, mang);
        string[] doc_mang = File.ReadAllLines(tenfile);
        Console.WriteLine($"So dong trong file:{doc_mang.Length}");
    }
  static void bai_14()
{
    //tao duong dan
    string tenfile = "MyFolder";

    Directory.CreateDirectory(tenfile);
    Directory.CreateDirectory(tenfile + "/SubFolder");
    Directory.CreateDirectory(tenfile + "/SubFolder/SubFolder2");

    File.WriteAllText(tenfile + "/a.txt", "File A");
    File.WriteAllText(tenfile + "/b.txt", "File B");
    File.WriteAllText(tenfile + "/SubFolder/c.txt", "File C");
    File.WriteAllText(tenfile + "/SubFolder/SubFolder2/d.txt", "File D");

    in_cau_truc(tenfile, 0);
}
//in ra cay thu muc
static void in_cau_truc(string path, int cap)
{
    string[] files = Directory.GetFiles(path);

    foreach (string file in files)
    {
        Console.WriteLine(new string(' ', cap * 4)
            + "|-- " + Path.GetFileName(file));
    }

    string[] folders = Directory.GetDirectories(path);

    foreach (string folder in folders)
    {
        Console.WriteLine(new string(' ', cap * 4)
            + "|-- " + Path.GetFileName(folder));

        in_cau_truc(folder, cap + 1);
    }
}
static void bai_15()
{
    string path = "statistic.txt";
    string[] mang = [ "a1a2B1","Hello 123","aA22"];

   File.WriteAllLines(path, mang);

    string[] lines = File.ReadAllLines(path);

    int max = 0;

    for (int i = 0; i < lines.Length; i++)
    {
        if (lines[i].Length > max)
            max = lines[i].Length;
    }

    char[,] a = new char[lines.Length, max];

    for (int i = 0; i < lines.Length; i++)
    {
        for (int j = 0; j < lines[i].Length; j++)
        {
            a[i, j] = lines[i][j];
        }
    }

    for (int i = 0; i < lines.Length; i++)
    {
        for (int j = 0; j < lines[i].Length; j++)
        {
            char c = a[i, j];

            if (char.IsLetterOrDigit(c))
            {
                bool da_dem = false;

                for (int x = 0; x < i; x++)
                {
                    for (int y = 0; y < lines[x].Length; y++)
                    {
                        if (a[x, y] == c)
                            da_dem = true;
                    }
                }

                for (int y = 0; y < j; y++)
                {
                    if (a[i, y] == c)
                        da_dem = true;
                }

                if (!da_dem)
                {
                    int dem = 0;

                    for (int x = 0; x < lines.Length; x++)
                    {
                        for (int y = 0; y < lines[x].Length; y++)
                        {
                            if (a[x, y] == c)
                                dem++;
                        }
                    }

                    Console.WriteLine(c + ": " + dem);
                }
            }
        }
    }
}
    public static void Main123(string[] args)
    {
        
    }
}