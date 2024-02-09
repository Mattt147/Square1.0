using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySquares;

namespace ConsoleInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            do
            {
                try
                {
                    Console.WriteLine("Ограда фермера: ");
                    Console.WriteLine("Для того, чтобы выйти с программы, нажмите 8");
                    Console.WriteLine("Введите периметр: ");
                    double perimetr;
                    perimetr = double.Parse(Console.ReadLine());
                    if (perimetr < 0)
                    {
                        throw new Exception("Ошибка! Периметр должен быть положительным числом");
                        continue;
                    }
                    Console.WriteLine("Выберте форму участка: ");
                    Console.WriteLine("1. Круг");
                    Console.WriteLine("2. Квадрат");
                    Console.WriteLine("3. Прямоугольник_2");
                    Console.WriteLine("4. Прямоугольник_Ф");
                    Console.WriteLine("5. Трегольник");
                    Console.WriteLine("6. Шестиугольник");
                    Console.WriteLine("7. Ромб");
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            SquareModel.SquareCircle(perimetr);
                            continue;
                        case 2:
                            SquareModel.SquareQudrat(perimetr);
                            continue;
                        case 3:
                            SquareModel.SquareRectangle2(perimetr);
                            continue;
                        case 4:
                            SquareModel.SquareRectangleGold(perimetr);
                            continue;
                        case 5:
                            SquareModel.SquareTriangle(perimetr);
                            continue;
                        case 6:
                            SquareModel.SquareHexagon(perimetr);
                            continue;
                        case 7:
                            SquareModel.SquareRomb(perimetr);
                            continue;
                        case 8:
                            menu = false;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            } while (menu);
        }
    }
}//треш