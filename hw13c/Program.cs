using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13c
{
    class Program
    {
        static void Main(string[] args)
        {
            RectTriangle rectTriangle = new RectTriangle(4, 5);//создаем класс прямоугольный треугольник
            Triangle triangle = rectTriangle;// преобразовываем к треугольнику
            RectTriangle rectTriangle1 =(RectTriangle) triangle;//создаем еще один прямоугольный треугольник и присваеваем ему значение треугольника
        }
    }
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle()
        {
           
        }
        public Triangle(double a,double b,double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double GetAgea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    class RectTriangle : Triangle
    {
        public RectTriangle(double a, double b)
        {
            A = a;
            B = b;
            C = Math.Sqrt(a * a + b * b);
        }
    }
}
