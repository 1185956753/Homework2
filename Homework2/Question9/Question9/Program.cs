using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] anArray = new int[99];
            for(int i = 2; i < 100; i++)
            {
                anArray[i - 2] = i;
            }
            int[] anotherArray = new int[99];
            Array.Copy(anArray, anotherArray, 99);

            for(int i = 2; i < 101; i++)
            {
                for(int j = 0; j < 99; j++)
                {
                    if(anArray[j] > i && anArray[j]%i == 0)
                    {
                        anotherArray[j] = 0;
                    }
                }
            }
            Console.WriteLine("2~100以内的素数有：");
            for(int i = 0; i < 99; i++)
            {
                if(anotherArray[i] != 0)
                {
                    Console.Write(" "+ anotherArray[i]);
                }
            }

        }
    }
}
