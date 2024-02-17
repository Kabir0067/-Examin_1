using System;

class Program
{
    static int CountDifferentElements(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }

        int count = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i - 1])
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 3, 3, 4, 5, 5, 6, 6, 6 };
        
        int differentElementsCount = CountDifferentElements(arr);
        
        Console.WriteLine("The number of different elements in the array is: " + differentElementsCount);
    }
}
