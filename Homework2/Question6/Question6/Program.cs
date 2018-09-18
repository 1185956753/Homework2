using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("输入一个大于1的数:");
            n = int.Parse(Console.ReadLine());
            Console.Write(n+"的素数因子为:");
            for(int i = 2; i <= n;)
            {
                int a = n % i;
                if (a == 0)
                {
                    Console.Write(" " + i);
                    n = n / i;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
