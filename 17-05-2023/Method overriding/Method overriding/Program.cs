namespace Method_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Sum(10, 10);
            Sum(10, 20, 30);

            // Function Overloading
        }

        public static void Sum(int x, int y)
        {
            Console.WriteLine("Total is : {0}", x+y);
        }

        public static void Sum(int x, int y, int z)
        {
            Console.WriteLine("Total is : {0}", x + y + z);
        }
    }
}