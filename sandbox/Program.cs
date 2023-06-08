using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Person person1 = new Person();
        // person1.SetName("kevin");
        // person1.SetLastName("vasquez");

        // Console.WriteLine(person1.GetId());

        // // for (int i = 5; i > 0; i--)
        // // {
        // //     Console.Write("breathing: ");
        // //     Console.Write($"{i}");
        // //     Thread.Sleep(1000);
        // //     Console.Write("\b \b");
        // // }

        // // foreach(string s in animation)
        // // {
        // //     Console.Write(s);
        // //     Thread.Sleep(1000);
        // //     Console.Write("\b \b");
        // // }
        
        // List<string> animation = new List<string>();
        // animation.Add("|");
        // animation.Add("/");
        // animation.Add("-");
        // animation.Add("\\");
        // animation.Add("|");
        // animation.Add("/");
        // animation.Add("-");
        // animation.Add("\\");

        // int i = 0;
        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(10);
        // while (DateTime.Now < endTime)
        // {
        //     string s = animation[i];
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");

        //     i++;
        //     if (i >= animation.Count)
        //     {
        //         i=0;
        //     }
        // }

        // Professional person2 = new Professional();
        // person2.SetName("laulin");
        // person2.SetLastName("vasquez");
        // person2.SetProfession("senior developer");
        // person2.SetTime(3);

        // Console.WriteLine(person2.GetBio());
        string user = "";
        Console.WriteLine("Add something into a list:");
        do
        {
            List<string>item = new List<string>();
            user = Console.ReadLine();
            item.Add(user);

        }
        while (user != "stop");
    }
}

