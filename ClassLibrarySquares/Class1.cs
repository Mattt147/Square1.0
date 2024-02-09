using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySquares
{   /// <summary>
   /// Утилитарный клас для решения задачи фермера
  /// </summary>
    public static class CLass
    {  
        /// <summary>
        /// Вычисление плоащди квадрата
        /// </summary>
        /// <param name="perimetr"></param>
        /// <returns> площадь </returns>
        public static double SquareQudrat(double perimetr)
        {
            double s = Math.Pow(perimetr, 2)  / 16;
            return s;
        }

        /// <summary>
        /// Вычисление плоащди прямоугольника с отношнием сторон 1:2
        /// </summary>
        /// <param name="perimetr"></param>
        /// <returns> площадь </returns>
        public static double SquareRectangle2(double perimetr)
        {
            double s = Math.Pow( perimetr,  2)  / 18;
            return s;
        }

        /// <summary>
        /// Вычисление плоащди прямоугольника с отношением сторон, 
        /// Задующемся золотым сечением
        /// </summary>
        /// <param name="perimetr"></param>
        /// <returns> площадь </returns>
        public static double SquareRectangleGold(double perimetr)
        {
            double f = (1 + Math.Sqrt(5)) / 2;
            double s  = (f * Math.Pow(perimetr, 2)) / (4 * Math.Pow(1 + f, 2));
            return s;
        }

        /// <summary>
        /// Вычисление плоащди круга
        /// </summary>
        /// <param name="perimetr"></param>
        /// <returns> площадь </returns>
        public static double SquareCircle(double perimetr)
        {
            double s = Math.Pow(perimetr, 2) / (4 * Math.PI);
            return s;
        }

        /// <summary>
        /// Вычисление плоащди  равностороннего треугольника 
        /// </summary>
        /// <param name="perimetr"></param>
        /// <returns> площадь </returns>
        public static double SquareTriangle(double perimetr)
        {
            double s = Math.Pow(perimetr, 2) * Math.Sqrt(3) / 36;
            return s;
        }

        /// <summary>
        /// Вычисление плоащди правильного шестиугольника 
        /// </summary>
        /// <param name="perimetr"></param>
        /// <returns> площадь </returns>
        public static double SquareHexagon(double perimetr)
        {
            double s = Math.Pow(perimetr, 2) * 3 * Math.Sqrt(3) / 72;
            return s;
        }

        /// <summary>
        /// Вычисление плоащди ромба с острым углом 60 градусов
        /// </summary>
        /// <param name="perimetr"></param>
        /// <returns> площадь </returns>
        public static double SquareRomb(double perimetr)
        {
            double s = Math.Pow(perimetr, 2) * Math.Sqrt(3) / 32;
            return s;
        }

    }
}
