using System;

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
                    Console.WriteLine("Площадь круга = " + 4 * Math.Atan(1.0) * Math.Pow(Rad, 2.0));
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
                         case 4:
                    Console.Write("Основание A = ");
                    double topBase = double.Parse(Console.ReadLine());

                    Console.Write("Основание B = ");
                    double bottomBase = double.Parse(Console.ReadLine());

                    Console.Write("Высота h = ");
                    double height = double.Parse(Console.ReadLine());

                    double area = (topBase + bottomBase) * height / 2;

                    Console.WriteLine("Площадь трапеции = " + area);
                    break;
                case 5:

                    Console.Write("Введите угол в градусах: ");
                    double angleInDegrees = double.Parse(Console.ReadLine());


                    Console.Write("Введите радиус: ");
                    double radius = double.Parse(Console.ReadLine());


                    double angleInRadians = Math.PI * angleInDegrees / 180;


                    double sectorArea = 0.5 * angleInRadians * Math.Pow(radius, 2);

                    Console.WriteLine("Sector Area: " + sectorArea);



                    break;
                case 6:


                    Console.Write("Введите длину: ");
                    double baseLength = double.Parse(Console.ReadLine());

                    Console.Write("Введите высоту: ");
                    double qqq = double.Parse(Console.ReadLine());


                    double www = 0.5 * baseLength * qqq;

                    Console.WriteLine("Площадь прямоугольного треугольника: " + www);

                    break;
                default: Console.WriteLine("Выбор неверен "); break;
                default: Console.WriteLine("Выбор неверен "); break;
            }
        }
    }
}
