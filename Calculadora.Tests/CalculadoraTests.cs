namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void A_SOMA_DE_1_MAIS_1_RETORNA_2()
        {
            Assert.Equal(2, Operacoes.Somar(1, 1));
        }

        [Fact]
        public void A_SUBTRACAO_DE_1_MAIS_1_RETORNA_0()
        {
            Assert.Equal(0, Operacoes.Subtrair(1, 1));
        }

        [Fact]
        public void A_MULTIPLICACAO_DE_2_MAIS_2_RETORNA_4()
        {
            Assert.Equal(0, Operacoes.Subtrair(2, 2));
        }

        [Fact]
        public void A_DIVISAO_DE_2_MAIS_2_RETORNA_1()
        {
            Assert.Equal(1, Operacoes.Dividir(2, 2));
        }
    }
}