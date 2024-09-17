using System.Xml;

namespace git;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this super awsome game!");
        Console.WriteLine("Choose a nickname:");
        string userNickname = Console.ReadLine();
        Console.WriteLine($"Welcome {userNickname}!");
    }
}