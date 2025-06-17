using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size;
        
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
        }

        int[] arr = new int[size];

        Console.WriteLine($"Enter {size} elements:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.Write($"Invalid input. Please enter a valid integer for Element {i + 1}: ");
            }
        }

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(" ", arr));

        BubbleSort(arr);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", arr));
    }
}