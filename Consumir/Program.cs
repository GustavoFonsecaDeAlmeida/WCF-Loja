using Consumir.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumir
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new ServiceReference1.PedidoUnicoClient();
            ProdutoViewModel produto = new ProdutoViewModel();
            produto.idProduto = 1;
            produto.Quantidade = 10;
            var resposta = cliente.RealizarPedido(produto);

            Console.WriteLine(resposta);
            Console.ReadKey();

        }
    }
}
