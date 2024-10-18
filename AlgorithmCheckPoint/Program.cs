using System;
using System.Collections.Generic;

public class ShellSort
{
    public static void ShellSortList(List<int> list)
    {
        int n = list.Count;
        int gap = n / 2;

        // Starts with a larger gap, then reduce the gap
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                // Saves the current element and finds the correct location in the gap-sorted subarray
                int temp = list[i];
                int j = i;

                // Shifts up earlier gap-sorted elements until the correct location for list[i] is found
                while (j >= gap && list[j - gap] > temp)
                {
                    list[j] = list[j - gap];
                    j -= gap;
                }

                // Places original list[i] in its correct location
                list[j] = temp;
            }

            // Reduces the gap for the next iteration
            gap /= 2;
        }
    }

    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 23, 12, 1, 8, 34, 54, 2, 3 };

        Console.WriteLine("Unsorted list:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Perform shell sort on the list
        ShellSortList(numbers);

        Console.WriteLine("Sorted list:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
