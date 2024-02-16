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
                    Console.WriteLine("Введите периметр: ");
                    // объявление и ввод значения периметра
                    double perimetr;
                    perimetr = double.Parse(Console.ReadLine());
                    // обработка ошибки при неверном вводе значения периметра
                    if (perimetr < 0)
                    {
                        throw new Exception("Ошибка! Периметр должен быть положительным числом");
                        continue;
                    }
                    // выбор формы участка
                    Console.WriteLine("Выберте форму участка: ");
                    Console.WriteLine("1. Круг");
                    Console.WriteLine("2. Квадрат");
                    Console.WriteLine("3. Прямоугольник с отношением сторон 1:2");
                    Console.WriteLine("4. Прямоугольник с отношением сторон, задаюoимся золотым сечением");
                    Console.WriteLine("5. Равносторонний трегольник");
                    Console.WriteLine("6. Правильный шестиугольник");
                    Console.WriteLine("7. Ромб");
                    Console.WriteLine("8. Выбрать все");
                    Console.WriteLine("9. Завершить работу программы");
                    Console.WriteLine("");
                    int num = int.Parse(Console.ReadLine());
                    // выбор команды
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Площадь круга равна " + SquareModel.SquareCircle(perimetr));
                            continue;
                        case 2:
                            Console.WriteLine("Площадь квадрата равна " + SquareModel.SquareQudrat(perimetr));
                            continue;
                        case 3:
                            Console.WriteLine("Площадь прямоугольника с отношением" +
                                "сторон 1:2 равна " + SquareModel.SquareRectangle2(perimetr));
                            continue;
                        case 4:
                            Console.WriteLine("Площадь прямоугольника" +
                                " с отношением сторон, задаюзимся золотым сечением равна " + SquareModel.SquareRectangleGold(perimetr));
                            continue;
                        case 5:
                            Console.WriteLine("Площадь равностороннего треугольника равна " + SquareModel.SquareTriangle(perimetr));
                            continue;
                        case 6:
                            Console.WriteLine("Площадь правильного шестиугольника равна " + SquareModel.SquareHexagon(perimetr));
                            continue;
                        case 7:
                            Console.WriteLine("Площадь ромба равна " + SquareModel.SquareRomb(perimetr));
                            continue;
                        case 8:
                            Console.WriteLine("Площадь круга равна " + SquareModel.SquareCircle(perimetr));
                            Console.WriteLine("Площадь квадрата равна " + SquareModel.SquareQudrat(perimetr));
                            Console.WriteLine("Площадь прямоугольника с отношением" +
                                "сторон 1:2 равна " + SquareModel.SquareRectangle2(perimetr));
                            Console.WriteLine("Площадь прямоугольника" +
                                " с отношением сторон, задаюзимся золотым сечением равна " + SquareModel.SquareRectangleGold(perimetr));
                            Console.WriteLine("Площадь равностороннего треугольника равна " + SquareModel.SquareTriangle(perimetr));
                            Console.WriteLine("Площадь правильного шестиугольника равна " + SquareModel.SquareHexagon(perimetr));
                            Console.WriteLine("Площадь ромба равна " + SquareModel.SquareRomb(perimetr));
                            continue;
                        case 9:
                            menu = false;
                            return;
                    }
                }
                // обработка ошибок
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