using System;

namespace Science_Eleven
{
    class Program
    {
        static void Main(string[] args)
        {

            double f(double x)
            {
                //здесь функция, производную которой нужно найти, например, x^2
                return x * x - 9/4 ;
            }

            double x, h, fl, fr, fc, f2;

            x = 1; // точка, в которой вычисляем производную
            h = 0.1; // шаг, с которым вычисляем производную

            // приближенно вычисляем первую производную различными способами
            fl = (f(x) - f(x - h)) / h; // левая
            fr = (f(x + h) - f(x)) / h; // правая
            fc = (f(x + h) - f(x - h)) / (2 * h); // центральная

            // приближенно вычисляем вторую производную
            f2 = (f(x + h) - 2 * f(x) + f(x - h)) / (h * h);

            // выводим результаты на экран
            Console.WriteLine("x = " + x);
            Console.WriteLine("f1 = " + fl);
            Console.WriteLine("fr = " + fr);
            Console.WriteLine("fc = " + fc);
            Console.WriteLine("f2 = " + f2);
            Console.ReadKey();
        }
    }
}
