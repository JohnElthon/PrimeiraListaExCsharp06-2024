// See https://aka.ms/new-console-template for more information

double numero;

Console.Write("Digite um Número Inteiro: ");
numero = double.Parse(Console.ReadLine());

if (numero % 2 == 0){
    Console.Write("O número: {0} é par.", numero);
}

else
{
    Console.Write("O número: {0} é ímpar.", numero);
}