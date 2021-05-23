using System;
using System.Collections.Generic;

namespace DelegatesPractice
{
    public static class Filter
    {
        //public delegate bool Criteria(int value); //ARTIK GEREK YOK

        public static int[] FilterArray(int[] array, Func<int,bool> criteriaFunction)
        {
            List<int> filteredArray = new List<int>();

            foreach (int value in array)
            {
                //DELEGATE'İN İŞARET ETTİĞİ METHOTU ÇALIŞTIR. TRUE İSE LİSTEYE EKLE
                //ANONİM VEYA TANIMLI METHOT OLABİLİR
                if (criteriaFunction(value))  
                {
                    filteredArray.Add(value);
                }
            }

            return filteredArray.ToArray();
        }

    }
}