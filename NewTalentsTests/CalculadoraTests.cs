using NewTalents;
using System;
using Xunit;
using Xunit.Abstractions;

namespace NewTalentsTests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora;
        private readonly ITestOutputHelper _output;
        public CalculadoraTests(ITestOutputHelper outputHelper)
        {
            _output = outputHelper;
            _calculadora = new Calculadora(DateTime.Now);
        }

        //quando-dado-então
        [Theory]
        [InlineData(5, 7, 12)]
        [InlineData(3, 8, 11)]
        public void Somar_DoisNumerosInteiros_RetornaASoma(int num1, int num2, int resultadoEsperado)
        {
            //arrange
            //act
            var resultado = _calculadora.Somar(num1, num2);

            //assert 
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(8, 3, 5)]
        public void Subtrair_DoisNumerosInteiros_RetornaASubtracao(int num1, int num2, int resultadoEsperado)
        {
            //arrange
            //act
            var resultado = _calculadora.Subtrair(num1, num2);

            //assert 
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(5, 7, 35)]
        [InlineData(4, 4, 16)]
        public void Multíplicar_DoisNumerosInteiros_RetornaMultiplicacao(int num1, int num2, int resultadoEsperado)
        {
            //arrange

            //act
            var resultado = _calculadora.Multiplicar(num1, num2);

            //assert 
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20, 2, 10)]
        public void Dividir_DoisNumerosInteiros_RetornaDivisao(int num1, int num2, int resultadoEsperado)
        {
            //arrange
            //act
            var resultado = _calculadora.Dividir(num1, num2);

            //assert 
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestarDivisao_PorZero_RetornaUmaExcecao()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(4, 0));
        }

        [Fact]
        public void TestarHistorico_Operacoes_Retonar3ultimasOperacoes()
        {
            _calculadora.Somar(1, 2);
            _calculadora.Somar(3, 4);
            _calculadora.Somar(3, 5);
            _calculadora.Somar(6, 8);

            var resultado = _calculadora.Historico();

            foreach (var item in resultado)
            {
                _output.WriteLine(item);
            }
 
            Assert.NotEmpty(resultado);
            Assert.Equal(3, resultado.Count);
        }
    }
}
