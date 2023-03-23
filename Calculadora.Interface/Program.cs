using Calculadora;

Console.WriteLine("Olá!");

Console.WriteLine("Digite um número: ");
var n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
var n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A soma entre esses números é de ", Calculadora.Operacoes.Somar(n1, n2));

