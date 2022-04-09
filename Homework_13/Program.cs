using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string name;
        int nameLength;
        int addToLength = 1;
        string symbol;
        string symbolFrame = "";

        Console.WriteLine("Введите имя:");
        name = Console.ReadLine();
        nameLength = name.Length;
        Console.WriteLine("Введите символ:");
        symbol = Console.ReadLine();

        for (int i = 0; i <= nameLength + addToLength; i++)
        {
            symbolFrame += symbol;
        }

        Console.WriteLine(symbolFrame);
        Console.WriteLine(symbol + name + symbol);
        Console.WriteLine(symbolFrame);
    }
}