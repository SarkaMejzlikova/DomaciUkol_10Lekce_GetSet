using DomaciUkol_10Lekce_GetSet;

Console.Write("Zadej jméno: ");
string j = Console.ReadLine();

Console.Write("Zadej příjmení: ");
string p = Console.ReadLine();

Console.Write("Zadej věk: ");
string vek = Console.ReadLine();
int v;

while (!Int32.TryParse(vek, out v))
{
    Console.WriteLine("Nezadal jsi číslo, zkus to znovu.");
    vek = Console.ReadLine();
}

Osoba osoba = new Osoba(jmeno: j, prijmeni: p, vek: v);

Console.WriteLine(osoba);