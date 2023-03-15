using System;

class Program
{
    static void Main(string[] args)
    {
        Program.Task1();
        Program.Task2();
        Program.Task3();
        Program.Task4();
    }

    static void Task1()
    {
        Console.WriteLine("Task 1");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int max = num1 > num2 ? num1 : num2;
        int min = num1 < num2 ? num1 : num2;

        Console.WriteLine($"Maximum number is: {max}");
        Console.WriteLine($"Minimum number is: {min}");
    }

    static void Task2()
    {
        Console.WriteLine("Task 2");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
        else
        {
            if (num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
    }

    static void Task3()
    {
        Console.WriteLine("Task 3");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static void Task4()
    {
        Console.WriteLine("Task 4");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
