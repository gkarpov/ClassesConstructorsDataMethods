using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplEvOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  GetMultEvAndOd(int.Parse(Console.ReadLine()))); 
        }

        static int GetMultEvAndOd(int num)
        //private static int GetMultEvAndOd(int num)
        {
            return GetOdSum(Math.Abs(num)) * GetEvSum(Math.Abs(num));
        }

        static int GetOdSum(int num)
        //private static int GetOdSum(int num)
        {
            int sum = 0;
            
            while (num > 0)
            {
                if(num%2 == 1)
                    sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        //private static int GetEvSum(int num)
        static int GetEvSum(int num)
        {
            int sum = 0;
            
            while (num > 0)
            {
                if (num % 2 == 0)
                    sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
