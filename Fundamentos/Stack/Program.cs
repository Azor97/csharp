// See https://aka.ms/new-console-template for more information

Stack<string> lista = new Stack<string>();
lista.Push("Ola");
lista.Push("Pessoal");
lista.Push("Do Whatsapp");

foreach (string palavra in lista)
    Console.WriteLine(palavra);

Console.WriteLine("___________________");

Console.WriteLine(lista.Pop());

Console.WriteLine("___________________");

Console.WriteLine(lista.Peek());

int total = lista.Count;


// Stack e Queue
// • Mesmo comportamento
// • Diferenca na ordenacao e saida dos elementos
// • Queue => FIFO - Primeiro a entrar, primeiro a sair - FILA
// • Stack => LIFO - Ultimo a entrar, primeiro a sair - PILHA