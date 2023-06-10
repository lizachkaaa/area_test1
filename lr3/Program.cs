﻿using System;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, Rad;

            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Треугольник");
            //Console.WriteLine("4. Трапеция");
            //Console.WriteLine("5. Сектор");

            string temp = Console.ReadLine();
            int variant = Convert.ToInt32(temp);    // преобразование в число

            switch (variant)
            {
                case 1:
                    Console.Write("Сторона А = ");
                    temp = Console.ReadLine();
                    a = Convert.ToDouble(temp);
                    Console.Write("Сторона B = ");
                    temp = Console.ReadLine();
                    b = Convert.ToDouble(temp);
                    Console.WriteLine("Площадь прямоугольника = " + a * b);
                    break;

                case 2:
                    Console.Write("Радиус R = ");
                    temp = Console.ReadLine();
                    Rad = Convert.ToDouble(temp);
                    Console.WriteLine("Площадь круга = " + 4 * Atan(1.0) * Pow(Rad, 2.0));
                    break;
                case 3:
                    Console.Write("Высота А = ");
                    temp = Console.ReadLine();
                    a = Convert.ToDouble(temp);
                    Console.Write("Основание B = ");
                    temp = Console.ReadLine();
                    b = Convert.ToDouble(temp);
                    Console.WriteLine("Площадь треугольника = " + (a * b) / 2);

               break;

                default: Console.WriteLine("Выбор неверен "); break;
            }
        }
    }
}
