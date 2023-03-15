using System;

class Program
{
    static void Main(string[] args)
    {
        Program.Task5();
        Program.Task6();
        Program.Task7();
    }

    static void Task5() {
      Console.WriteLine("Task 5");
      int num = int.Parse(Console.ReadLine());

      int secondDigit = (num / 10) % 10;

      Console.WriteLine($"{secondDigit}");
    }

    static void Task6() {
      Console.WriteLine("Task 6");
      int num = int.Parse(Console.ReadLine());
      if (num <= 99) {
        Console.WriteLine("Третьей цифры нет");
      } else {
        while ( num > 1000) {
          num /= 10;
        }
        Console.WriteLine(num % 10);
      }
    }

    static void Task7() {
      Console.WriteLine("Task 7");
      int num = int.Parse(Console.ReadLine());
      if (num == 6 || num == 7) {
        Console.WriteLine("Yes");
      } else {
        Console.WriteLine("No");
      }
    }
}
