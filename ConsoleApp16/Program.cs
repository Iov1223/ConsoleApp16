using System;

namespace ConsoleApp16
{
    internal class Program
    {
        public int GreatestCommonDivisor(int a, int b)
        {
            if (a % b == 0)
                return b;
            if (b % a == 0)
                return a;
            if (a > b)
                return GreatestCommonDivisor(a % b, b);
            return GreatestCommonDivisor(a, b % a);
        }
        public int LeastCommonMultiple(int a, int b)
        {
            return (a * b) / GreatestCommonDivisor(a, b);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            int minSmallestCommonMultiple = program.LeastCommonMultiple(n - 1, 1), SmallestCommonMultiple;
            int a = n - 1, b = 1;
            for (int i = 2; i < n; i++)
            {
                SmallestCommonMultiple = program.LeastCommonMultiple(n - i, i);
                if (minSmallestCommonMultiple > SmallestCommonMultiple)
                {
                    minSmallestCommonMultiple = SmallestCommonMultiple;
                    a = n - i;
                    b = i;
                }
            }
            Console.WriteLine(a + " " + b); 
        }
    }
}
