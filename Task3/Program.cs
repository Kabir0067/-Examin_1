using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 5, 20, 15, 30, 25, 40 };

        int minIndex = 0;
        int maxIndex = 0;


        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }


        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }


        int startIndex = Math.Min(minIndex, maxIndex);
        int endIndex = Math.Max(minIndex, maxIndex);


        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
