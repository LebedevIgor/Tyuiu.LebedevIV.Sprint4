using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LebedevIV.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int minElement = array[0, 3]; 

            for (int i = 1; i < array.GetLength(0); i++) 
            {
                if (array[i, 3] < minElement)
                {
                    minElement = array[i, 3];
                }
            }

            return minElement;
        }
    }
}
