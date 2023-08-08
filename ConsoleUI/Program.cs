

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

string[] firstNames = new string[] { "Héctor", "Manuel", "Claudia", "Ricardo", "Nicolás" };
for (int i = 0; i < firstNames.Length; i++)
{
    Console.WriteLine(firstNames[i]);

}


List<string> lastNames = new List<string>();
lastNames.Add("Sandoval");
lastNames.Add("Landázuri");
lastNames.Add("Alvarado");
lastNames.Add("Lizárraga");

for (int i = 0; i < lastNames.Count; i++)
{
    Console.WriteLine(lastNames[i]);
}

Console.Write("Give me the list of Names: ");
string lista = Console.ReadLine();
string[] nombres = lista.Split(',');
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine($"Hola {nombres[i]}");
}

List<decimal> charges = new();

charges.Add(23.78M);
charges.Add(15.38M);
charges.Add(125M);
decimal total = 0;

for (int i = 0;i< charges.Count; i++)
{
    total+= charges[i];
}

Console.WriteLine($"Our total charge is {total}.");
