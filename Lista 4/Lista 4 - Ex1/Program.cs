// See https://aka.ms/new-console-template for more information
/*Construa um algoritmo que leia o valor de uma conta de luz (CL) e,
  caso o valor seja maior que R$ 50,00 apresente a mensagem: “Você está gastando muito”.
  Caso contrário exiba a mensagem: “Seu gasto foi normal”.*/

double Valor;

Console.Write("Digite o Valor da Sua Conta de Luz: ");
Valor = double.Parse(Console.ReadLine());

if (Valor > 50.00){

    Console.Write("Você está Gastando Muito.");
}


else {
    Console.Write("Seu Gasto foi normal!");
}

