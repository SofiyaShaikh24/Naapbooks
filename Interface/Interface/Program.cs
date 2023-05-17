using System;
namespace Interface
{
    
    interface ICustomer
    {
        void Iface1();
    }

    interface ICustomer2
    {
        void Iface2();
    }

    public class cust : ICustomer2
    {
        public void Iface1()
        {
            Console.WriteLine("Interface 1");
        }

        public void Iface2()
        {
            Console.WriteLine("Interface 2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            cust customer = new cust();
            customer.Iface1();
            customer.Iface2();
        }
    }
}