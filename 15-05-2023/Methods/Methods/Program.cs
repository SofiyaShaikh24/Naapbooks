namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int Sum = 0;
            int Multiply = 0;
            Calculate(5,10, out Sum, out Multiply);

            Console.WriteLine("sum = {0} , Product = {1} ", Sum, Multiply);
        }

        //using out Parameter
        public static void Calculate(int x, int y, out int Add, out int Multiply)
        {
            Add = x + y;
            Multiply = x * y;
        }

    }
}