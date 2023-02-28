string frase = "O dia esta lindo!";


Console.WriteLine(frase.Substring(0, 5)); // Le a string ate uma parte selecionada

Console.WriteLine(frase.Replace("O dia", "O azor")); // Substitui uma parte da string

frase.Trim(); // Remove espacos vazios
frase.TrimEnd(); // Remove espacos vazios do final da string
frase.TrimStart(); // Remove espacos vazios do inicio da string

frase.Trim('!'); //Remove caractere.

string cpf = "345678900";
//Console.WriteLine(cpf.PadLeft(11, '1'));

string frase2 = frase + "Ensolarado"; //Concatenacao

//Console.WriteLine(frase2);

string frase3 = $"{frase} Ensolarado!"; // Interpolacao
Console.WriteLine(frase3);