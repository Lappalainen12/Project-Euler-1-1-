using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEiler_1
{
    class Program
    {

        public static void SearchSumNumbers(int[] arrNums)
        {


            int count = 0;

            /// Заполнение массива элементами
            for (int i = 0; i < arrNums.Length; i++)
            {
                count++;
                arrNums[i] = count;
            }


            int sumCount = 0;

            /// Проверка на кратность (число 3 и 5)
            for (int i = 0; i < arrNums.Length; i++)
            {
                
                if (arrNums[i] % 3 == 0)
                {
                    sumCount += arrNums[i];
                }

                else if (arrNums[i] % 5 == 0)
                {
                    sumCount += arrNums[i];
                }

            }

            Console.WriteLine(sumCount);

        }

        
        static void Main(string[] args)
        {
            
            ///Исходное число
            int inputNumber = 1000;

            ///Массив с указанным числом
            int[] arrNumbers = new int[inputNumber];

            SearchSumNumbers(arrNumbers);

        }
    }
}
