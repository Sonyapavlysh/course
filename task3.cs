using System;

class Program
{
    static void Main(string[] args)
    {
        Program.Task8();
        Program.Task9();
        Program.Task10();
    }

    static void Task8() {
      Console.WriteLine("Task 8");
      int num = int.Parse(Console.ReadLine());

      if ((num % 10 == num / 10000) && (num % 100) / 10 == (num / 1000) % 10) {
        Console.WriteLine("Yes");
      } else {
        Console.WriteLine("No");
      }
    }

    static void Task9() {
      Console.WriteLine("Task 9");
      int a1 = int.Parse(Console.ReadLine());
      int a2 = int.Parse(Console.ReadLine());
      int a3 = int.Parse(Console.ReadLine());
      int b1 = int.Parse(Console.ReadLine());
      int b2 = int.Parse(Console.ReadLine());
      int b3 = int.Parse(Console.ReadLine());

      double result = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2) + Math.Pow(b3 - a3, 2));

      Console.WriteLine(Math.Round(result, 2));
    }

    static void Task10() {
      Console.WriteLine("Task 10");
      int num = int.Parse(Console.ReadLine());

      for (int i = 1; i <= num; i++) {
        Console.WriteLine(Math.Pow(i, 3));
      }
    }
}
