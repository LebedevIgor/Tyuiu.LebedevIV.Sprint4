using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LebedevIV.Sprint4.Task7.V10.Lib
{
    public class DataService : ISprint4Task7V10
    {
        public int Calculate(int n, int m, string value)
        {
            if (value.Length != n * m)
            {
                throw new ArgumentException("Неверное количество символов для заданных размеров матрицы.");
            }

            int[,] matrix = new int[n, m];
            int sumOfOddNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int digit = int.Parse(value[i * m + j].ToString());

                    matrix[i, j] = digit;

                    if (digit % 2 != 0)
                    {
                        sumOfOddNumbers += digit;
                    }
                }
            }

            return sumOfOddNumbers;
        }
    }
}
