using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Výpis uvítací zprávy a oddělovací čáry
        Console.WriteLine("Vítejte v programu pro výpočet roční ztráty ceny vozu.");
        Console.WriteLine(new string('-', 50));

        // Vytvoření seznamu pro uchování informací o vozech
        List<Car> cars = new List<Car>();

        // Cyklus pro zadávání informací o vozech
        while (true)
        {
            // Zadání názvu vozu nebo ukončení zadávání
            Console.Write("Zadejte název vozu (nebo 'konec' pro ukončení zadávání): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "konec") break;

            // Zadání původní ceny vozu
            Console.Write("Zadejte původní cenu vozu: ");
            decimal originalPrice = decimal.Parse(Console.ReadLine());

            // Zadání procentuální roční ztráty ceny vozu
            Console.Write("Zadejte procentuální roční ztrátu ceny vozu: ");
            decimal annualLossPercentage = decimal.Parse(Console.ReadLine());

            // Přidání vozu do seznamu
            cars.Add(new Car { Name = name, PurchaseYear = 2025, OriginalPrice = originalPrice, AnnualLossPercentage = annualLossPercentage });
        }

        // Výpis hlavičky pro výsledky
        Console.WriteLine("\nProcentuální ztráta ceny vozu od roku 2025 do roku 2030:");
        Console.WriteLine(new string('-', 50));

        // Výpis názvů vozů
        Console.Write("Rok".PadRight(15));
        foreach (var car in cars)
        {
            Console.Write($"{car.Name.PadRight(15)}");
        }
        Console.WriteLine();

        // Výpis cen pro každý rok
        for (int year = 2025; year <= 2030; year++)
        {
            Console.Write($"{year}".PadRight(15));
            foreach (var car in cars)
            {
                // Výpočet ceny vozu pro daný rok
                decimal currentPrice = car.OriginalPrice;
                for (int y = car.PurchaseYear; y < year; y++)
                {
                    currentPrice -= currentPrice * (car.AnnualLossPercentage / 100);
                }
                // Výpis ceny vozu
                Console.Write($"{currentPrice:0.00}".PadRight(15));
            }
            Console.WriteLine();
        }
    }
}

// Třída pro uchování informací o voze
class Car
{
    public string Name { get; set; } // Název vozu
    public int PurchaseYear { get; set; } // Rok koupě vozu
    public decimal OriginalPrice { get; set; } // Původní cena vozu
    public decimal AnnualLossPercentage { get; set; } // Procentuální roční ztráta ceny vozu
}
