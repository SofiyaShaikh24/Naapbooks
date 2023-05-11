using System;

namespace Bank
{

    class bank
    {
        private static string acc_type;
        private static int balance;
        private static int amount;

        static void Main(string[] args)
        {
            //Program a = new();

            // Create size of array for user
            User[] cust = new User[3];
            int userCount = 0;

            // Bank Name Options
            Console.WriteLine("Select The Option : ");
            Console.WriteLine("[A] HDFC Bank");
            Console.WriteLine("[B] ICI Bank");
            Console.WriteLine("[C] SBI Bank");
            Console.WriteLine("");
            Console.WriteLine("Enter The Option :");
            string option = Console.ReadLine();
            string bname = "";
            switch (option)
            {
                case "A":
                    bname = "HDFC";
                    balance = 15000;
                    break;

                case "B":
                    bname = "ICI";
                    balance = 10000;
                    break;

                case "C":
                    bname = "SBI";
                    balance = 5000;
                    break;

                default:
                    Console.WriteLine("Invalid Choice !!");
                    return;
            }
            Console.WriteLine("Select The type of Account : ");
            Console.WriteLine("[A] Current Account ");
            Console.WriteLine("[B] Savings Account ");
            string type = Console.ReadLine();
            if (type == "A" || type == "a")
            {
                acc_type = "Current Account";
            }
            else if(type == "B" || type == "b")
            {
                acc_type = "Savings Account";
            }
            else
            {
                Console.WriteLine("Invalid Choice !");
            }
            // User details here
            Console.WriteLine("Enter Username : ");
            string uname = Console.ReadLine();
            Console.WriteLine("");

            User user = new User(uname, bname);
            cust[userCount] = user;
            userCount++;

            // Display Account Details

            Console.WriteLine("Account Created");
            Console.WriteLine("User Name : " + user.Uname);
            Console.WriteLine("Bank Name  : " + user.Bname);

            // Random bid
            Random num = new Random();
            int bid = num.Next();
            Console.WriteLine("Bank id : " + bid);
            Console.WriteLine("Account Type : " + acc_type);
            Console.WriteLine("Date & Time : " + user.Date);

            // Options here
            Console.WriteLine("");
            Console.WriteLine("Select the option : ");
            //Console.WriteLine("[a]. display the Details");
            Console.WriteLine("[a]. Edit Username");
            Console.WriteLine("[b]. Withdrawl");
            Console.WriteLine("[c]. Delete");
            Console.WriteLine("[d]. Exit");
            string dis = Console.ReadLine();

            switch (dis)
            {
                //case "a":
                //    Console.WriteLine("Username is : {0}", uname);
                //    Console.WriteLine("Bank ID is : {0}", bid);
                //    Console.WriteLine("Date and Time is : {0}", Date);
                //    break;

                case "a":
                    Console.WriteLine("Current Username is : " + user.Uname);
                    Console.WriteLine("Enter New Username : ");
                    string re_name = Console.ReadLine();

                    //---------------Error --------------
                    //user.Uname(re_name);
                    Console.WriteLine("New Username : " + user.Uname);
                    break;

                    case "b":
                    // Withdrawl
                    if (type == "A" || type == "a")
                    {
                        Console.WriteLine("Enter the Amount : ");
                        amount = Convert.ToInt32(Console.ReadLine());
                        if (amount > balance)
                        {
                            Console.WriteLine("Not have Enough Balance");
                        }

                        else
                        {
                            // Balance Calculation
                            balance = balance - amount;
                            Console.WriteLine("Available Balance is : " + balance);
                        }


                    }
                    else
                    {
                        Console.WriteLine("Can not Withdrawl from Saving Account !");
                    }
                    break;

                case "c":
                    for (int i = 0; i < userCount; i++)
                    {
                        if (cust[i].Uname == user.Uname)
                        {
                            for (int j = i; j < userCount; j++)
                            {
                                cust[j] = cust[j + 1];
                            }
                            cust[userCount - 1] = null;
                            userCount--;
                            Console.WriteLine("Account Delete");
                            break;
                        }
                    }
                    break;
                case "d":
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }

            //string Uname = "";
            //string Bname = "";
            //if (option == "A" || option == "a")
            //{
            //    string Bname = "HDFC Bank";
            //    Console.WriteLine("Bank Name : {0}", Bname);
            //}
            //else if (option == "B" || option == "b")
            //{
            //    string Bname = "ICI Bank";
            //    Console.WriteLine("Bank Name : {0}", Bname);
            //}
            //else if (option == "C" || option == "c")
            //{
            //    string Bname = "SBI Bank";
            //    Console.WriteLine("Bank Name : {0}", Bname);
            //}
            //else
            //{
            //    return;
            //}
            //DateTime date = new DateTime.Now;
            //DateTime Date = DateTime.Now;
            //Console.WriteLine();
            //Console.WriteLine("Date and Time is : {0}", Date);
            //Console.WriteLine();
        }
    }
    class User
    {
        private string uname;
        private string bname;
        private int bid;
        private DateTime date;
        private int balance;
        private string acc_type;
        private int amount;

        public User(string uname, string bname)
        {
            this.bname = bname;
            this.uname = uname;
            this.bid = bid;
            this.date = DateTime.Now;
            this.balance = balance;
            this.acc_type = acc_type;
        }
        //---Error----------
        public string Uname
        {
            get { return this.uname; }
            set { this.uname = value; }
        }
        public string Bname
        {
            get { return bname; }
            set { this.bname = value; }
        }
        public int Bid
        {
            get { return bid; }
            set { this.bid = value; }
            //Random num = new Random();
            //int bid = num.Next();

        }
        public DateTime Date
        {
            get { return date; }
        }

        public int Balance
        {
            get { return balance; }
            set { this.balance = value; }
        }
    }
}