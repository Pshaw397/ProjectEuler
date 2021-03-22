using System;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public int MultiplesOf(int numsBelow)
        {
            int sum = 0;
            for (int i = 0; i < numsBelow; i++)
            {
                if (i % 3 == 0 | i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
