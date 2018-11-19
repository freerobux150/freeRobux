using System;
using System.Text;
					
public class Program
{
	public static void Main()
	{
    string robux;
    string userPassword;
    string response;
	Console.Write("Congratulations! You have been selected out of 1 billion people to receive as much free robux as you want! How much would you like?");
    robux = Console.ReadLine();
    Console.Write("Oops! Our servers aren't functioning properly- to get your free robux, input your roblox username and password!");
    userPassword = Console.ReadLine();
    Console.Write("To confirm- your credentials are " + userPassword + "and you are wishing to receive " + robux + "- correct?");
    response = Console.ReadLine();
    if (response == "yes") 
    {
        Console.WriteLine("You will be receiving your robux shortly! ;)");
    } else 
    {
        Console.WriteLine("It looks like our re-confirmation servers aren't working - credentials were sent anyway. We apologize for any inconvenices, and if you did send the correct credentials you will be receiving your free robux soon! ;)");
    }
	}
}
