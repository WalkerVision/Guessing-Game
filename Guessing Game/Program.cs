using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the guessing game.");
        Console.WriteLine("Pick a number from 1 to 3");
        String userchoice = Console.ReadLine();

        while (userchoice != "1" && userchoice != "2" && userchoice != "3")
        {
            Console.WriteLine("Invaild choice please eenter 1,2,or 3");
            userchoice = Console.ReadLine();
        }
    }
}