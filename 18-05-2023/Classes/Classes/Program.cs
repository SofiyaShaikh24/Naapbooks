using System;
namespace Classes
{
   
    interface IA
    {
        void APrint();
    }

    class A : IA
    {
        public void APrint()
        {
            Console.WriteLine("Interface A");
        }
    }

    interface IB
    {
        void BPrint();
    }

    class B : IB
    {
        public void BPrint()
        {
            Console.WriteLine("Interface B");
        }
    }


    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void APrint()
        {
            a.APrint();
        }
        public void BPrint()
        {
            b.BPrint();
        }
    }
    
    //--------------------------------
    
    public abstract class Abstract
    {
        public abstract void Message(); // not mendatory to make it abstract
    }
    
    public class Program : Abstract
    {
        
        public override void Message()
        {
            Console.WriteLine("Abstract Class");
        }

        static void Main(string[] args)
        {
            Abstract a = new Program(); // cannot create instance of abstract class
            a.Message();

            //-----------------
            AB ab = new AB();
            ab.APrint();
            ab.BPrint();
        }

       

        
    }
}