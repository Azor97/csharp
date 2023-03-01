
//Queue = Fila em portugues
//FIFO = First In,Fist Out - Primeiro a entrar, primeiro a sair.

Queue<string> lista = new Queue<string>();
lista.Enqueue("Ola");
lista.Enqueue("Mundo!");
lista.Enqueue("Acabou a maldicao");

foreach (string palavra in lista)
    Console.WriteLine(palavra);

Console.WriteLine("------------------------");

string elem = lista.Dequeue(); //Sempre remove o primeiro elemento

foreach (string palavra in lista)
    Console.WriteLine(palavra);

Console.WriteLine("------------------------");

int total = lista.Count;
Console.WriteLine($"{total}, {lista.Peek()}");