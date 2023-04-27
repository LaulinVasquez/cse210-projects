using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int Square= SquareNumber(number);
        DisplayResult(name,Square);
    }
    // this function doesn't return anything, therefore is just needed to display a message.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    // This function needs to be declared in order to return a value or variable in this case the function was 
    // declare as a string

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    // This function return an int number, you declare your function as "int" in order to use the return
    // Your function will know what return
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        return number;
    }
    // This function takes a prompt number from previous function and return it squared
    static int SquareNumber(int number)
    {
        int number1 = number * number;

        return number1;
    }
    // This function just desplay tqo differents variable in the terminal it doesn't return anything
    static void DisplayResult(string name, int Square)
    {
        Console.WriteLine($"{name}, the square of your number is: {Square}");
    }
}