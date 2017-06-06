using GerenciamentoCompras.Model;
using Loja.DAO;
using Loja.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GerenciamentoCompras
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Pedido" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Pedido.svc ou Pedido.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Pedido : IPedido_V1, IPedido_V2
    {
        private PedidoDAO dao = new PedidoDAO();
        private Service.PedidoFilaService fila = new Service.PedidoFilaService();


        public string RealizarPedido(ProdutoViewModel produto) {

            Service.PedidoFilaService fila = new Service.PedidoFilaService();

            Produto objProduto = new Produto();
            objProduto.idProduto = produto.idProduto;
            objProduto.Quantidade = produto.Quantidade;

            List<Produto> ListaProdutos = new List<Produto>();

            ListaProdutos.Add(objProduto);

            Loja.Domain.Pedido objPedido = new Loja.Domain.Pedido();
            objPedido.Produtos = ListaProdutos;
            objPedido.PedidoEmpacotado = false;
            objPedido.PedidoEnviado = false;

            

            var resposta = dao.AdicionarPedido(objPedido);

            if (resposta.ToString() == "True")
            {
                fila.AdicionarPedidoAFila(objPedido.idPedido);
                return "Pedido Realizado com Sucesso , aguardando colobarodores para mudar status do seu pedido";
                
            }
            else
            {
                return "OPS.. Ocorreu algum erro.";
            }

        }




        public string RealizarPedido(List<ProdutoViewModel> ListaProdutos)
        {
            List<Produto> ProdutosLista = new List<Produto>();

            foreach (var item in ListaProdutos)
            {
                Produto produto = new Produto();
                produto.idProduto = item.idProduto;
                produto.NomeProduto = item.NomeProduto;
                produto.Quantidade = item.Quantidade;
                
                ProdutosLista.Add(produto);

            }

            Loja.Domain.Pedido objPedido = new Loja.Domain.Pedido();
            objPedido.Produtos = ProdutosLista;
            objPedido.PedidoEmpacotado = false;
            objPedido.PedidoEnviado = false;

            var resposta = dao.AdicionarPedido(objPedido);

            if (resposta.ToString() == "True")
            {
                fila.AdicionarPedidoAFila(objPedido.idPedido);
                return "Pedido Realizado com Sucesso , aguardando colobarodores para mudar status do seu pedido";
            }
            else
            {
                return "OPS.. Ocorreu algum erro.";
            }

            

           
        }
        public PedidoViewModel ProximoPedido() {

            PedidoViewModel pedido = new PedidoViewModel();

            pedido = fila.PegarProximoPedido();

           




            return pedido;



        }

    }
}
