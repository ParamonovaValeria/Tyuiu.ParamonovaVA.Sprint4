﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ParamonovaVA.Sprint4.Task1.V12.Lib
{
    public class DataService : ISprint4Task1V12
    {
        public int Calculate(int[] array)
        {
            int proiz = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    proiz *= array[i];
                }
            }
            return proiz;
        }
    }
}
