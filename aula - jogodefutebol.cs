// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

string time1, time2, resultado_geral1, resultado_geral2;
double resultado1_time1, resultado1_time2, resultado2_time1, resultado2_time2;

Console.WriteLine("JOGO DE MATA-MATA");

Console.WriteLine("Qual é o primeiro time?");
time1 = Console.ReadLine();

Console.WriteLine("Qual é o segundo time?");
time2 = Console.ReadLine();

Console.Clear();

Console.WriteLine($"{time1} X {time2}");

Console.WriteLine("PRIMEIRO JOGO");

Console.WriteLine("Quantos pontos fez o time 1? ");
resultado1_time1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quantos pontos fez o time 2? ");
resultado1_time2 = Convert.ToDouble(Console.ReadLine());

if (resultado1_time1 >  resultado1_time2)
{
    Console.WriteLine($"{time1} GANHOU PRIMEIRO JOGO");
} else if (resultado1_time2 > resultado1_time1)
{
    Console.WriteLine($"{time2} GANHOU O PRIMEIRO JOGO");
} else
{
    Console.WriteLine("EMPATE");
}



Console.WriteLine("SEGUNDO JOGO");

Console.WriteLine("Quantos pontos fez o time 1? ");
resultado2_time1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quantos pontos fez o time 2? ");
resultado2_time2 = Convert.ToDouble(Console.ReadLine());

if (resultado2_time1 > resultado2_time2)
{
    Console.WriteLine($"{time1} GANHOU!!!");
} else if (resultado2_time2 > resultado2_time1)
{
    Console.WriteLine($"{time2} GANHOU!!!");
} else
{
    Console.WriteLine("EMPATE");
}

Console.WriteLine("Qual resultado do primeiro jogo? ");
resultado_geral1 = Console.ReadLine();

Console.WriteLine("Qual resultado do segundo jogo? ");
resultado_geral2 = Console.ReadLine();

if (resultado_geral1 == "Empate" && resultado_geral2 == "Empate")
{
    Console.WriteLine("PENALTES");
} else if (resultado_geral1 == time1 && resultado_geral2 == time2) {    
    Console.WriteLine("PENALTES");
} else if (resultado_geral1 == time1 && resultado_geral2 == time1) {
    Console.WriteLine($"{time1} GANHOU O CAMPEONATO");
} else
{
    Console.WriteLine($"{time2} GANHOU O CAMPEONATO");
}
