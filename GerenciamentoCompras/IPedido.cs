using GerenciamentoCompras.Model;
using Loja.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GerenciamentoCompras
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IPedido" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract (Name ="PedidoUnico",Namespace =("http://localhost:60745/v1"))]
    public interface IPedido_V1
    {
        [OperationContract]
        string RealizarPedido(Loja.Domain.Produto produto);

        [OperationContract]
        PedidoViewModel ProximoPedido();

        [OperationContract]
        bool EmpacotarPedido(int idPedido);

        [OperationContract]
        bool EnviarPedido(int idPedido);







    }

    [ServiceContract(Name = "PedidoMultiplo", Namespace = ("http://localhost:60745/v2"))]
    public interface IPedido_V2
    {
        [OperationContract]
        string RealizarPedido(List<Loja.Domain.Produto> ListaProdutos);

        [OperationContract]
        PedidoViewModel ProximoPedido();


        [OperationContract]
        bool EmpacotarPedido(int idPedido);

        [OperationContract]
        bool EnviarPedido(int idPedido);
    }
}
