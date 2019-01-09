using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciIterative
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n < 11; n++)
            {
                Console.WriteLine(FibonacciIterative(n));
            }
            Console.ReadLine();
        }

        public static long FibonacciIterative(int N)
        {
            if(N == 0)
            {
                return 0;
            }
            if(N == 1)
            {
                return 1;
            }

            long previous = 0;
            long current = 1;
            
            for(int currentN = 2; currentN <= N; currentN++)
            {
                long newVal = previous + current;
                previous = current;
                current = newVal;
            }
            return current;
        }
    }
}
