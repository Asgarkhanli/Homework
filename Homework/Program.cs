using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task-01
            int a;
            for (a = 1; a < 40; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
            }

            // Task-02
            int sum = 0;
            int[] A = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] % 2 == 1)
                {
                    sum += A[i];
                }
            }
            Console.WriteLine(sum);


            // Task-03
            int radius = 24;
            double area;
            double p;
            area = radius * radius *(3.14);
            p = 2 * radius * (3.14);
            Console.WriteLine(area);
            Console.WriteLine(p);
        }
    }
}
