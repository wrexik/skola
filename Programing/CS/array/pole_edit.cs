All:
try
{
    Console.WriteLine("Zadejte počet políček v poli");
    int p = Convert.ToInt32(Console.ReadLine());
    p = p + 1;
    string[] words = new string[p]; // zacne list s velikosti zadane cislo


    while (true)    // loop
    {
        try
        {
            Console.WriteLine("Na jaké pozici chcete změnit písmeno?");
            int num_list = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Co to bude za písmeno?");
            string num_change = Console.ReadLine();

            words[Convert.ToUInt32(num_list)] = num_change; // prida moznosti na dane pole do listu

            Console.WriteLine("Uspesne zmeneno: {0} na {1}", num_list, words[Convert.ToUInt32(num_list)]);

            Console.WriteLine("Chcete pokracovat?");
            string pokracovat = Console.ReadLine(); // prompt na opakovani / nove hodnoty

            if (pokracovat == "ne")
            {
                Console.Write(" ");
                int i = -1;

                foreach (string word in words) // vypis vsech radku v poli + cislo
                {
                    i = i + 1;
                    Console.Write(i);
                    Console.Write(" ");
                    Console.WriteLine(word);
                }
                break;  // ne == konec
            }
        }
        catch
        {
            Console.WriteLine("Špatný vstup");
        }

    }
}
catch (Exception)
{

    Console.WriteLine("Špatný vstup");
    Console.WriteLine("");
    goto All;
}

//done EZ
