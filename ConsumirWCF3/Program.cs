using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirWCF3
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new ServiceReference1.PedidoUnicoClient();

           var resultado =  cliente.RealizarPedido(1,10);

            Console.WriteLine(resultado.ToString());

            Console.ReadKey();

            

        }
    }
}
