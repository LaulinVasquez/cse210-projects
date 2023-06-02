using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.SetName("kevin");
        person1.SetLastName("vasquez");

        Console.WriteLine(person1.GetId());

        for (int i = 5; i > 0; i--)
        {
            Console.Write($".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }


        Professional person2 = new Professional();
        person2.SetName("laulin");
        person2.SetLastName("vasquez");
        person2.SetProfession("senior developer");
        person2.SetTime(3);

        Console.WriteLine(person2.GetBio());

    }
}

