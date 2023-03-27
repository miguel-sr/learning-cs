namespace Calculadora
{
    public static class Operacoes
    {
        private static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        private static double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }

        private static double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        private static double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }


        public static double ExecutarCalculo(string operacao, double n1, double n2)
        {
            switch (operacao)
            {
                case "1":
                    return Somar(n1, n2);

                case "2":
                    return Subtrair(n1, n2);

                case "3":
                    return Multiplicar(n1, n2);

                case "4":
                    return Dividir(n1, n2);

                default:
                    throw new Exception("Opção inválida");
            }
        }
    }
}