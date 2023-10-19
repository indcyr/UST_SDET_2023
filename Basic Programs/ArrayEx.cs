using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ArrayEx
    {
        readonly int[] numbers = new int[5];  // { 10, 20, 30 };
        int[,] nums = { { 100, 200 }, { 300, 400 } };//new int[2,2];


        public void Onedim() {
            numbers[0] = 100;
            numbers[1] = 123;
            numbers[2] = 300;
        for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine(numbers[i]);
            }
        Console.WriteLine("2nd");

            
            numbers[1] = 120;
            Array.Sort(numbers);
            foreach (var num in numbers)
            {

                Console.WriteLine(num);
            }
            Array.Clear(numbers);
            Console.WriteLine("3rd");
            foreach (var num in numbers)
            {

                Console.WriteLine(num);
            }

        }
        public void Twodim()
        {
            /*
            nums[0, 0] = 100;
            nums[0, 1] = 200;
            nums[1,0] = 300;
            nums[1, 1] = 400;
            */

            foreach (var num in nums)
            {

                Console.WriteLine(num);
            }
        }
        public void Ja()
        {
            int[][,] arr = new int[][,]
            {
                new int[,] {{1,2},{3,4}},
                new int[,] {{4,5},{5,6},{ 7, 8 } },
                new int[,] {{7,8,9},{8,9,10},{ 9, 10, 11 } },
                new int[,] {{ 9,10 },{10, 11 }, {11, 12 } },
            };
            /*foreach (var item in arr)
            {
                Console.WriteLine(item[1,1]);
            }*/
            for (int i = 0; i < arr.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < arr[i].GetLength(x); j++)
                {
                    for (int k = 0; k < arr[j].Rank; k++)
                    {
                        Console.Write(arr[i][j, k] + "");
                    }
                }
            }
        }
    }
}
