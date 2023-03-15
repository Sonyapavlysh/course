using System;

class Program
{
    static void Main(string[] args)
    {
        Program.Task12();
        Program.Task13();
        Program.Task14();
    }

    static void Task12()
    {
        Console.WriteLine("Task 12");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(Math.Round(((random.NextDouble() - 0.5) * 10), 1) + " ");
            }
            Console.WriteLine();
        }
    }

    static void Task13()
    {
        Console.WriteLine("Task 13");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        try
        {
            Console.Write(matrix[m, n]);
        }
        catch
        {
            Console.Write("Нет такого числа");
        }
    }

    static void Task14()
    {
        Console.WriteLine("Task 14");
        double[,] matrix = new double[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        double temp = 0;
        double[] result = new double[matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                temp += matrix[j, i];
            }
            result[i] = (Math.Round(temp / matrix.GetLength(0), 2));
            temp = 0;
        }
        foreach (double element in result)
        {
            Console.Write(element + "; ");
        }
    }
}
