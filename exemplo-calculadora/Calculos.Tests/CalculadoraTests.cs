using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculos.Tests
{
    [TestClass]
    public class CalculadoraTests
    {
        /*
        [TestMethod]
        public void Soma_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Soma(10, 20);
           
            Assert.AreEqual(30, resultado);
        }

        [TestMethod]
        public void Divisao_DividePorUm(){

            Calculadora calc = new Calculadora();
            var resultado = calc.Divisao(10,1);

            Assert.AreEqual(10,resultado);

        }

        [TestMethod]
        public void Divisao_ResultaFracao(){

            Calculadora calc = new Calculadora();
            var resultado = calc.Divisao(1,10); 

            Assert.AreEqual(0.1,resultado);
        }

        [TestMethod]
        public void Divisao_DivisaoPorZero(){

            Calculadora calc = new Calculadora();
            var resultado = calc.Divisao(1,0); 

            Assert.AreEqual(0,resultado);
        }

*/


        [DataTestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(5)]
        [DataRow(4)]
        public void RestoDivisao_DeveRetornarZero(int value)
        {
            Calculadora c = new Calculadora();
            var resultado = c.RestoDivisao(12, value);
            //Verifica se o resto da divisão é 0
            Assert.AreEqual(0, resultado.resto);
        }

    }
}