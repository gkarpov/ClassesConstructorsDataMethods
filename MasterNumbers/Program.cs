using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++ )
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                    Console.WriteLine(i);
            }
        }

        static bool IsPalindrome(int num)
        {
            string num_s = num.ToString();
            int len = num_s.Length;

            for (int i = 0; i <= len / 2; i++)
                if (num_s[i] != num_s[len - i - 1])
                    return false;
            return true;
        }

        static bool SumOfDigits(int num)
        {
            int digsum = 0;
            
            while (num > 0)
            {
                digsum += num % 10;
                num /= 10;
            }

            if (digsum % 7 == 0)
                return true;
            else
                return false;
        }

        static bool ContainsEvenDigit(int num)
        {
            int dig = 0;

            while (num > 0)
            {
                dig = num % 10;
                if (dig % 2 == 0)
                    return true;
                num /= 10;
                
            }

            return false;
        }

    }
}
