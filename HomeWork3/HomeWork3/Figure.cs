using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Figure
    {
        private String type; //图形类型 
        public double[] data;//图形的数据

        public Figure(double[] data, String type)
        {
            this.type = type;
            if (type == "triangle")
            {
                //初始化三角形
                this.data = new double[3];
                this.data[0] = data[0];
                this.data[1] = data[1];
                this.data[2] = data[2];
                if (data[0] + data[1] <= data[2]||data[0] + data[2] <= data[1]||data[1] + data[2] <= data[0])
                {
                    throw new ArgumentException();//三条边长度不能构成一个三角形，返回异常
                }
                else
                {
                    //得到三角形的三条边长度，初始化
                    double a = data[0];
                    double b = data[1];
                    double c = data[2];

                }
            }
            else if (type == "circle")
            {
                //初始圆形
                this.data = new double[1];
                this.data[0] = data[0];
                if (data[0] <= 0)
                {
                    throw new ArgumentException();//半径小于0
                }
                else
                {
                    //得到圆形半径，初始化
                    double r = data[0];
                }
            }
            else if (type == "square")
            {
                //初始化正方形 
                this.data = new double[1];
                this.data[0] = data[0];
                if (data[0] <= 0)
                {
                    throw new ArgumentException();//边长小于0
                }
                else
                {
                    //得到正方形边长，初始化
                    double l = data[0];
                }
            }
            else if(type == "rectangle")
            {
                //初始化长方形
                this.data = new double[2];
                this.data[0] = data[0];
                this.data[1] = data[1];
                if (data[0] <= 0 || data[1] <= 0 || data[0] == data[1])
                {
                    throw new ArgumentException();//长宽小于0，或想等
                }
                else
                {
                    //得到长方形长和宽，初始化
                    double a = data[0];
                    double b = data[1];
                }



            }
        }
        //求图形的面积
        public double Area(Figure figure)
        {
            switch (figure.type)
            {
                case "triangle":
                    {
                        double a = figure.data[0];
                        double b = figure.data[1];
                        double c = figure.data[2];
                        return 0.25 * (Math.Sqrt(((a + b + c) * (a + b - c) * (a + c - b) * (b + c - a))));
                    }
                case "circle":
                    {
                        return 3.14 * figure.data[0] * figure.data[0];
                    }
                case "square":
                    {
                        return figure.data[0] * figure.data[0];
                    }
                case "rectangle":
                    {
                        return figure.data[0] * figure.data[1];
                    }
                default:
                    return 0;

            }
                


                
            
        }

    }
    class HomeWork3
    {
        public static void Main(string[] args)
        {
            Figure square = new Figure(new double[] { 1 }, "square");
            Console.WriteLine($"边长为{square.data[0]}正方形的面积：" + square.Area(square));
            Figure rectangle = new Figure(new double[] { 1,2 }, "rectangle");
            Console.WriteLine($"长为{rectangle.data[0]},宽为{rectangle.data[1]}的面积:" + rectangle.Area(rectangle));
            Figure circle = new Figure(new double[] { 1 }, "circle");
            Console.WriteLine($"半径为{circle.data[0]}圆的面积：" + circle.Area(circle));
            Figure triangle = new Figure(new double[] { 3,4,5 }, "triangle");
            Console.WriteLine($"边长分别为{triangle.data[0]},{triangle.data[1]},{triangle.data[2]}的三角形的面积：" + triangle.Area(triangle));
        }
    }
}
