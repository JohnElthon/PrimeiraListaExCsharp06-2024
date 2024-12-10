// See https://aka.ms/new-console-template for more information
/*Elabore um programa, utilizando os operadores lógicos, que pergunte ao usuário se ele é pedestre ou motorista e realize, a partir da resposta, os seguintes casos: 
1° Caso: Se o usuário for um pedestre, o programa deve perguntar:

Se ele está na faixa de travessia de pedestres
Se o semáforo (sinal de trânsito) está vermelho para os carros
O programa deve mostrar na tela que o usuário pode atravessar a rua somente se as duas condições forem verdadeiras.

2° Caso: Se o usuário for um motorista, o programa deve perguntar:

Se ele está usando cinto de segurança
Se ele bebeu alguma bebida alcoólica
Se o semáforo (sinal de trânsito) está verde para os carros
O programa deve mostrar na tela que o usuário pode dirigir somente se ele não tiver consumido bebidas alcoólicas, estiver com cinto de segurança e o sinal estiver verde.*/

using System.ComponentModel.Design;

char resposta1, faixa, semaforoVermelho, semaforoVerde, cinto, bebida;



Console.Write("Você é Pedestre ou Motorista? (P ou M): ");
resposta1 = char.Parse(Console.ReadLine());

if (resposta1 == 'P' || resposta1 == 'p')

{

    Console.Write("Você está na Faixa de Pedestre? (s ou n): ");
    faixa = char.Parse(Console.ReadLine());
    Console.Write("O Semaforo está vermelho para carros? (s ou n): ");
    semaforoVermelho = char.Parse(Console.ReadLine());

    if (faixa == 's' && semaforoVermelho == 's')
    {
        Console.Write("Você pode Atravessar");
    }

    else if (faixa == 's' && semaforoVermelho == 'n')
    {
        Console.Write("Você não pode atravessar");
    }

    else if (faixa == 'n' && semaforoVermelho == 'n')
    {
        Console.Write("Você não pode Atravessar");
    }

    else if (faixa == 'n' && semaforoVermelho == 's')
    {
        Console.Write("Você não pode Atravessar");
    }
    else
    {
        Console.WriteLine("Letra inválida.");
    }
}


if (resposta1 == 'M' || resposta1 == 'm')
{
    Console.Write("Você está usando cinto de segurança? (s ou n): ");
    cinto = char.Parse(Console.ReadLine());

    Console.Write("Você bebeu alguma bebida alcoólica? (s ou n): ");
    bebida = char.Parse(Console.ReadLine());

    Console.Write("O semáforo (sinal de trânsito) está verde para os carros? (s ou n): ");
    semaforoVerde = char.Parse(Console.ReadLine());

    if (cinto == 's' && bebida == 'n' && semaforoVerde == 's')
    {
        Console.WriteLine("Você pode dirigir.");
    }
    else if (cinto == 'n' && bebida == 'n' && semaforoVerde == 'n')
    {
        Console.WriteLine("Você não pode dirigir.");
    }
    else if (cinto == 's' && bebida == 's' && semaforoVerde == 's')
    {
        Console.WriteLine("Você não pode dirigir.");
    }
    else if (cinto == 'n' && bebida == 's' && semaforoVerde == 'n')
    {
        Console.WriteLine("Você não pode dirigir.");
    }
    else
    {
        Console.WriteLine("Letra inválida.");
    }
}
