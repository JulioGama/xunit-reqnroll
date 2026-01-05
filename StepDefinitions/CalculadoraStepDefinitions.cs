using xunit_reqnroll.Drivers;
using Reqnroll;
using Xunit;

namespace xunit_reqnroll.StepDefinitions
{
    [Binding]
    public class CalculadoraStepDefinitions
    {
        private readonly Calculadora _calculadora = new Calculadora();
        private int _resultado;

        [Given(@"que eu entrei o número (.*) na calculadora")]
        public void GivenQueEuEntreiONumeroNaCalculadora(int numero)
        {
            if (_calculadora.PrimeiroNumero == 0)
                _calculadora.PrimeiroNumero = numero;
            else
                _calculadora.SegundoNumero = numero;
        }

        [Then(@"o resultado deve ser (.*)")]
        public void ThenOResultadoDeveSer(int resultadoEsperado)
        {
            Assert.Equal(resultadoEsperado, _resultado);
        }

        [When(@"eu pressionar o botão de (.*)")]
        public void WhenEuPressionarOBotaoDe(string operacao)
        {
            _resultado = operacao.ToLower() switch
            {
                "somar" => _calculadora.Somar(),
                "subtrair" => _calculadora.Subtrair(),
                "multiplicar" => _calculadora.Multiplicar(),
                _ => throw new ArgumentException("Operação inválida")
            };
        }
    }
}