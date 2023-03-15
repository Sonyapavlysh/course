using System;

class Program
{
    static void Main(string[] args)
    {
        Program.Task15();
        Program.Task16();
        Program.Task17();
    }

    static void Task15()
    {
        Console.WriteLine("Task 15");

        Random random = new Random();
        int randomLength = random.Next(1, 10);
        int result = 0;

        int[] array = new int[randomLength];

        for (int i = 0; i < randomLength; i++)
        {
            array[i] = random.Next(100, 999);
        }

        for (int i = 0; i < randomLength; i++)
        {
            Console.Write(array[i] + " ");
            if (array[i] % 2 == 0)
            {
                result += 1;
            }
        }
        Console.WriteLine();
        Console.Write(result);
    }

    static void Task16()
    {
        Console.WriteLine("Task 16");

        Random random = new Random();
        int randomLength = random.Next(4, 10);
        int result = 0;

        int[] array = new int[randomLength];

        for (int i = 0; i < randomLength; i++)
        {
            array[i] = random.Next(-99, 99);
        }

        for (int i = 0; i < randomLength; i++)
        {
            Console.Write(array[i] + " ");
            if (i % 2 == 1)
            {
                result += array[i];
            }
        }
        Console.WriteLine("result: " + result);
    }

    static void Task17()
    {
        Console.WriteLine("Task 17");
        Random random = new Random();
        int randomLength = random.Next(4, 10);
        int[] array = new int[randomLength];
        int max = 0;
        int min = 0;

        for (int i = 0; i < randomLength; i++)
        {
            array[i] = random.Next(1, 99);
        }

        for (int i = 0; i < randomLength; i++)
        {
            if (i == 0)
            {
                min = array[i];
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.Write(max - min);
    }
}
