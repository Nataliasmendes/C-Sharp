// See https://aka.ms/new-console-template for more information


double valor_dolar , valor_real , valor_digitado;

Console.WriteLine("Digite a cotação do dolar: ");
valor_dolar = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o seu valor em dólar: ");
valor_digitado = Convert.ToDouble(Console.ReadLine());

valor_real = valor_digitado * valor_dolar;

Console.WriteLine($"O seu valor em reais é de R$ {valor_real}");