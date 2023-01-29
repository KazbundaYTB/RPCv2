string Kamen = "K";
string Nuzky = "N";
string Papir = "P";
Start:
Console.WriteLine("Vitejte ve hře: Kámen, Nůžky, Papír");
string input = Console.ReadLine();

Random PC_OUT = new Random();
int PC_OUT1 = PC_OUT.Next(0,2);
//0 = kamen
//1 = nuzky
//2 = papir
if (PC_OUT1 == 0) {
    if (input.Contains(Kamen))
    {
        Console.WriteLine("Remiza!");
    }
    else if (input.Contains(Nuzky))
    {
        Console.WriteLine("Prohra!");
    } 
    else if (input.Contains(Papir)) {
        Console.WriteLine("Vyhra!");
    }

}
//0 = kamen
//1 = nuzky
//2 = papir
if (PC_OUT1 == 1)
{
    if (input.Contains(Kamen))
    {
        Console.WriteLine("Vyhra");
    }
    else if (input.Contains(Nuzky))
    {
        Console.WriteLine("Remiza");
    }
    else if (input.Contains(Papir))
    {
        Console.WriteLine("Prohra!");
    }

}
//0 = kamen
//1 = nuzky
//2 = papir
if (PC_OUT1 == 2)
{
    if (input.Contains(Kamen))
    {
        Console.WriteLine("Prohra");
    }
    else if (input.Contains(Nuzky))
    {
        Console.WriteLine("Vyhra");
    }
    else if (input.Contains(Papir))
    {
        Console.WriteLine("Remiza!");
    }

}
//Unknow input
if (!input.Contains(Kamen) || input.Contains(Nuzky) || input.Contains(Papir))
{
    Console.WriteLine("Zadal jste neplatný vstup! \n Přesouvám na začátek!");
    goto Start;
}
//Continue?
Console.WriteLine("Chcete pokračovat?");
string Continue = Console.ReadLine().ToLower();
if (Continue == "ano")
{
    goto Start;
}
else if (Continue == "ne") {
    Console.WriteLine("Děkujeme za zahrání!");
}
