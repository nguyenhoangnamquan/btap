using System.Diagnostics.Contracts;
using System.Security.Principal;
using System.Text;

namespace MyProject;


class Exercises3
{
    static void Bai_tap_1()
{
    Console.Write("Enter number 1:");
        float num1=Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter number 2:");
        float num2=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        Console.WriteLine($"{num1} - {num2} = {num1-num2}");
        Console.WriteLine($"{num1} * {num2} = {num1*num2}");
        Console.WriteLine($"{num1} mod {num2} = {num1%num2}");
}
    static void Bai_tap_2()
    {
        int y;
        while (true)
        {
            Console.Write("Enter value y:");
            if (int.TryParse(Console.ReadLine(), out y) && -5<=y && y <= 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Not valid");
            }

        }
        int x = y*y+2*y+1;
        Console.WriteLine($"Print x = {x}");
    }
    static void Bai_tap_3()
    {
        Console.Write("Enter distance (km):");
        float distance = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter hours:");
        float hours = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter minutes:");
        float minutes = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter seconds:");
        float seconds = Convert.ToSingle(Console.ReadLine());
        float total_time = hours + minutes/60f + seconds/3600f;
        float speedkm_h = distance / total_time;
        float miles = distance/1.60934f;
        float speedmiles_h = miles / total_time;
        Console.WriteLine($"Speed in km: {speedkm_h} km/h");
        Console.WriteLine($"Speed in miles {speedmiles_h} miles/h");
    }
    static void Bai_tap_4()
    {
        Console.Write("Enter radius:");
        float rad = Convert.ToSingle(Console.ReadLine());
        const float pi = 3.14f;
        float surf = 4f*pi*rad*rad;
        float vol = 4f/3f * pi*rad*rad*rad;
        Console.WriteLine($"surface of sphere: {surf}, \nvolume of sphere: {vol}");
    }
    static void Bai_tap_5()
    {
        Console.Write("Enter a character:");
        char a = (char)Console.Read();
        char b = char.ToLower(a);
        if (b == 'u' || b == 'e' || b == 'o' || b == 'a' || b == 'i')
        {
            Console.WriteLine($"{a} is vowel.");
        }
        else if (char.IsDigit(a))
        {
            Console.WriteLine($"{a} is a digit");
        }
        else
        {
            Console.WriteLine($"{a} is another symbol.");
        }
    }
    static void Bai_tap_1_lms()
    {
        Console.Write("Nhập giá trị a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập giá trị b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập giá trị c:");
        double c = Convert.ToDouble(Console.ReadLine());
        if (a==0) //a=0
        {
            if (b==0) // a=0, b=0
            {
                if (c==0) //a=0, b=0, c=0
                {
                    Console.WriteLine("Vô số nghiệm");
                }
                else //a=0, b=0, c#0
                {
                    Console.WriteLine("Vô lý, không có nghiệm");
                }
            }
            else //a=0, b#0
            {
                if (c==0) //a=0, b#0, c=0
                {
                    Console.WriteLine("x=0");
                }
                else //a=0, b#0, c#0
                {
                    Console.WriteLine($"x={-c/b}");
                }
            }
        }
        else //a#0
        {
            if (b==0) //a#0, b=0
            {
                if (c==0) //a#0, b=0,c=0
                {
                    Console.WriteLine("x=0 (nghiệm kép)");
                }
            }
            else //a#0, b#0
            {
                if (c==0) //a#0, b#0, c=0
                {
                    Console.WriteLine($"Phương trình 2 nghiệm; x1 = 0 và x2 = {-b/a}");
                }
                else //a#0, b#0, c#0
                {
                    double delta = b*b-4*a*c;
                    if (delta < 0)
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                    else if (delta == 0)
                    {
                        double kep = - b/2*a;
                        Console.WriteLine($"Phương trình có nghiệm kép là: x = {kep}");
                    }
                    else if (delta > 0)
                    {
                        Console.WriteLine($"Phương trình có 2 nghiệm \nx1={(-b-Math.Sqrt(delta))/(2*a)}\nx2={(-b+Math.Sqrt(delta))/(2*a)}");
                    }
                }
            }
        }
    }
    static void Bai_tap_2_1_lms()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập 1 số nguyên bất kì:");
        int so = Convert.ToInt32(Console.ReadLine());
        if (so % 2 == 0)
        {
            Console.WriteLine("Đây là số chẵn");
        }
        else
        {
            Console.WriteLine("Đây là số lẻ");
        }
    }
    static void Bai_tap_2_2_lms()
    {
        Console.Write("Nhập số thứ nhất:");
        float so_1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Nhập số thứ 2:");
        float so_2 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Nhập số thứ 3:");
        float so_3 = Convert.ToSingle(Console.ReadLine());
        if (so_1 > so_2)
        {
            if (so_1 > so_3)
            {
                Console.WriteLine($"{so_1} là số lớn nhất");
            }
            else
            {
                Console.WriteLine($"{so_3} là số lớn nhất");
            }
        }
        else if (so_2 > so_1)
        {
            if (so_2 > so_3)
            {
                Console.WriteLine($"{so_2} là số lớn nhất");
            }
            else
            {
                Console.WriteLine($"{so_3} là số lớn nhất");
            }
        }
        else
        {
            Console.WriteLine($"{so_3} là số lớn nhất");
        }
    } 
    static void Bai_tap_2_3_lms()
    {
        Console.Write("Nhập chiều dài cạnh 1:");
        float dai_1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Nhập chiều dài cạnh 2:");
        float dai_2 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Nhập chiều dài cạnh 3:");
        float dai_3 = Convert.ToSingle(Console.ReadLine());
        if (dai_1 == dai_2 && dai_2 == dai_3)
        {
            Console.WriteLine("Đây là tam giác đều");
        }
        else if (dai_1==dai_2 || dai_1 == dai_3 || dai_2==dai_3)
        {
            Console.WriteLine("Đây là tam giác cân");
        }
        else
        {
            Console.WriteLine("Đây là tam giác thường");
        }

    }
    static void Bai_tap_2_4_lms()
    {
        Console.Write("Nhập giá trị x:");
        float x = Convert.ToSingle(Console.ReadLine());
        Console.Write("Nhập giá trị y:");
        float y = Convert.ToSingle(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("1st Quadrant");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("4th Quadrant");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("2nd Quadrant");

        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("3rd Quadrant");
        }

    }
public static void Main(string[] args)
    {

        Bai_tap_1_lms();
        Bai_tap_2_1_lms();
        Bai_tap_2_2_lms();
        Bai_tap_2_3_lms();
        Bai_tap_2_4_lms();

    }
}