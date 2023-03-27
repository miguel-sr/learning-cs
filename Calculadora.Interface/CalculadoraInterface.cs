internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo a Calculadora em C#! \n");

        Console.WriteLine("Escolha uma operação para ser realizada");
        Console.WriteLine("[1] Soma | [2] Subtrair | [3] Multiplicar | [4] Dividir");
        string operacao = Console.ReadLine()!;

        Console.WriteLine("Digite o primeiro número a ser utilizado na operação");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número a ser utilizado na operação");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double res = Calculadora.Operacoes.ExecutarCalculo(operacao, n1, n2);

        Console.WriteLine("O resultado da operação é " + res);
    }
}