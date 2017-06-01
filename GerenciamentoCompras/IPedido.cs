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
        string RealizarPedido(int idProduto, int quantidade);
    }

    [ServiceContract(Name = "PedidoMultiplo", Namespace = ("http://localhost:60745/v2"))]
    public interface IPedido_V2
    {
        [OperationContract]
        string RealizarPedido(List<string> item);
    }
}
