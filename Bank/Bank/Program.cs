using System;
namespace Bank
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //Program a = new();
            string Uname = "";
            Console.WriteLine("Enter Username : ");
            string uname = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Select The Option : ");
            Console.WriteLine("[A] HDFC Bank");
            Console.WriteLine("[B] ICI Bank");
            Console.WriteLine("[C] SBI Bank");
            Console.WriteLine("");
            Console.WriteLine("Enter The Option :");


            string option = Console.ReadLine();
            //string Bname = "";
            if (option == "A" || option == "a")
            {
                string Bname = "HDFC Bank";
                Console.WriteLine("Bank Name : {0}", Bname);

            }
            else if (option == "B" || option == "b")
            {
                string Bname = "ICI Bank";
                Console.WriteLine("Bank Name : {0}", Bname);

            }
            else if (option == "C" || option == "c")
            {
                string Bname = "SBI Bank";
                Console.WriteLine("Bank Name : {0}", Bname);

            }
            else
            {
                return;
            }

            // Bank ID
            Console.WriteLine();
            Random num = new Random();
            int bid = num.Next();
            Console.WriteLine("Bank Id is: {0} ", bid);
            

            // Date & Time
            //DateTime date = new DateTime.Now;
            DateTime Date = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine("Date and Time is : {0}", Date);
            Console.WriteLine();
            Console.WriteLine("Select the option : ");
            Console.WriteLine("[a]. display the Details");
            Console.WriteLine("[b]. Edit Username");
            Console.WriteLine("[c]. Delete");
            Console.WriteLine("[d]. Exit");
            string dis = Console.ReadLine();
            switch (dis)
            {
                case "a":
                    Console.WriteLine("Username is : {0}", uname);
                    Console.WriteLine("Bank ID is : {0}", bid);
                    Console.WriteLine("Date and Time is : {0}", Date);
                    break;

                case "b":
                    Console.WriteLine("Current Username is : {0} ", uname);
                    Console.WriteLine("Enter New Username : ");
                    Console.ReadLine();
                    Console.WriteLine("New Username is ");
                    break;

                case "c":
                    break;
                case "d":
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
                    
            }
            
        }

        private string uname;
        private string bname;
        private int bid;
        //private string date;

        public string Uname
        {
            get { return this.uname; }
            set { this.uname = value; }
        }
        public string Bname
        {
            get { return this.bname; }
            set { this.bname = value; }
        }
        public int Bid
        {
            get { return this.bid; }
            set { this.bid = value; }
        }
        
        public static void bankId(int n1, int n2, int n3)
        {

        }

        
    }
}