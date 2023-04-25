using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finished");
        List<int> numbers = new List<int>();

        int user = -1;
        while (user != 0)
        {
            Console.Write("Enter a number: ");
            user = Convert.ToInt32(Console.ReadLine());
            numbers.Add(user);
            // This if statement is used to remove the "0"  stored from our list
            if (user == 0)
            {
                numbers.Remove(0);
            }
        }
        // sum is the method to get the total of my list
        int total = numbers.Sum();
        Console.WriteLine($"the sum is: {total}");
        // Compute the average of the numbers in the list.
        double averageList = numbers.Average();
        Console.WriteLine($"Average: {averageList}");
        // Get the largest number if the list using "max()" method
        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");

        // iterate in the list using a foreach
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}