using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("V�tejte v programu pro v�po�et ro�n� ztr�ty ceny vozu.");
        Console.WriteLine(new string('-', 50));

        Console.Write("Zadejte n�zev vozu: ");
        string name = Console.ReadLine();

        Console.Write("Zadejte rok koup� vozu: ");
        int purchaseYear = int.Parse(Console.ReadLine());

        Console.Write("Zadejte p�vodn� cenu vozu: ");
        decimal originalPrice = int.Parse(Console.ReadLine());

        Console.Write("Zadejte procentu�ln� ro�n� ztr�tu ceny vozu: ");
        decimal annualLossPercentage = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nProcentu�ln� ztr�ta ceny vozu {name} od roku koup� do roku 2030:");
        Console.WriteLine(new string('-', 50));

        decimal currentPrice = originalPrice;
        for (int year = purchaseYear; year <= 2030; year++)
        {
            Console.WriteLine($"Rok {year}: {currentPrice:C2}");
            currentPrice -= currentPrice * (annualLossPercentage / 100);
        }

        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"Kone�n� cena vozu {name} v roce 2030: {currentPrice:C2}");
    }
}
