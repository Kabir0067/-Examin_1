using System;

class Program
{
    static void Fibonacci(int n)
    {
        int first = 0;
        int second = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");

            int temp = first;
            first = second;
            second = temp + second;
        }
    }

    static void Main()
    {
        int n =5; 
        Console.WriteLine(n);
        Fibonacci(n);
    }
}
