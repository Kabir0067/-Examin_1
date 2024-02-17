using System;

class Program
{
    static void ChangePositiveElementsToZero(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                arr[i] = 0;
            }
        }
    }

    static void Main()
    {
        int[] arr = { 1, -2, 3, -4, 5, -6 };
        
        Console.WriteLine("Original Array:");
        PrintArray(arr);

        ChangePositiveElementsToZero(arr);

        Console.WriteLine("\nArray after changing positive elements to 0:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
