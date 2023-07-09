using System;

public class Comments
{
    public string _userName;
    public string _userComment;

    public void DisplayComments()
    {
        Console.WriteLine($"{_userName} - {_userComment}");
    }
}