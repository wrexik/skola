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

        break; // ne == konec
    }

}

//done EZ
