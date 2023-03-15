using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Program.Task18();
        Program.Task19();
        Program.Task20();
    }

    static void Task18()
    {
        Console.WriteLine("Task 18");

        int[,] matrix = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            List<int> rowList = GetRow(matrix, i);
            rowList.Sort();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rowList[j];
            }
        }

        List<int> GetRow(int[,] matrix, int row)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                result.Add(matrix[row, i]);
            }
            return result;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Task19()
    {
        Console.WriteLine("Task 19");

        int[,] matrix = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
        int min = 0;
        int temp = 0;

        int result = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp += matrix[i, j];
            }

            if (i == 0)
            {
                min = temp;
            }
            if (temp < min)
            {
                min = temp;
                result = i;
            }

            temp = 0;
        }
        Console.WriteLine(result + 1 + " строка");
    }

    static void Task20()
    {
        Console.WriteLine("Task 20");

        int[,] matrix1 = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
        int[,] matrix2 = { { 1, 5, 8, 5 }, { 4, 9, 4, 2 }, { 7, 2, 2, 6 }, { 2, 3, 4, 7 } };
        int[,] result = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
