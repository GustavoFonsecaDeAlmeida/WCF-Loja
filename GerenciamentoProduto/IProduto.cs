using GerenciamentoProduto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GerenciamentoProduto
{

    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IProduto" no arquivo de código e configuração ao mesmo tempo.

    [ServiceContract(Name = "Produtos", Namespace = ("http://localhost:49577/v1"))]
    public interface IProduto_V1
    {
        [OperationContract]
        bool AdicionarNaFila(ProdutoViewModel produto);

        [OperationContract]
        bool ConsumirFila();

        [OperationContract]
        string ListarTodosProdutos();

        [OperationContract]
        bool CadastroProduto(Loja.Domain.Produto produto);

        [OperationContract]
        bool EditarProduto(Loja.Domain.Produto produto);

        [OperationContract]
        bool RemocaoProduto(int idProduto);




    }
}
