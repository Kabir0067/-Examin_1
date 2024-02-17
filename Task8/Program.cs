using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int num1 =5;
        int num2 = 10;

        Console.WriteLine($"x = {num1},  y = {num1}     ");

        Swap(ref num1, ref num2);

        Console.WriteLine($"   x = {num2}, y= {num2}");
    }
}
