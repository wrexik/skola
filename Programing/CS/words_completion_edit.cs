// © Diktátor a spol. s.r.o.

// Seznam slov pro našeptávač
string[] wordlist = new string[] { "mokry", "maso", "mlynar", "maso", "makaron", "masozravy" };

// Převod slov ze seznamu na pole (není třeba v tomto případě)
string[] wordsarray = wordlist;

// Zadání klíčových slov pro vyhledávání
Console.WriteLine("Zadejte klicova pismena pro zahajeni vyhledavani naseptavace mezi slovy");
string input = Console.ReadLine();

// While smyčka pro opakované hledání slov
while (true)
{
    if (!string.IsNullOrEmpty(input))
    {
        // Procházení pole slov a hledání shody s vstupem
        for (int i = 0; i < wordsarray.Length; i++)
        {
            string word = wordsarray[i];
            if (word.StartsWith(input))
            {
                Console.WriteLine("Nalezené slovo: " + word);
            }
        }
    }

    // Otázka pro pokračování ve vyhledávání
    Console.WriteLine("Chcete pokracovat ve vyhledavani (ano/ne)?");
    string response = Console.ReadLine();

    // Odpověď "ne" ukončí smyčku
    if (response == "ne")
    {
        Console.WriteLine("Vyhledavani naseptavace bylo ukonceno");
        break;
    }
    // Odpověď "ano" -> další zadání klíčových slov
    else if (response == "ano")
    {
        Console.WriteLine("Zadejte klicova pismena pro zahajeni vyhledavani naseptavace mezi slovy");
        input = Console.ReadLine();
    }
    // Neplatná odpověď
    else
    {
        Console.WriteLine("Neplatná odpověď. Zadejte 'ano' nebo 'ne'.");
        input = ""; // Nastavení inputu na prázdný řetězec pro znovu zadání klíčových slov v řádku 11
    }
}
