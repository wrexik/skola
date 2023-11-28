using System;
All:
Console.ForegroundColor = ConsoleColor.Black;
Console.Title = "Comparator";
Console.CursorSize = 10;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Napište kolik čísel chcete porovnat");
int i = 0;

int max = 0;



try
{

    int O = Convert.ToInt32(Console.ReadLine());
Loop:
    try
    {
        while (i < O)
        {
            Console.WriteLine("Napište číslo, které chcete porovnat");
            int C = Convert.ToInt32(Console.ReadLine());
            if (max < C)
                max = C;
            Console.Write("Nejvyssi cislo je "); Console.WriteLine(max);
            i = i + 1;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Napište platné číslo");
        goto Loop;
    }



}
catch

{
    Console.WriteLine("Napište platné číslo");
    goto All;


}
