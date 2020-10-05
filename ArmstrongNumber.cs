using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTerview
{
    
    class ArmstrongNumber
    {   
        static int Pow(int a,int b)
        {
            int result=a;
            if (b == 0)
            {
                return 1;
            }
            for(int i = 1; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }
        static int len(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }
            return count;
        } 
        static void IsArmstrong(int num)
        {
            int sum = 0;
            int temp=num;
            int r;
            int lenth = ArmstrongNumber.len(num);
            while (temp > 0)
            {
                r = temp % 10;
                sum = sum + Pow(r, lenth);
                temp = temp / 10;
            }
            if (num == sum)
            {
                Console.WriteLine("Armstrong");
            }
            else
            {
                Console.WriteLine("NotArmstrong");
            }
        }
        public static void Main(String[] arg)
        {

            ArmstrongNumber.IsArmstrong(371);
            Console.ReadLine();
        }
    }
}
