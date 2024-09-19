using Laboratorio_8._2_DSIV;

internal class Program
{
    private static void Main(string[] args)
    {
        const string Cuenta = "250";

        Cuenta cuenta = new Cuenta(Cuenta);
        CuentaCorriente cuentaCorriente =
            new CuentaCorriente(Cuenta);
        CuentaAhorro cuentaAhorro =
            new CuentaAhorro(Cuenta);
        cuenta.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
        cuentaAhorro.CalcularIntereses();
    }
}