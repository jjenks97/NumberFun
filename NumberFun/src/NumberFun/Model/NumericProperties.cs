using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberFun.Model
{
    
    public class NumericProperties
    {
        public int Num { get; set; }
        public NumericProperties(int num)
        {
            Num = num;
        }
        public bool isPrime()
        {
            if (Num == 1)
            {
                return false;
            }
            if (Num == 2)
            {
                return true;
            }
            int squareRoot = (int)Math.Floor(Math.Sqrt(Num));

            for (int i = 2; i <= squareRoot; i++)
            {
                if (Num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private bool isPrime(int num)
        {
            if (num == 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            int squareRoot = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 2; i <= squareRoot; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isPerfect()
        {
            int sum = 0;
            for (int i = 1; i < Num; i++)
            {
                if (Num % i == 0 )
                {
                    sum = sum + i;
                }
            }
            if (sum == Num)
            {
                return true;
            }
            return false;

        }
        public bool isSquareful()
        {
            for (int i = 2; i <= Num/2; i++)
            {
                if (Num % i == 0)
                {
                    if (isPrime(i))
                    {
                        if (Num % (i * i) == 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool isPowerful()
        {
            for (int i = 2; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    if (isPrime(i))
                    {
                        if (Num % (i * i) != 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public bool isPalindrome()
        {
            int remainder = 0;
            int reverse = 0;
            int num2 = Num;
            while (num2 > 0)
            {
                remainder = num2 % 10;
                reverse = (reverse * 10) + remainder;
                num2 = num2 / 10;
            }
            if (Num == reverse)
            {
                return true;
            }
            return false;
        }
    }
}
