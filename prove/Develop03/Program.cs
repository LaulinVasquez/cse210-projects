using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs",3,5,6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine cown understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        
        Scripture scripture = new Scripture(reference.multipleVerses(), text);
        scripture.getRenderText(); 
        Console.WriteLine(" ");

        // Close the program if all words are hidden
        bool allWordsHidden = false;

        do
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish: ");

            string user = Console.ReadLine();

            if (user == "quit")
            {
                break;
            }
            else if (user == "")
            {
                scripture.hideWords();
                allWordsHidden = scripture.completelyHidden();
            }
        }
        while (!allWordsHidden);

        if (allWordsHidden)
        {
            Console.WriteLine("\n All words are hidden, did you already memorize all words in the scripture??");
        }
    }        
}
