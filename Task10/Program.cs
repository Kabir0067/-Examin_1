using System;

class Program
{
    static string ChopkuniJuft(int a, int b)
    {
        string result = "";
        
        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0)
            {
                result += i + " ";
            }
        }
        
        return result;
    }

    static string ChopkuniToq(int a, int b)
    {
        string result = "";
        
        for (int i = a; i <= b; i++)
        {
            if (i % 2 != 0)
            {
                result += i + " ";
            }
        }
        
        return result;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        System.Console.Write(ChopkuniJuft(a, b));
        System.Console.WriteLine();
        System.Console.Write(ChopkuniToq(a, b));
    }
}
