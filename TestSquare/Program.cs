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
            QudratTest();
            Rectangle2Test();
            RectangleGoldTest();
            TriangleTest();
            HexagonTest();
            RombTest();
        }
        static void CommonTest()
        {
            double perimetr = 55;
            double SquareCircle = CLass.SquareCircle(perimetr);
            double SquareQudrat = CLass.SquareQudrat(perimetr);
            double SquareRectangle2 = CLass.SquareRectangle2(perimetr);
            double SquareRectangleGold = CLass.SquareRectangleGold(perimetr);
            double SquareTriangle = CLass.SquareTriangle(perimetr);
            double SquareHexagon = CLass.SquareHexagon(perimetr);
            double SquareRomb = CLass.SquareRomb(perimetr);
            Console.WriteLine("Периметр = " + perimetr);
            Console.WriteLine("Площадь круга = " + SquareCircle);
            Console.WriteLine("Площадь квадрата= " + SquareQudrat);
            Console.WriteLine("Площадь прямоугольника 2 = " + SquareRectangle2);
            Console.WriteLine("Площадь прямоугольника золото = " + SquareRectangleGold);
            Console.WriteLine("Площадь треугольника = " + SquareTriangle);
            Console.WriteLine("Площадь шестиугольника = " + SquareHexagon);
            Console.WriteLine("Площадь ромба = " + SquareRomb);
        }
        static void CircleTest()
        {
            Console.WriteLine("Тест Circle");
            Console.WriteLine("perimetr - целое, равное 5. Площадь ")
        }
        static void QudratTest()
        {

        }
        static void Rectangle2Test()
        {

        }
        static void RectangleGoldTest()
        {

        }
        static void TriangleTest()
        {

        }
        static void HexagonTest()
        {

        }
        static void RombTest()
        {

        }
    }
}
