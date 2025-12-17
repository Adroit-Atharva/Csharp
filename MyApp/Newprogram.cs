// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // String? name;
        // Console.WriteLine("Enter your name:\n");
        // name = Console.ReadLine();
        // Console.WriteLine("Hello " + name + "!");
        // int c = 321;
        // String c_str = Convert.ToString(c);
        // Console.WriteLine("The integer " + c + " as a string is: " + c_str);
        // Console.WriteLine("The type of " + c_str + " is: " + c_str.GetType());
        
        // int a;
        // Console.WriteLine("Enter a number:\n");
        // a = Convert.ToInt32(Console.ReadLine());
        // int b;
        // Console.WriteLine("Enter another number:\n");
        // b = Convert.ToInt32(Console.ReadLine());
        // int sum = a + b;
        // Console.WriteLine("The sum of " + a + " and " + b + " is " + sum + ".");
        // int power = Convert.ToInt32(Math.Pow(a, b)); //power function returns double so typecasting to int
        // Console.WriteLine(a + " raised to the power of " + b + " is " + power + ".");

        
	int randomnum = new Random().Next(1,1000);
	int guess;
        Console.WriteLine("Guess a number between 1 and 1000:\n");
        do
        {
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < randomnum)
            {        
                Console.WriteLine("Too low! Try again:\n");
            }
            else if (guess > randomnum)
            {
                Console.WriteLine("Too high! Try again:\n");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number " + randomnum + " correctly!");
            }
        }while (guess != randomnum);
	

	/*    
	String fullname = "Atharva Birajdar";
	String firstname = fullname.Substring(0,7);
	String lastname = fullname.Substring(7,9);
	String capname = fullname.ToUpper();
	String smallname = fullname.ToLower();
	Console.WriteLine("My last name is " + lastname);
	Console.WriteLine("My first name is " + firstname);
	Console.WriteLine("small name is " + smallname);
	Console.WriteLine("name is " + fullname);
	Console.WriteLine("name in capital is " + capname);
    	*/

	/*
	int[] arr = {1,2,3};
	List<int> rollnos = new List<int>(); //like vector<int> [variablename] in cpp basically a dynamic array
	rollnos.Add(100);
	rollnos.Add(200);


	LinkedList<int> ll = new LinkedList<int>();

	ll.AddFirst(10);
	Console.WriteLine("Right now list contains: ");
	foreach (int x in ll){
		Console.Write(x + "\t");
	}
	ll.AddFirst(20);
	Console.WriteLine("Right now list contains: ");
	foreach (int x in ll){
		Console.Write(x + "\t");
	}
	Console.WriteLine("My roll number is " + rollnos[0]);
	Console.WriteLine(arr[0]);


	Dictionary<String, int> records = new Dictionary<String, int>();
	records["Atharva"] = 100;
	Console.WriteLine("The rollno of Atharva is " + records["Atharva"]);
	*/
	
	}
}
