Dictionary<int, string> estados = new Dictionary<int, string>();
estados.Add(1, "MG");
estados.Add(2, "SP");
estados.Add(3, "PR");

if (!estados.ContainsKey(4))
{
    estados.Add(4, "SC");
}

foreach (string estado in estados.Values)
{
    // Console.WriteLine(estado);
}

string est = null; // Variavel nao tem valor

if (estados.TryGetValue(2, out est))
{
    Console.WriteLine(est);
}

