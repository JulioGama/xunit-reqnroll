using xunit_reqnroll.Drivers;
using Reqnroll;
using Xunit;

namespace xunit_reqnroll.StepDefinitions
{
    [Binding]
    public class ContaStepDefinitions
    {
        // Criamos a instância da conta para usar nos passos
        private readonly Conta _conta = new Conta();

        [Given(@"que eu tenho uma conta com saldo de (.*)")]
        public void GivenQueEuTenhoUmaContaComSaldoDe(decimal saldoInicial)
        {
            _conta.DefinirSaldoInicial(saldoInicial);
        }

        [When(@"eu (.*) o valor de (.*)")]
        public void WhenEuRealizarAMovimentacao(string operacao, decimal valor)
        {
            if (operacao.ToLower() == "depositar")
            {
                _conta.Depositar(valor);
            }
            else if (operacao.ToLower() == "sacar")
            {
                _conta.Sacar(valor);
            }
        }

        [Then(@"o saldo da conta deve ser (.*)")]
        public void ThenOSaldoDaContaDeveSer(decimal saldoEsperado)
        {
            Assert.Equal(saldoEsperado, _conta.Saldo);
        }
    }
}