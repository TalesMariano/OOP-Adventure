Console.WriteLine("Hello, what is your name?");

var name = Console.ReadLine();

if (name == String.Empty)
{
    name = "Unknown";
}

Console.WriteLine("Welcome {0} to your OOP adventure!", name);