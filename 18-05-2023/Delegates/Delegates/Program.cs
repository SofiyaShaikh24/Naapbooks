using System;
using System.Collections.Generic;
namespace Delegates
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public static void PassStudent(List<Student> StudentList, IsPass IsPassExam) // pass delegate sa Parameter
         {
            foreach (Student Student in StudentList)
            {
                if (IsPassExam(Student))
                {
                    Console.WriteLine(Student.Name  + " is Fail");
                }
            }
        }
    }
    public delegate void Fun_delegate(string Msg); // delegate holds refrence to a function

    delegate bool IsPass(Student std); // dalegate for student class

    class Program
    {
       
        public static void Del_Fun(string Msg)
        {
            Console.WriteLine(Msg);
        }

        public static void Main(string[] args)
        {
            Fun_delegate a = new Fun_delegate(Del_Fun); // type safe : function & delegate signature must be same
            a("Delegates");

            //-------------------------------
            List<Student> st = new List<Student>();
            st.Add(new Student() { Id = 1, Name = "Sof", Marks = 50});
            st.Add(new Student() { Id = 2, Name = "a", Marks = 35});
            st.Add(new Student() { Id = 3, Name = "b", Marks = 20});

            Student.PassStudent(st, stu => stu.Marks <= 35);

            //--or---
            //IsPass isPass = new IsPass(Pass);
            //Student.PassStudent(st, isPass); // delegete isPass points to pass function
        }
        // static - no need the instance of class to invoke 
        //public static bool Pass(Student stu) // Pass function returns true or false  
        //{
        //    if (stu.Marks <= 35)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }    
        //}
        
        
    }
}