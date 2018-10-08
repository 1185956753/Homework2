using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_2
{
    public class Order
    {
        public object item;
        public Order next;
        private Order head;
        private int index;

        //构造函数

        public Order()
        {
            head = new Order();
            index = 0;
        }
        public Order(object v)
        {
            item = v; next = null;
        }

        public void headOrder()
        {
            head = new Order();
            index = 0;
        }

        public bool delOrder(object ob)//查找删除
        {
            Order x = head;
            Order t;
            bool b = false;
            for (int i = 0; i < index; i++)
            {

                t = x.next;
                if (t.item == ob)
                {
                    x.next = x.next.next;
                    index = index - 1;
                    b = true;
                }
                x = x.next;
            }
            return b;

        }
        public void insertOrder(object ob)//从后面插入
        {
            Order x = head;
            Order t = new Order(ob);

            for (int i = 0; i < index; i++)
                x = x.next;

            t.next = x.next;
            x.next = t;

            index = index + 1;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("");
        }

    }
    public class OrderDetails
    {


    }
    public class OrderSevice
    {



    }
}
