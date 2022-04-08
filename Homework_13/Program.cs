using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string message;
        int messageLength;
        string symbol;
        string symbolFrame = "";

        Console.WriteLine("Введите слово:");
        message = Console.ReadLine();
        messageLength = message.Length;
        Console.WriteLine("Введите символ:");
        symbol = Console.ReadLine();

        for (int i = -1; i <= messageLength; i++)
        {
            symbolFrame += symbol;
        }
        Console.WriteLine(symbolFrame);
        Console.WriteLine(symbol + message + symbol);
        Console.WriteLine(symbolFrame);
    }
}