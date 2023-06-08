using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Laurin Vasquez", "Multiplication");
        // Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Laurin Vasquez", "Multiplication", "Section 7.3", "8-19");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(" ");
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        WritingAssigment assigment3 = new WritingAssigment(name, "European history", "The Causes of World War II");
        Console.WriteLine(assigment3.GetSummary());
        Console.WriteLine(assigment3.GetWritingInformation());
    }
}