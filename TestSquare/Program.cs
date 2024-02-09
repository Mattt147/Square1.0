using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySquares;

namespace TestSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача Ограда фермера");
            CommonTest();
            CircleTest();
            QuadrateTest();
            Rectangle2Test();
            RectangleGoldTest();
            TriangleTest();
            HexagonTest();
            RombTest();
        }
        // нужно дописать последние 4 теста
        //это тебе на тебе, Симон
        //надеемся на тебя
        static void CommonTest()
        {
            double perimetr = 55;
            double SquareCircle = SquareModel.SquareCircle(perimetr);
            double SquareQudrat = SquareModel.SquareQudrat(perimetr);
            double SquareRectangle2 = SquareModel.SquareRectangle2(perimetr);
            double SquareRectangleGold = SquareModel.SquareRectangleGold(perimetr);
            double SquareTriangle = SquareModel.SquareTriangle(perimetr);
            double SquareHexagon = SquareModel.SquareHexagon(perimetr);
            double SquareRomb = SquareModel.SquareRomb(perimetr);
            Console.WriteLine("Периметр = " + perimetr);
            Console.WriteLine("Площадь круга = " + SquareCircle);
            Console.WriteLine("Площадь квадрата= " + SquareQudrat);
            Console.WriteLine("Площадь прямоугольника 2 = " + SquareRectangle2);
            Console.WriteLine("Площадь прямоугольника золото = " + SquareRectangleGold);
            Console.WriteLine("Площадь треугольника = " + SquareTriangle);
            Console.WriteLine("Площадь шестиугольника = " + SquareHexagon);
            Console.WriteLine("Площадь ромба = " + SquareRomb);
            Console.WriteLine();
        }
        static void CircleTest()
        {
            Console.WriteLine("Тест Circle");
            Console.WriteLine("perimetr - целое, равное 5. Площадь намного меньше, но чуть больше половины Пи.");
            Console.WriteLine("Площадь = " + SquareModel.SquareCircle(5));
            
            Console.WriteLine("perimetr - вещественное, равное 2*Пи. Результат практически совпадает с Пи");
            Console.WriteLine("Площадь = " + SquareModel.SquareCircle(2*Math.PI));

            Console.WriteLine("perimetr - вещественное, меньше 1, равное 0.5");
            Console.WriteLine("Площадь в сто раз меньше результата при perimetr, равном 5");
            Console.WriteLine("Площадь = " + SquareModel.SquareCircle(0.5));
            Console.WriteLine();
        }
        static void QuadrateTest()
        {
            Console.WriteLine("Тест Quadrate");
            Console.WriteLine("perimetr - целое, равное 15. Площадь меньше почти в 14 раз, а стороны(-а) -");
            Console.WriteLine("вещественные числа(-о).");
            Console.WriteLine("Площадь = " + SquareModel.SquareQudrat(15));

            Console.WriteLine("perimetr - вещественное, равное 3*Пи. Площадь почти в 2 раза больше Пи");
            Console.WriteLine("Площадь = " + SquareModel.SquareQudrat(3*Math.PI));

            Console.WriteLine("perimetr - вещественное, меньше 1, равное 0.29. Площадь почти в тысячу раз меньше,");
            Console.WriteLine("чем площадь при perimetr, равном 3*Пи");
            Console.WriteLine("Площадь = " + SquareModel.SquareQudrat(0.29));
            Console.WriteLine();
        }
        static void Rectangle2Test()
        {
            Console.WriteLine("Тест Rectangle2Test");
            Console.WriteLine("perimetr - целое, равное 27. Площадь меньше почти в 4 раза, а стороны - числа вещественные.");
            Console.WriteLine("Площадь = " + SquareModel.SquareRectangle2(27));

            Console.WriteLine("perimetr - вещественное, равное 1.25*Пи. Площадь меньше 1, значит одна из сторон тоже меньше 1,");
            Console.WriteLine("либо обе стороны меньше 1.");
            Console.WriteLine("Площадь = " + SquareModel.SquareRectangle2(1.25 * Math.PI));

            Console.WriteLine("perimetr - вещественное,меньше 1, равное 0.2. Площадь в сто раз меньше периметра, а также находится в периоде.");
            Console.WriteLine("Площадь = " + SquareModel.SquareRectangle2(0.2));
            Console.WriteLine();
        }
        static void RectangleGoldTest()
        {
            Console.WriteLine("RectangleGoldTest");
        }
        static void TriangleTest()
        {
            Console.WriteLine("TriangleTest");
        }
        static void HexagonTest()
        {
            Console.WriteLine("HexagonTest");
        }
        static void RombTest()
        {
            Console.WriteLine("RombTest");
        }
    }
}
