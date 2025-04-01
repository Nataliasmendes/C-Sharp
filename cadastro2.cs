// See https://aka.ms/new-console-template for more information
/*Cadastrar informações de 10 usuário.
 * nome/sexo/estado civil/idade/tem filhos (s/n)
 * Contar quantos dos usuários cadastrados tem filhos. Quantos de cada sexo. Usando array e foreach, quantos de cada estado civil e quais são de maior.*/

string nome;
string[] sexo = new string[10]; //Array para armazenar o sexo dos 10 usuários
string[] estado = new string[10];
int idade;
int contador_filhos = 0, contador_idade = 0, contador_f = 0, contador_m = 0, contsolteiro = 0, contcasado = 0, contviuvo = 0, contdivorciado = 0;


for (int i = 0; i <= 1; i++)
{
    Console.WriteLine($"Cadastro de Usuário{i + 1}");
    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("Sexo (M/F): ");
    sexo[i] = (Console.ReadLine().ToUpper());

    while (sexo[i] != "M" && sexo[i] != "F")
    {
        Console.WriteLine("Sexo Inválido, digite novamente!");
        Console.Write("Sexo (M/F): ");
        sexo[i] = (Console.ReadLine().ToUpper());
    }

    Console.Write("Estado Civil: ");
    estado[i] = Console.ReadLine();

    switch (estado.ToLower())
    {
        case "solteiro":
        contsolteiro++;
        break;

        case "casado":
        contcasado++;
        break;

        case "viúvo":
        contviuvo++;
        break;

        case "divorciado":
        contdivorciado++;
        break;
    }

    Console.Write("idade: ");
    string conversão1 = Console.ReadLine();

    bool result = int.TryParse(conversão1, out idade);

    if (result == true)
    {

    }
    else
    {
        Console.WriteLine("Idade inválida");
        i--;
    }

    Console.Write("Tem filhos? (S/N): ");
    string filhos = Console.ReadLine();

    

    if (filhos == "S")
    {
        contador_filhos++;
    }

    if (idade >= 18)
    {
        contador_idade++;
    }

    if (sexo[i] == "fem")
    {
        contador_f++;
    } else
    {
        contador_m++;
    }


    Console.WriteLine();
    Console.WriteLine("-------------");
    Console.WriteLine();
}

Console.WriteLine($"{contador_filhos} dos usuários tem filhos");
Console.WriteLine($"{contador_idade} dos usuários são maiores de idade");
Console.WriteLine($"{contador_f} dos usuários são do sexo feminino");
Console.WriteLine($"{contador_m} dos usuários são do sexo masculino");