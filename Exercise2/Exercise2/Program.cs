using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(25000));
        }

        public static int Fib(int limit)
        {
            int int1 = 1;
            int int2 = 2;
            int int3 = int1 + int2;
            int sum = int2;
            List<int> evenNuns = new List<int>();

            while (int3 <= limit)
            {
                int1 = int2;
                int2 = int3;
                int3 = int1 + int2;
                if(int3 % 2 == 0)
                {
                    evenNuns.Add(int3);
                }
            }
            foreach (var nums in evenNuns)
            {
                sum += nums;
            }
            return sum;
        }
    }
}
