using System;
using System.Security.Cryptography;

namespace getAndSet
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Id cannot be negative !");
            }
            this._id = Id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetName(string Name) // or return string.IsNullOrEmpty(this._name) ? "Blank" : this._name -> Ternary operators (?, :)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Blank");
            }
           
                this._name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "Blank" : this._name;
        }

        public int GetPassMark()
        {
            return this._passMark;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student st = new Student();
            st.SetId(101);
            st.SetName("Sofiya");

            Console.WriteLine("Student Id = {0} " , st.GetId());
            Console.WriteLine("Student Name = {0} " , st.GetName());
            Console.WriteLine("Student Passing Marks = {0} " , st.GetPassMark());
        }
    }
}