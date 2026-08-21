namespace MyProject;

class Exercises1
{
    static void Main1(string[] args)
    {
    // 1. to Add / Sum Two Numbers.
    int number1 = 10, number2=12;
    int sum = number1+number2;
    Console.WriteLine($"{number1}+{number2}={sum}");
    // 2. to Swap Values of Two Variables.
    Console.WriteLine($"Before swapping values: number1={number1}, number2={number2}");
    int c = number1;
    number1 = number2;
    number2 = c;
    Console.WriteLine($"After swapping values: number1={number1}, number2={number2}");
    // 3. to Multiply two Floating Point Numbers
    float f1=3.5f, f2=2.7f;
    float f3=f1*f2;
    Console.WriteLine($"{f1}*{f2} = {f3}");
    // 4. to convert feet to meter
    float feet = 5.7f;
    const float rate = 0.3048f;
    float meter = rate * feet;
    Console.WriteLine($"{feet} feet = {meter} meter.");
    // 5. to convert Celsius to Fahrenheit and vice versa
    float cels = 27f;
    float fah = cels * 1.8f + 32;
    Console.WriteLine($"{cels} cels = {fah} fah");
    // 6. to find the Size of data types
    Console.WriteLine($"Size of double data type is {sizeof(double)}");
    Console.WriteLine($"Size of int data type is {sizeof(int)}");
    // 7. to Print ASCII Value (tip: read character, print number of this char)
    Console.Write("Enter a char:");
    int chu_cai=Console.Read();
    Console.ReadLine();
    Console.WriteLine($"ASCII code of {(char)chu_cai} is {chu_cai}");
    // 8. to Calculate Area of Circle
    Console.Write("Enter radius:");
    float r = Convert.ToSingle(Console.ReadLine());
    const float pi = 3.14f;
    float ar = pi * r * r;
    Console.WriteLine($"Area of a circle is {ar}");
    // 9. to Calculate Area of Square
    Console.Write("Enter side of the square:");
    float sid= Convert.ToSingle(Console.ReadLine());
    float are = sid * sid;
    Console.WriteLine($"Area of the square is: {are}");
    // 10. to convert days to years, weeks and days
    Console.Write("Enter number of days:");
    float day = Convert.ToSingle(Console.ReadLine());
    float years = day/365;
    float weeks = day/7;
    Console.WriteLine($"number of years: {years}, number of weeks: {weeks}");
    }
}