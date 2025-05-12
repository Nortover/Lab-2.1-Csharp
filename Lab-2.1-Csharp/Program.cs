using System;
using StringLibrary;

class Program
{
    static void Main(string[] args)
    {
        // Демонстрація роботи з базовим класом
        Console.WriteLine("Введiть рядок:");

        StringBase baseString = new StringBase(Console.ReadLine());

        Console.WriteLine($"Рядок: {baseString.Value}");

        Console.WriteLine($"Довжина рядка: {baseString.CalculateLength()}");

        // Демонстрація роботи з похідним класом
        Console.WriteLine("Введiть рядок з символом '-'");
        NumericString numString = new NumericString(Console.ReadLine());
        Console.WriteLine($"Початковий рядок: {numString.GetStringValue()}");
        Console.WriteLine($"Довжина рядка: {numString.CalculateLength()}");

        // Видаляємо дефіси
        numString.RemoveCharacter('-');
        Console.WriteLine($"Рядок пiсля видалення '-': {numString.GetStringValue()}");
        Console.WriteLine($"Довжина рядка пiсля змiн: {numString.CalculateLength()}");

    }
}