using System;
namespace Multicast_delegates
{

    public delegate void Sample();
    class Program
    {
        public static void SampleOne()
        {
            Console.WriteLine("Invoke Delegate");
        }

        public static void delegate1()
        {
            Console.WriteLine("Invoke del1");
        }
        public static void delegate2()
        {
            Console.WriteLine("Invoke del2");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Sample del = new Sample(SampleOne);
            //del();

            Sample del1, del2, del3;
            del1 = new Sample(delegate1);
            del2 = new Sample(delegate2);
            del3 = del1 + del2; // or del += delegate2 (-, -=, += also use)
            del3(); //  Multicast Delegates  - chaining multiple delicates
        }
    }
}