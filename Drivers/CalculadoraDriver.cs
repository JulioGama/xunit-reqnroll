namespace xunit_reqnroll.Drivers
{
    public class Calculadora
    {
        public int PrimeiroNumero { get; set; }
        public int SegundoNumero { get; set; }

        public int Somar()
        {
            return PrimeiroNumero + SegundoNumero;
        }

        public int Subtrair()
        {
            return PrimeiroNumero - SegundoNumero;
        }

        public int Multiplicar()
        {
            return PrimeiroNumero * SegundoNumero;
        }
    }
}