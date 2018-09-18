using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            Console.Write("请定义数组长度(输入一个大于2的整数表示数组长度)：");
            l = int.Parse(Console.ReadLine());
            int[] anArray = new int[l];
            int i = 0, MAX = 0, MIN = 0, sum = 0;
            Console.WriteLine($"请输{l}个整数：");
            while(i < l)
            {
                anArray[i] = int.Parse(Console.ReadLine());
                i++;
            }
            //求最大值：
            MAX = anArray[0];
            for(int a = 1; a < l; a++)
            {
                if(MAX <= anArray[a])
                {
                    MAX = anArray[a];
                }
            }
            Console.WriteLine("最大值为：" + MAX);
            //求最小值
            MIN = anArray[0];
            for (int a = 1; a < l; a++)
            {
                if (MIN >= anArray[a])
                {
                    MIN = anArray[a];
                }
            }
            Console.WriteLine("最大值为：" + MIN);
            //和与平均值
            for(int c = 0; c < anArray.Length; c++)
            {
                sum += anArray[c];
            }
            double 平均值 = sum / ((double)l);
            Console.WriteLine($"平均值为：{平均值}");
            Console.WriteLine($"和为：{sum}");
        }
    }
}
