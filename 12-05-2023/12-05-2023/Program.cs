using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
//-----Calculation--- Switch Statement---

//Console.WriteLine("Enter 1st num : ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter 2nd num : ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Choose the operation (+, -, *, /) : ");
//string operation = Console.ReadLine();

//switch(operation)
//{
//    case "+":
//        var c = a + b;
//        Console.WriteLine("The Result is : " + c);
//        break;
//    case "-":
//        c = a - b;
//        Console.WriteLine("The Result is : " + c);
//        break;
//    case "*":
//        c = a * b;
//        Console.WriteLine("The Result is : " + c);
//        break;
//    case "/":
//        c = a / b;
//        Console.WriteLine("The Result is : " + c);
//        break;
//        default:
//        Console.WriteLine("Invalid input !");
//        break;
//}

//-----------------While and Do While------------------
//Console.WriteLine("do While");
//int i = 10;
//do
//{ 
//    Console.WriteLine(i);
//    i--;
//} while (i >= 0);

//--------------------------

//Console.WriteLine("While");
//int num = 20;

//do
//{
//    Console.Write(num);
//    num--;
//}
//while (num % 2 >= 0 );

// ------ Fibonacci using while------------
//int curr_num = 1;
//int old_num = 1;
//Console.WriteLine("Enter number : ");
//int limit = int.Parse(Console.ReadLine());
//while(curr_num <= limit)
//{
//    Console.Write(curr_num + " ");
//    int next_num = curr_num + old_num;
//    old_num = curr_num;
//    curr_num = next_num;
//}

//--- continue until quit-----
//const string QUIT = "quit";
//const string QUEST = "Enter Your Name or quit to exit : ";
//Console.WriteLine(QUEST);
//string name = Console.ReadLine();
//while(name != QUIT)
//{
//    Console.WriteLine("Hello, " + name);
//    Console.WriteLine(QUEST);
//    name = Console.ReadLine();
//}

// ------fOR lOOP ----------
//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//    i++;
//}

//--- even numbers using for loop ------

//for (int i = 1; i <= 20; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//        i++;

//    }
//}

// --- no divisile by 3---
//int num = 0;
//for (int i = 0; i <= 20; i++) //for (int i = 0; i <= 20; i += 3) Works same, doesn't need if condi.
//{
//    if (i % 3 == 0)
//    {
//        num += i;

//        i++;
//    }
//}
//Console.WriteLine(num);

//-----------Fibonacci using for loop-----------
//int next_num;
//for (int old_num = 0, curr_num = 1; curr_num <= 34; old_num = curr_num, curr_num = next_num)
//{
//    next_num = curr_num + old_num;
//    Console.WriteLine(next_num);
//}

// ------Multiplication Table -------

Console.WriteLine("Enter the no : ");
int i = int.Parse(Console.ReadLine());
int j;
for (j = 1; j <=10; j++)
{
    Console.WriteLine("{0} * {1} = {2}", i, j, i*j);
}