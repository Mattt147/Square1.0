using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Console.WriteLine("1. Круг");
                    Console.WriteLine("2. Квадрат");
                    Console.WriteLine("3. Прямоугольник_2");
                    Console.WriteLine("4. Прямоугольник_Ф");
                    Console.WriteLine("5. Трегольник");
                    Console.WriteLine("6. Шестиугольник");
                    Console.WriteLine("7. Ромб");
                    Console.WriteLine("8. Выход из программы");
                    Console.WriteLine("Выберте форму участка: ");
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        case 5:

                            break;
                        case 6:

                            break;
                        case 7:

                            break;
                        case 8:

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
}
