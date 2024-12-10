// See https://aka.ms/new-console-template for more information
/*Elabore um programa, utilizando os operadores lógicos, que: 
 * Peça para o usuário inserir o nome de três produtos de mercado, e seus
 * respectivos preços e mostre na tela o produto mais barato dos três.*/


string Produto1, Produto2, Produto3;
double Preco1, Preco2, Preco3;

Console.Write("Digite o Nome do Produto 1: ");
Produto1 = (Console.ReadLine());
Console.Write("Digite o Preço do Produto1: ");
Preco1 = double.Parse(Console.ReadLine());

Console.Write("Digite o Nome do Produto 2: ");
Produto2 =(Console.ReadLine());
Console.Write("Digite o Preço do Produto 2: ");
Preco2 = double.Parse(Console.ReadLine());

Console.Write("Digite o Nome do Produto 3: ");
Produto3 = (Console.ReadLine());
Console.Write("Digite o Preço do Produto 3: ");
Preco3 = double.Parse(Console.ReadLine());

if (Preco1 < Preco2 && Preco1 > Preco3){

    Console.Write("O {0} é o mais barato e seu Preço é: {1}", Produto1, Preco1);
}

else if (Preco2 < Preco1 && Preco2 < Preco3){

    Console.Write("O {0} é o mais barato e seu Preço é: {1}", Produto2, Preco2);
}

else{

    Console.Write("O {0} é o mais barato e seu Preço é: {1}", Produto3, Preco3);
}






