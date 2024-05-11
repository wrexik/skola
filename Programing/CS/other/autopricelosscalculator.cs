using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vítejte v programu pro výpoèet roèní ztráty ceny vozu.");
        Console.WriteLine(new string('-', 50));

        Console.Write("Zadejte název vozu: ");
        string name = Console.ReadLine();

        Console.Write("Zadejte rok koupì vozu: ");
        int purchaseYear = int.Parse(Console.ReadLine());

        Console.Write("Zadejte pùvodní cenu vozu: ");
        decimal originalPrice = int.Parse(Console.ReadLine());

        Console.Write("Zadejte procentuální roèní ztrátu ceny vozu: ");
        decimal annualLossPercentage = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nProcentuální ztráta ceny vozu {name} od roku koupì do roku 2030:");
        Console.WriteLine(new string('-', 50));

        decimal currentPrice = originalPrice;
        for (int year = purchaseYear; year <= 2030; year++)
        {
            Console.WriteLine($"Rok {year}: {currentPrice:C2}");
            currentPrice -= currentPrice * (annualLossPercentage / 100);
        }

        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"Koneèná cena vozu {name} v roce 2030: {currentPrice:C2}");
    }
}
