using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Vítejte v programu pro výpočet roční ztráty ceny vozu.");
        Console.WriteLine();
        Console.WriteLine("Prosím dodržujte pokyny programu, v opačném případě dojde k chybě!");
        Console.WriteLine();
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Pokud si přejete pokračovat, stiskněte ENTER!");

            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.Clear();

                Console.Write("Zadejte počet aut: ");
                int carCount = int.Parse(Console.ReadLine());

                string[] carNames = new string[carCount];
                decimal[] originalPrices = new decimal[carCount];
                decimal[] annualLossPercentages = new decimal[carCount];
                decimal[] annualServiceCosts = new decimal[carCount];
                decimal[] annualFuelCosts = new decimal[carCount];
                decimal[] totalLosses = new decimal[carCount];

                for (int i = 0; i < carCount; i++)
                {
                    Console.WriteLine($"\nAuto č. -> {i + 1}:");

                    Console.Write("Zadejte název vozu: ");
                    carNames[i] = Console.ReadLine();

                    Console.Write("Zadejte původní cenu vozu: ");
                    originalPrices[i] = decimal.Parse(Console.ReadLine());

                    Console.Write("Zadejte procentuální roční ztrátu ceny vozu: ");
                    annualLossPercentages[i] = decimal.Parse(Console.ReadLine());

                    Console.Write("Zadejte roční cenu za servis: ");
                    annualServiceCosts[i] = decimal.Parse(Console.ReadLine());

                    Console.Write("Zadejte roční cenu za benzín: ");
                    annualFuelCosts[i] = decimal.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                Console.WriteLine("\nRoční ztráta ceny vozu od roku 2025 do roku 2030:");
                Console.WriteLine(new string('-', 50));

                Console.Write("Rok".PadRight(15));
                foreach (var carName in carNames)
                {
                    Console.Write($"{carName.PadRight(15)}");
                }
                Console.WriteLine();

                for (int year = 2025; year <= 2030; year++)
                {
                    Console.Write($"{year}".PadRight(15));
                    for (int i = 0; i < carCount; i++)
                    {
                        decimal previousPrice = (year == 2025) ? originalPrices[i] : originalPrices[i] - originalPrices[i] * (annualLossPercentages[i] / 100);
                        decimal loss = previousPrice * (annualLossPercentages[i] / 100);
                        originalPrices[i] -= loss;
                        totalLosses[i] += loss;
                        Console.Write($"{totalLosses[i]:0.00}".PadRight(15));
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nCelková roční ztráta za každé auto od roku 2025 do roku 2030 (včetně benzínu a servisu):");
                Console.WriteLine(new string('-', 50));

                Console.Write("Rok".PadRight(15));
                foreach (var carName in carNames)
                {
                    Console.Write($"{carName.PadRight(15)}");
                }
                Console.WriteLine();

                decimal[] totalCosts = new decimal[carCount];
                for (int year = 2025; year <= 2030; year++)
                {
                    Console.Write($"{year}".PadRight(15));
                    for (int i = 0; i < carCount; i++)
                    {
                        totalCosts[i] += totalLosses[i] + annualServiceCosts[i] + annualFuelCosts[i];
                        Console.Write($"{totalCosts[i]:0.00}".PadRight(15));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Chyba! Nebylo stisknuto tlačítko ENTER.");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }
}
