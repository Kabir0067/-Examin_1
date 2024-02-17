using System;

class Program
{
    static int CountOccurrences(int[] arr, int B)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num == B)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int[] arr = { 1, 3, 4, 5, 3 };
        int B = 3;

        Console.WriteLine( [{string.Join(", ", arr)}]);
        Console.WriteLine(B in the array: {CountOccurrences(arr, B)});
    }
}
