// See https://aka.ms/new-console-template for more information
/*Construa um algoritmo que leia dois números (A e B). Caso A seja igual a B, apresentar a soma dos dois.
Caso um seja maior que o outro, apresentar a diferença entre os dois números
(sempre lembrando que a diferença entre dois números é SEMPRE positiva).*/

using System.ComponentModel.Design;

double numA, numB, resultado;

Console.Write("Digite o Primeiro Número: ");
numA = double.Parse(Console.ReadLine());

Console.Write("Digite o Segundo Número: ");
numB = double.Parse(Console.ReadLine());

if (numA == numB) {
    resultado = numA + numB;

    Console.Write("Os números são iguais a soma deles é: {0}", resultado);
}

else if (numA > numB) {

    resultado = numA - numB;

 Console.Write("A Diferença é {0}", resultado);
}

else {

    resultado = numB - numA;

    Console.Write("A Diferença é {0}", resultado);   

}




