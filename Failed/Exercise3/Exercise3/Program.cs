using System;

namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(primeNumEx());
        }
       
        public static int primeNumEx()
        {
            int result = 0;
            double dividNum = 0.0;
            bool isPrime = false;
            for (int i = 1; i < 150; i++)
            {

                var limit = Math.Ceiling(Math.Sqrt(i));
                for (int j = 2; j <= limit; ++j)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        continue;
                    }
                    else if (i % j != 0)
                    {
                        isPrime = true;
                        continue;
                    }
                }
                dividNum = 13195.0 / i;
                if (dividNum % 1 == 0.0 & isPrime == true)
                {
                    result = i;
                }
            }
            return result;
        }
    }
}
