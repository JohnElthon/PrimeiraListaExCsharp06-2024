// See https://aka.ms/new-console-template for more information
//Ler um número inteiro e escrever se ele é positivo ou negativo.

int numero;

Console.Write("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine());

if (numero > 0){
   
    Console.Write("O número é Positivo.");
}

else {
    Console.Write("O número é Negativo");

}
