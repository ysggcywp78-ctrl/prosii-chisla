
using System;

class Program
{
    static void Main()
    {
        Console.Write("До какого числа? ");
        int n = int.Parse(Console.ReadLine());

        for (int num = 2; num <= n; num++)
        {
            bool ok = true;

            for (int d = 2; d < num; d++)
            {
                if (num % d == 0)
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
                Console.Write(num + " ");
        }
    }
}