using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            StreamReader stream = null;
            try
            { 
            Console.WriteLine("Hello, World!");
            stream = new StreamReader(@"C:\Users\NBDPDL0038\Desktop\Sof\d2.txt");
            Console.WriteLine(stream.ReadToEnd());
           
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File Does not Exist !");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                stream.Close();
                Console.WriteLine("Reach Final Block !");
            }
            }
    }
}