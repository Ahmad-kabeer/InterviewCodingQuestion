using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTerview
{
    /*
    
    

     */
    class FibnocciSeries
    {
        
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1 + " " + n2+" ");
            int n = 15;      //number of element
            for(int i = 2; i < n; i++)
            {  
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
        
    }
}
