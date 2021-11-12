using System;

namespace task_5_golden_section
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 1, B = -2, a = -2, b = 4, e = 0.000001;
            double fi = (1 + Math.Sqrt(5)) / 2;
            double c;
            double x = 0;
            Console.WriteLine("Поиск точки экстремума будет осуществляться на отрезке[-1; 4]");
            while ((b - a) > e)
            {
                c = a + (b - a) / fi;
                x = (a + b - c);
                if (c > x)
                {
                    if ((Math.Pow(A*c, 2)) - B * c > (Math.Pow(A * x, 2)) - B * x)
                    {
                        b = c;
                    }
                    else
                    {
                        a = x;
                    }
                }
                else
                {
                    if (c < (Math.Pow(A * c, 2)) - B * c)
                    {
                        a = c;
                    }
                    else
                    {
                        b = x;
                    }

                }
                Console.WriteLine("Начало отрезка: " + a);
                Console.WriteLine("Конец отрезка: " + b);
                Console.WriteLine("Точка экстремума: " + x);

            }



        }
    }
}
