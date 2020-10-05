using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTerview
{
    class Palindrome
    {
        static void Method(int num)
        {
            int temp = num;
            int sum = 0;
            int r;
            while (temp > 0)
            {
                r = temp % 10;
                sum = (sum * 10) + r;
                temp = temp / 10;
            }
            if (num == sum)
            {
                Console.WriteLine(num+" "+ "IsPalindrome");
            }
            else
            {
                Console.WriteLine(num + " " + "NotPalindrome");
            }
        }
        static void Main(string[] args)
        {
            Palindrome.Method(12101);
            Console.ReadLine();
        }
    }
}
