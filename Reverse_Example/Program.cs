// See https://aka.ms/new-console-template for more information
using Reverse_Example;
Revers rever = new Revers();
Console.WriteLine("Enter Input");
string input = Console.ReadLine();
if(input != "")
{
    try
    {
        rever.rev(input);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
else
{
    Console.WriteLine("invalid input data");
}