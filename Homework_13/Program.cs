using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string message;
        int messageLength;
        string symbol;

        Console.WriteLine("Введите слово:");
        message = Console.ReadLine();
        messageLength = message.Length;
        Console.WriteLine("Введите символ:");
        symbol = Console.ReadLine();

        for (int i = 0; i < messageLength + 2; i++)
        {
            Console.Write(symbol);
        }

        Console.WriteLine($"\n{symbol}{message}{symbol}");

        for (int i = 0; i < messageLength + 2; i++)
        {
            Console.Write(symbol);
        }
    }
}