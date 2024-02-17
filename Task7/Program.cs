 using System;

class Program
{
    static int SumOfDigits(int n)
    {
        int sum = 0;
        
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }

    static void Main()
    {
        int number = 1234;
        int sum = SumOfDigits(number);
        
        Console.WriteLine($"The sum of the digits of the number  { number } is: {sum}");
    }
}
