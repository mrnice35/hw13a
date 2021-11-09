using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace исключения
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularTriangle regularTriangle = new RegularTriangle();//создаем экземпляр класса правильный треугольнике
            Triangle triangle = regularTriangle;  //преобразовали его к классу треугольник
            RectTriangle rectTriangle = triangle as RectTriangle;//создаем еще один прямоугольный треугольник и присваеваем ему значение треугольника
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
        public Triangle(double a, double b, double c)
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
    class RegularTriangle:Triangle// создаем класс для правилнього треугольника
    {

    }
}

