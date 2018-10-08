using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    
    public class 闹钟
    {
        static int hour, minute, second;
       
        public static DateTime getDate()
        {
            return DateTime.Now;
            
        }
        public static DateTime setClock(int a, int b, int c, DateTime dtn)
        {
            hour = a;
            minute = b;
            second = c;
            TimeSpan ts = new TimeSpan(hour, minute, second);
            DateTime targetTime = new DateTime();
            targetTime = dtn + ts;
            return targetTime;

        }
        public static void Alarm(DateTime targetTime)
        {

            int h = DateTime.Now.Hour; //获取当前时间的小时部分

            int m = DateTime.Now.Minute; //获取当前时间的分钟部分

            int s = DateTime.Now.Second; //获取当前时间的秒部分
            
            do
            {
                h = DateTime.Now.Hour; //获取当前时间的小时部分

                m = DateTime.Now.Minute; //获取当前时间的分钟部分

                s = DateTime.Now.Second; //获取当前时间的秒部分

            } while (0 == targetTime.Hour && m != targetTime.Minute && s == targetTime.Second );
            Console.WriteLine("时间到了");
            


        }
        

    }

    public class HomeWork4
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("依次输入小时，分，秒，闹钟将经过这么多时间后提醒：");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            DateTime dtn1 = new DateTime();
            dtn1 = 闹钟.getDate();
            Console.WriteLine("现在的时间" + dtn1.Hour + ":" + dtn1.Minute + ":" + dtn1.Second);
            Console.WriteLine($"系统将在{a}小时，{b}分，{c}秒后通知您");
            闹钟.Alarm(闹钟.setClock(a, b, c, dtn1));

        }
    }
    
}
