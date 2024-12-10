// See https://aka.ms/new-console-template for more information
/*Construa um algoritmo que leia o código de um livro (CL)
e apresente a categoria do livro, conforme a tabela abaixo: */

      int codigo;

Console.WriteLine("Digite o Código do Livro (1 ou 2)");
codigo = int.Parse(Console.ReadLine());

    switch (codigo)
{
    case 1:
       Console.WriteLine("Ficção");
        break;

    case 2:
        Console.WriteLine("Não-Ficção ");
        break;

    default:
         Console.WriteLine("Código Inválido");
        break;
   


}

