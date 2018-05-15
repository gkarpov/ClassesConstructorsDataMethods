using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreaterTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(a,b));
                    break;
                case "char":

                    char c = char.Parse(Console.ReadLine());
                    char d = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(c,d));
                    break;
                case "string":

                    string e = Console.ReadLine();
                    string f = Console.ReadLine();
                    Console.WriteLine(GetMax(e,f));
                    break;
                default:
                    break;
            }
        }

        static int GetMax(int a, int b)
        {
            if (a.CompareTo(b) > 0)
                return a;
            else if (a.CompareTo(b) < 0)
                return b;
            else return 0;
        }
        static char GetMax(char a, char b)
        {
            if (a.CompareTo(b) > 0)
                return a;
            else if (a.CompareTo(b) < 0)
                return b;
            else return '0';
        }
        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) > 0)
                return a;
            else if (a.CompareTo(b) < 0)
                return b;
            else return "";
        }
    }
}
