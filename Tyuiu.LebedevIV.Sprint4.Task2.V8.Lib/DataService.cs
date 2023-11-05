using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LebedevIV.Sprint4.Task2.V8.Lib
{
    public class DataService : ISprint4Task2V8
    {
        public int Calculate(int[] array)
        {
            int sumOfOddNumbers = 0;

            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    sumOfOddNumbers += number;
                }
            }

            return sumOfOddNumbers;
        }
    }
}
