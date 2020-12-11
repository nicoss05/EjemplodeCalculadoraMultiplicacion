using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace deber1.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Multiplicar2numeros()
        {
            var numero1 = 15;
            var numero2 = 2;
            var esperado = 30;

            var calculadora = new Calculadora();

            var resultado = calculadora.Multiplicar(numero1, numero2);

            Assert.AreEqual(esperado, resultado);

        }
    }
}
 