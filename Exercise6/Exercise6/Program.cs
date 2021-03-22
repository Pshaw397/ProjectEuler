using System;
namespace Exercise6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(50));
        }

        public static int Sum(int passedNum)
        {
            int sumNum = 0;
            int sumSquare = 0;
            int sumSquaredTotal = 0;
            int result = 0;
            for (int i = 0; i <= passedNum; i++)
            {
                sumSquare += (int)Math.Pow(i, 2);
                sumNum += i;
            }
            sumSquaredTotal = (int)Math.Pow(sumNum, 2);
            result = sumSquaredTotal - sumSquare;
            return result;
        }
    }
}
