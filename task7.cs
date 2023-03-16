using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        Program.Task23(num);

        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int ans = Program.Task24(m, n);
        Console.WriteLine(ans);

        int m_2 = int.Parse(Console.ReadLine());
        int n_2 = int.Parse(Console.ReadLine());
        int ans_2 = Program.Task25(m_2, n_2);
        Console.WriteLine(ans_2);
    }

    static int Task23(int num)
    {
        if (num == 0)
        {
            Console.WriteLine();
            return 1;
        }
        Console.Write(num + ",");
        return Task23(num - 1);
    }

    static int Task24(int m, int n)
    {
        if (m == n)
        {
            return n;
        }
        else
        {
            return m + Task24(m + 1, n);
        }
    }

    static int Task25(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0 && m > 0) return Task25(m - 1, 1);
        else return Task25(m - 1, Task25(m, n - 1));
    }
}