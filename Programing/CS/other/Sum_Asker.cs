using System;

class Program //Vše co je tu udává hodnotu objektu Program
{
    static void Main() //Návratový typ, který nevrací hodnotu
    {
        while (true) //Když pravda
        {
            int totalSum = 0; //Udání součtu

            do //Loop
            {
                Console.Write("Napište číslo: "); //Výzvání k napsání čísla
                if (int.TryParse(Console.ReadLine(), out int number)) //Když převedená řetězcová hodnota deklaruje proměnnou
                {
                    totalSum += number; //Součet výsledku a čísla
                    Console.WriteLine(totalSum); //Vypsání hodnoty
                }
                else //Jinak
                {
                    Console.WriteLine("Špatný vstup. Zadejte platné číslo"); //Chybová zpráva
                }

                Console.Write("Chcete pokračovat? (a/n): "); //Otázka zda chcete pokračovat
            } while (Console.ReadLine().Trim().ToLower() == "a"); //Loop pro čtení vstupu k otázce o pokračování

            Console.WriteLine($"Výsledek je : {totalSum}"); //Vypsání výsledku
            

            Console.Write("Chcete spočítat další příklad? (a/n): "); //Otázka zda chcete další příklad
            if (Console.ReadLine().Trim().ToLower() != "a") //Když Readline na otázku nahoře se bude rovnat a tak se zopakuje celý proces
            {
                break; //příkaz pro vystoupení z Loopu
            }
        }
    }
}
