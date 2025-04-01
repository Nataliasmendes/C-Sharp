// See https://aka.ms/new-console-template for more information

//Faça um programa para calcular o estoque médio de uma peça, sendo que: ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE MÁXIMA) / 2

/*

double QUANTIDADE_MÍNIMA, QUANTIDADE_MÁXIMA, ESTOQUE_MEDIO;


Console.WriteLine("Digite a quantidade máxima: ");
QUANTIDADE_MÁXIMA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quantidade mínima: ");
QUANTIDADE_MÍNIMA = double.Parse(Console.ReadLine());

ESTOQUE_MEDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2;

Console.WriteLine(ESTOQUE_MEDIO);
*/

double min, max, media;
string minTex, maxTex;

Console.WriteLine("Escreva a quantidade mínima: ");
minTex = Console.ReadLine();

Console.WriteLine("Escreva a quantidade mínima: ");
maxTex = Console.ReadLine();


max = Convert.ToDouble(maxTex);
min = Convert.ToDouble(minTex);

media = (max + min) / 2;

Console.WriteLine("A média desse valor é: " + media);

maxTex = media.ToString();
Console.WriteLine(maxTex);