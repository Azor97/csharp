// Array se usa quando ja temos uma quantidade definida de elementos que vao compor esses agrupamento.
// Colecoes sao usadas quando nao tem quantidade definida.

int[] numeros = new int[] { 1, 2, 3, 4, 5 };
int num = numeros[0];
// Console.WriteLine(num);

int total = numeros.Length;
// Console.WriteLine(total);

List<int> listNumeros = new List<int>();
List<int> listaNums = new List<int>() { 1, 2, 3, 4, 5 };

int count = listaNums.Count;
listaNums.Add(6);
listaNums.Remove(3);

int numer = listaNums.ElementAt(0);
Console.WriteLine(numer);

listaNums.Clear();
// Console.WriteLine(count);

// foreach (int numero in listaNums)
//     Console.WriteLine(numero);


