using System.Security.Authentication.ExtendedProtection;

string[] words = new string[10]; // zacne list s velikosti 10

while (true) { // loop

    Console.WriteLine("Kde chcete změnit písmeno?");
    int num_list = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Co to bude za písmeno?");
    string num_change = Console.ReadLine();

    words[Convert.ToUInt32(num_list)] = num_change; // prida moznosti na dane pole do listu

    Console.WriteLine("Uspesne zmeneno: {0} na {1}", num_list, words[Convert.ToUInt32(num_list)]);

    Console.WriteLine("Chcete pokracovat?");
    string pokracovat = Console.ReadLine(); // prompt na opakovani / nove hodnoty

    if (pokracovat == "ne") {

        Console.WriteLine(" ");
        int i = 0;

        foreach (string word in words) // vypis vsech radku v poli + cislo
        { 
           i = i + 1;
           Console.Write(i);
           Console.Write(" ");
           Console.WriteLine(word);
        }
        break; // ne == konec
    }

}

//done EZ
