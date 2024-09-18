using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7_DSIV
{
    internal class Banco
    {
        private Cliente cliente, cliente2, cliente3;

        public Banco() 
        { 
            cliente = new Cliente("Roxana");
            cliente2 = new Cliente("Ludy");
            cliente3 = new Cliente("Alison");
        }

        public void Operar()
        {
            cliente.Depositar(200);
            cliente2.Depositar(250);
            cliente3.Depositar(350);
            cliente3.Extraer(145);
        }

        public void DepositosTotales()
        {
            int transferencia = cliente.RetornarMonto() +
                cliente2.RetornarMonto() +
                cliente3.RetornarMonto();
            Console.WriteLine("El total de dinero que cuenta el Banco es de: $" +transferencia);
            cliente.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }
    }
}
