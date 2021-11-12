using System;

namespace golden_section
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 1, B = -2, a = -1, b = 4, eps = 0.000001;
            double fi = (1 + Math.Sqrt(5)) / 2;
            double c;
            double x;
            Console.WriteLine("Поиск точки экстремума будет осуществляться на отрезке[-3; 3]");
        }
    }
}
