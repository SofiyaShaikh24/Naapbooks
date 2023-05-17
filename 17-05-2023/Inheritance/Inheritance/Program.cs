using System;
using System.Reflection.Metadata.Ecma335;

namespace Inheritance
{
    public class Student
    {
        public string fname = "abc";
        public string lname = "xyz";
        public int roll_no;

        public virtual void PrintDetails() // any derived class can override the method
        {
            Console.WriteLine("First Name : {0} , Last Name = {1}", fname, lname);
        }

        // Constructor OverLoading
        public Student()
        {
            Console.WriteLine("No Parameters Constructor");
        }

        public Student(string Msg)
        {
            Console.WriteLine(Msg);
        }
    }

  
    public class RegularStudent : Student         // Inheritance
    {
        public int Fees;
    }

    public class RTEStudent : Student
    {
        public int Fees;
        //public new void PrintDetails() // new keyword for hide base class member    
        //{
        //    Console.WriteLine("First Name : {0} , Last Name = {1}", fname, lname + " - RTE"); // Data hiding Method
        //}

        // OR ----^
        //Polymorphism - invoke derivied class using base class at run time
        public override void PrintDetails()  
        {
          Console.WriteLine("First Name : {0} , Last Name = {1}", fname, lname + " - RTE"); // Data hiding Method
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //RegularStudent rst = new RegularStudent();
            //rst.fname = "Sof";
            //rst.lname = "Shaikh";
            //rst.Fees = 10000;
            //rst.PrintDetails();

            
            //RTEStudent gst = new RTEStudent();
            //gst.fname = "abc";
            //gst.lname = "xyz";
            //gst.Fees = 1000;
            //gst.PrintDetails();


            // Or--^--
            Student[] st = new Student[3]; // Student Array

            st[0] = new Student();
            st[1] = new RegularStudent();
            st[2] = new RTEStudent();

            foreach(Student s in st)
            {
                s.PrintDetails();
            }

        }
    }
}