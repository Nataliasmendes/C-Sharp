// See https://aka.ms/new-console-template for more information


string nome;
string telefone;
string idade;
string endereço;
string cep;
string cidade;
string estado;

Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Idade: ");
idade = Console.ReadLine();

Console.WriteLine("Digite o seu endereço: ");
endereço = Console.ReadLine();

Console.WriteLine("Digite o seu cep: ");
cep = Console.ReadLine();

Console.WriteLine("Digite a sua cidade: ");
cidade = Console.ReadLine();

Console.WriteLine("Digite o seu estado: ");
estado = Console.ReadLine();

Console.Clear();

Console.WriteLine("nome: " + nome);
Console.WriteLine("idade: " + idade);
Console.WriteLine("endereço: " + endereço);
Console.WriteLine("cep: " + cep);
Console.WriteLine("cidade: " + cidade);
Console.WriteLine("estado: " + estado);
