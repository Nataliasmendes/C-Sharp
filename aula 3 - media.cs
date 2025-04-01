// See https://aka.ms/new-console-template for more information

double nota1, nota2, nota3, nota4, media;

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quarta nota: ");
nota4 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.Clear();

Console.WriteLine($"A média é {media}");

//se média maior ou igual a 7, escreva aprovado e se media menor que 7 escreva reprovado

/*
if (media >= 7) {
    Console.WriteLine("APROVADO");
} else if (media < 5) {
    Console.WriteLine("REPROVADO");
} else {
    Console.WriteLine("RECUPERAÇÃO");
}
*/


switch (media)
{
    case >= 7:
        Console.WriteLine("Aprovado");
        break;

    case < 5:
        Console.WriteLine("REPROVADO");
        break;

    default:
        Console.WriteLine("RECUPERAÇÃO");
        break;
}
