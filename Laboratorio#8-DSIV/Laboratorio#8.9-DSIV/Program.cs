using Laboratorio_8._9_DSIV;

internal class Program
{
    private static void Main(string[] args)
    {
        Template template = new Template();

        template.ponerVariable("var1", "Valor 1");
        template.ponerVariable("var2", "Valor 2");
        template.ponerVariable("var3", "Valor 3");
        template.verHtml("<br>Rexto Prueba</br>");
    }
}