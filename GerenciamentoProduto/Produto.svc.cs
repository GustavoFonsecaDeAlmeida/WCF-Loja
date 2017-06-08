using GerenciamentoProduto.Model;
using GerenciamentoProduto.Service;
using Loja.DAO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GerenciamentoProduto
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Produto" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Produto.svc ou Produto.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Produto : IProduto_V1
    {
        ProdutoDAO db = new ProdutoDAO();
        ProdutoFilaService fila = new ProdutoFilaService();

        public bool AdicionarNaFila(ProdutoViewModel produto)
        {
            fila.AdicionarAFila(produto);
            
            return true;
        }

        public bool ConsumirFila()
        {
            fila.ConsumirAFila();

            return true;

        }

        public string ListarTodosProdutos() {

            var retornobd = db.Produtos();

            List<Loja.Domain.Produto> produtos = new List<Loja.Domain.Produto>();

            foreach (var item in retornobd)
            {

                produtos.Add(item);

            }

            var novoProdutos = JsonConvert.SerializeObject(produtos);

            return novoProdutos;
        }


          public bool CadastroProduto(Loja.Domain.Produto produto) {

            db.AdicionarProduto(produto);
            return true;

            }

        public bool EditarProduto(Loja.Domain.Produto produto)
        {

            db.EditarProduto(produto);
            return true;

        }

        public bool RemocaoProduto(int idProduto) {

            db.RemoverProduto(idProduto);
            return true;
        }









    }


       
        
    }
}
