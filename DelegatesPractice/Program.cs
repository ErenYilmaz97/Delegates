using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10,11,12};

            var result = Filter.FilterArray(array, NumberIsEven);    //TANIMLANMIŞ METHOT
            var result2 = Filter.FilterArray(array, x => x % 2 == 0);  //ANONİM METHOT
            var result3 = Filter.FilterArray(array, delegate(int value) { return value % 2 == 0;});  //ANONİM METHOT
            var result4 = Filter.FilterArray(array, x => x > 8 && x % 2 == 0);



            Console.WriteLine("---------------------RESULT 1-----------------------");

            foreach (var filteredValue in result)
            {
                Console.WriteLine(filteredValue);
            }

            Console.WriteLine("---------------------RESULT 2-----------------------");

            foreach (var filteredValue in result2)
            {
                Console.WriteLine(filteredValue);
            }

            Console.WriteLine("---------------------RESULT 3-----------------------");

            foreach (var filteredValue in result3)
            {
                Console.WriteLine(filteredValue);
            }


            Console.WriteLine("---------------------RESULT 4-----------------------");

            foreach (var filteredValue in result4)
            {
                Console.WriteLine(filteredValue);
            }


            Console.ReadLine();
        }


        public static bool NumberIsEven(int value)
        {
            return value % 2 == 0 ? true : false;
        }
    }
}
