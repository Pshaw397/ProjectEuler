using System;

namespace Exercise4
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Pal(int lowerNum, int upperNum)
        {
            int minNum = lowerNum;
            int maxNum = upperNum;
            int multipliedNum = 0;
            string reversedNum = "";
            int result = 0;
            for (int num1 = minNum; num1 < maxNum; num1++)
            {
                for (int num2 = minNum; num2 < maxNum; num2++)
                {
                    multipliedNum = num1 * num2;
                    char[] numArray = multipliedNum.ToString().ToCharArray();
                    Array.Reverse(numArray);
                    reversedNum = new string(numArray);

                    if (reversedNum == multipliedNum.ToString() && multipliedNum > result)
                    {
                        result = multipliedNum;
                    }
                }
            }
            return result;
        }
    }
}
