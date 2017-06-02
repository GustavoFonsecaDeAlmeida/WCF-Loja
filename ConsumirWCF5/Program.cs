
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirWCF5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new ServiceReference1.PedidoUnicoClient();

            var resultado = cliente.RealizarPedido(1, 10);

            Console.WriteLine(resultado.ToString());

            Console.ReadKey();
            Console.ReadKey();
            Console.ReadLine();



            //List<ServiceReference1.ProdutoViewModel> Produtos = new List<ServiceReference1.ProdutoViewModel>();

            ServiceReference1.ProdutoViewModel[] Produtos2 = new ServiceReference1.ProdutoViewModel[2];


            ServiceReference1.ProdutoViewModel produto1 = new ServiceReference1.ProdutoViewModel();
            produto1.idProduto = 2;
            produto1.NomeProduto = "Sprite";
            produto1.Quantidade = 100;

            ServiceReference1.ProdutoViewModel produto2 = new ServiceReference1.ProdutoViewModel();
            produto2.idProduto = 3;
            produto2.NomeProduto = "Fanta";
            produto2.Quantidade = 100;

            Produtos2[0] = produto1;
            Produtos2[1] = produto2;


            var cliente2 = new ServiceReference1.PedidoMultiploClient();
            var resultado2 = cliente2.RealizarPedido(Produtos2);

            Console.WriteLine(resultado2.ToString());
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadLine();










        }
    }
}
