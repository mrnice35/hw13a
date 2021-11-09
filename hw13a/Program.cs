using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13a
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(1,2,3);  //создаем экземпляр класса треугольник без параметров
        }
    }
    class Triangle // объявили класс треугольник
    {
        public double A { get; set; }  //3 стороны это автоствойства
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a,double b,double c)  // конструктор принимает три числа и присваивает их соотвественно в А В С
        {
            A = a;
            B = b;
            C = c;
        }
        public double GetAgea()        // Создание метода вычесляющего площадь
        {
            double p = (A + B + C) / 2;  // по формуле Герона
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    class RectTriangle:Triangle  //Создаем дочерний класс прямоугольный треугольник который наследует все свойства 
    {
        public RectTriangle (double a,double b)
            :base(a,b,Math.Sqrt(a*a+b*b)) // вызываем родительский класс
        {

        }
    }
}
