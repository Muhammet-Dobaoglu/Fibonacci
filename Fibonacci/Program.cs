﻿namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, i, c, n, j;
            Console.Write("Limiti Girin: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a = 0;
                b = 1;
                Console.Write(b + "\t");
                for (j = 1; j < i; j++)
                {
                    c = a + b;
                    Console.Write(c + "\t");
                    a = b;
                    b = c;
                }
                Console.Write("\n");
            }
        }
    }
}