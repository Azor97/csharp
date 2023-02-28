// See https://aka.ms/new-console-template for more information
/*
 switch (variavel)
    {
        case valor1:
            comando a ser executado;
            break;

        case valor2:
            comando a ser executado;
            break;

        default:
            comando a ser executado;
            break;
    }
 */

const string DIAS_31 = "Este mes tem 31 dias!";
const string DIAS_30 = "Este mes tem 30 dias!";
const string DIAS_28 = "Este mes tem 28 dias!";
const string MES_INVALIDO = "Este mes nao existe!";

Console.WriteLine("Escreva um mes: ");
string mes = Console.ReadLine();

switch (mes.ToUpper())
{
    case "JANEIRO":
    case "MARCO":
        Console.WriteLine(DIAS_31);
        break;

    case "FEVEREIRO":
        Console.WriteLine(DIAS_28);
        break;

    case "ABRIL":
        Console.WriteLine(DIAS_30);
        break;

    default:
        Console.WriteLine(MES_INVALIDO);
        break;
}