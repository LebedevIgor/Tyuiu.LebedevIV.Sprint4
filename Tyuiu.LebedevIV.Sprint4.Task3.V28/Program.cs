using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LebedevIV.Sprint4.Task3.V28.Lib;

namespace Tyuiu.LebedevIV.Sprint4.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Лебедев И.В. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Лебедев Игорь Владимирович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mas2 = new int[5, 5] {{5, 4, 9, 8, 5},
                                        {4, 6, 6, 9, 9},
                                        {9, 8, 4, 8, 8},
                                        {6, 8, 6, 8, 9},
                                        {9, 4, 6, 6, 7}   };
            int rows = mas2.GetUpperBound(0) + 1;
            int colums = mas2.Length / rows;

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Минимальный элемент - " + ds.Calculate(mas2));
            Console.ReadKey();
        }
    }
}
