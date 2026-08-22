namespace MyProject;

class Exercises2
{
    static void Main(string[] args)
    {
    
    // Ex 1: Convert Celsius to Kelvin or Farenheit
    Console.Write("Enter Celsius:");
    float cels = Convert.ToSingle(Console.ReadLine());
    float kelv = cels + 273;
    float Faren = cels*18/10 + 32;
    Console.WriteLine($"kelvin: {kelv} \nFarenheit: {Faren}");
    // Ex 2: Calculate the surface and volume of sphere
    Console.Write("Enter radius:");
    float rad = Convert.ToSingle(Console.ReadLine());
    const float pi = 3.14f;
    float surf = 4f*pi*rad*rad;
    float vol = 4f/3f * pi*rad*rad*rad;
    Console.WriteLine($"surface of sphere: {surf}, \nvolume of sphere: {vol}");
    //Ex 3: Calculation
    Console.Write("Enter number 1:");
    float num1=Convert.ToSingle(Console.ReadLine());
    Console.Write("Enter number 2:");
    float num2=Convert.ToSingle(Console.ReadLine());
    Console.WriteLine($"{num1} + {num2} = {num1+num2}");
    Console.WriteLine($"{num1} - {num2} = {num1-num2}");
    Console.WriteLine($"{num1} * {num2} = {num1*num2}");
    Console.WriteLine($"{num1} mod {num2} = {num1%num2}");
    

    
    }
}

