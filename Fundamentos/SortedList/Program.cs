// See https://aka.ms/new-console-template for more information

SortedList<int, string> lista = new SortedList<int, string>();
lista.Add(4, "RJ");
lista.Add(1, "MG");
lista.Add(3, "SP");
lista.Add(2, "SC");

foreach(string estado in lista.Values)
Console.WriteLine(estado);

//Ordena baseado na chave
//Trabalha igual ao Dictionary