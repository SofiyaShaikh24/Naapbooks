using System;

namespace Bank
{

    class bank
    {
        static void Main(string[] args)
        {
            var users = new User[10];
            var key = "";
            do
            {
                Functionality userChoice = Functionality.Exit;
                Console.WriteLine("Enter the followig for required Task : ");
                Console.WriteLine("[1] Registeration ");
                Console.WriteLine("[2] Display Details ");
                Console.WriteLine("[3] Edit Username ");
                Console.WriteLine("[4] Delete User ");
                Console.WriteLine("[5] Exit ");

                //console pre
                switch (userChoice)
                {
                    case Functionality.Register:
                        break;
                    case Functionality.Read:
                        break;
                    case Functionality.Edit:
                        break;
                    case Functionality.Delete:
                        break;
                    default:
                        break;
                }

            } while (key.Equals("n"));

        }
    }

    public class User
    {
        public int BankId { get; set; }
        public string UserName { get; set; }
        public DateTime RegisterDate { get; set; }

        public BankType Bank { get; set; }
    }

    public enum BankType
    {
        HDFC,
        ICICI,
        SBI
    }

    public enum Functionality
    {
        Register,
        Read,
        Edit,
        Delete,
        Exit
    }
}