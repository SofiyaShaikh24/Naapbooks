using System;
namespace _15_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            //Operation o = Multiply;
            //o = Divide;

            //Console.WriteLine(o(20, 10));
            //Print(10, 2, Multiply);
            Print(5, 2, (x, y) => x * y);
            Print(5, 2, (x, y) => x + y); 
        }
    

    delegate int Operation(int a, int b);

        // Type Parameter
    delegate T Operation<T>(T a, T b);

    static void Print(int x, int y, Operation o)
        {
            var ans = o(x, y);
            Console.WriteLine(ans);
        }
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int c, int d)
    {
        return c / d;
    }
    }
}