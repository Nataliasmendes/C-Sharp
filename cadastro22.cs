// See https://aka.ms/new-console-template for more information
/*Cadastrar informações de 10 usuário.
 * nome/sexo/estado civil/idade/tem filhos (s/n)
 * Contar quantos dos usuários cadastrados tem filhos. Quantos de cada sexo. Usando array e foreach, quantos de cada estado civil e quais são de maior.*/

string[] jogadores = new string[16];
double resultado1_time1, resultado1_time2, resultado2_time1, resultado2_time2;


Console.WriteLine("Digite os 16 times: ");

for (int i = 0; i < 2; i++)
{
    jogadores[i] = Console.ReadLine();
}

Console.Clear();

Console.WriteLine("Times inseridos:");
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"{i + 1} - {jogadores[i]}");
}

Console.WriteLine("Partidas sorteadas:");
        for (int i = 0; i < 16; i += 2)
        {
            Console.WriteLine($"{jogadores[i]} vs {jogadores[i + 1]}");
        }

Console.WriteLine();
Console.WriteLine("OITAVAS DE FINAL:");
Console.WriteLine();



Console.WriteLine($"{jogadores[0]} X {jogadores[1]}");
Console.WriteLine($"{jogadores[2]} X {jogadores[3]}");
Console.WriteLine($"{jogadores[4]} X {jogadores[5]}");
Console.WriteLine($"{jogadores[6]} X {jogadores[7]}");




Console.WriteLine("PRIMEIRO JOGO");

Console.WriteLine($"Quantos pontos fez o {jogadores[0]}?");
resultado1_time1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Quantos pontos fez o {jogadores[1]}?");
resultado1_time2 = Convert.ToDouble(Console.ReadLine());

if (resultado1_time1 > resultado1_time2)
{
    Console.WriteLine($"{jogadores[0]} GANHOU PRIMEIRO JOGO");
}
else if (resultado1_time2 > resultado1_time1)
{
    Console.WriteLine($"{jogadores[1]} GANHOU O PRIMEIRO JOGO");
}
else
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
}
else if (resultado2_time2 > resultado2_time1)
{
    Console.WriteLine($"{time2} GANHOU!!!");
}
else
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
}
else if (resultado_geral1 == time1 && resultado_geral2 == time2)
{
    Console.WriteLine("PENALTES");
}
else if (resultado_geral1 == time1 && resultado_geral2 == time1)
{
    Console.WriteLine($"{time1} GANHOU O CAMPEONATO");
}
else
{
    Console.WriteLine($"{time2} GANHOU O CAMPEONATO");
}
