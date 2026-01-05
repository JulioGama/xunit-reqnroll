namespace xunit_reqnroll.Drivers
{
    public class Conta
    {
        public decimal Saldo { get; private set; }

        public void DefinirSaldoInicial(decimal valor) => Saldo = valor;

        public void Depositar(decimal valor) => Saldo += valor;

        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            // Por enquanto, se não tiver saldo, ele simplesmente não saca.
        }
    }
}