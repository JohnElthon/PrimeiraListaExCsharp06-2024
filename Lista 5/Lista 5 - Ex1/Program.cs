// See https://aka.ms/new-console-template for more information
//O usuário entra com um número de 1 a 7 e o programa exibe o dia da semana correspondente.

int numero;

Console.Write("Digite um número de 1 a 7: ");
numero = int.Parse(Console.ReadLine());

switch(numero)
{
    case 1:
        Console.WriteLine("Hoje é Domingo.");
        break;

    case 2:
        Console.WriteLine("Hoje é Segunda-Feira.");
        break;

    case 3:
        Console.WriteLine("Hoje é Terça-Feira.");
        break;

    case 4:
        Console.WriteLine("Hoje é Quarta-Feira.");
        break;

    case 5:
        Console.WriteLine("Hoje é Quinta-Feira.");
        break;

    case 6:
        Console.WriteLine("Hoje é Sexta-Feira.");
        break;

    case 7:
        Console.WriteLine("Hoje é Sabado.");
        break;

    default:
        Console.WriteLine("Número Inválido");
        break;


}




