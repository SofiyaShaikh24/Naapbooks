
using System;
using System.Globalization;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr_1; // define
            arr_1 = new int[3]; // allocate
            arr_1[0] = 1;
            arr_1[1] = 2;   
            arr_1[2] = 3;
            for (int i = 0; i < arr_1.Length; i++)
            {
                Console.WriteLine(arr_1[i]);
            }

            // using for
            string[] arr_2;
            arr_2 = new string[3];
            arr_2[0] = "a";
            arr_2[1] = "b";
            arr_2[2] = "c";
            for (int i = 0; i < arr_2.Length; i++)
            {
                Console.WriteLine(arr_2[i]);
            }

            //using while
            string[] arr_3;
            arr_3 = new string[3] {"a", "b", "c"};
            int j = 0;
            while(j < arr_3.Length)
            {
                Console.WriteLine(arr_3.Length + j++);
            }

            // 2D Arrays
            string[,] arr_4 = new string[2,3] { { "a", "b", "c"}, {"d", "e", "f"} };
            Console.WriteLine("2d 0,0" + arr_4[0, 0]);
            Console.WriteLine("2d 1,1" + arr_4[1, 1]);
            Console.WriteLine("2d 2,2" + arr_4[2, 2]);
            Console.WriteLine("2d 3,3" + arr_4[3, 3]);
            Console.WriteLine("2d 1,3" + arr_4[1, 3]);

            // 3D Arrays
            int[,,] arr_5 = new int[1, 2, 3] { { { 2, 4, 5 }, { 6, 7, 8 } } };
            Console.WriteLine("3d 1,2,1" + arr_5[1,2,1]);

        }
    }
}