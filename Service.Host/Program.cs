using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(GerenciamentoCompras.Pedido));

                host.Opened += new EventHandler((o, a) => Console.WriteLine("Service Hosted Successfully!"));

                host.Open();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Failed to host the service: {0}", exc);
            }

            Console.ReadLine();
        }
    }
}
