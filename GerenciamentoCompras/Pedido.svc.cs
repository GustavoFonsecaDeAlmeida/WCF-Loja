using Loja.DAO;
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
        private ProdutoDAO dao = new ProdutoDAO();

        public string RealizarPedido(int idProduto , int quantidade) {

            var resposta = dao.VenderProduto(idProduto, quantidade);

            if (resposta.ToString() == "True")
            {
                //Implementar logica da fila
                return "Produto Vendido com sucesso, seu pedido foi encaminhado para os empacotadores";
            }
            else
            {
                return "OPS.. Ocorreu algum erro.";
            }

        }

        public string RealizarPedido(List<string> item)
        {




            return "varios";
        }


    }
}
