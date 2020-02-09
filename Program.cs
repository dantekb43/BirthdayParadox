using System;
using System.Numerics;

namespace birthdayParadox
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            bool flag50 = false;
            bool flag70 = false;
            bool flag95 = false;

            for (int peopleCount = 1; peopleCount <= bdayConstant; peopleCount++)
            {
                result = bdayParadoxCalc(peopleCount);
                if (!flag50 && result >= 0.5){
                    Console.WriteLine("P(" + peopleCount.ToString() + ") = " + result.ToString());
                    flag50 = true;
                }   
                else if (!flag70 && result >= 0.7){
                    Console.WriteLine("P(" + peopleCount.ToString() + ") = " + result.ToString());
                    flag70 = true;
                }
                else if (!flag95 && result >= 0.95){
                    Console.WriteLine("P(" + peopleCount.ToString() + ") = " + result.ToString());
                    flag95 = true;
                }
                else if (flag95) 
                    break;
            }
                
        }

        private static Int64 bdayConstant = 365 * 20;
        
        private static double bdayParadoxCalc(int peopleCount)
        {
            double result = 1;
            for (int i = 0; i < peopleCount; i++)
                result *=  (bdayConstant - i) / (double)bdayConstant;
            return 1 - result;
        }

        private static BigInteger Factorial(int n)
        {
            BigInteger sum = n;
            BigInteger result = n;
            for (int i = n - 2; i > 1; i -= 2)
            {
                sum = (sum + i);
                result *= sum;
            }

            if (n % 2 != 0) result *= n / 2 + 1;
            return result;
        }
    }
}
