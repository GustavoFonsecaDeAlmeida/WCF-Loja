using GerenciamentoCompras.Model;
using Loja.DAO;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoCompras.Service
{
    public class PedidoFilaService
    {
       
        
            private ProdutoDAO produtoDB = new ProdutoDAO();
            private PedidoDAO pedidoDB = new PedidoDAO();

            public bool AdicionarPedidoAFila(int idPedido)
            {

                // Retrieve storage account from connection string.
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                    CloudConfigurationManager.GetSetting("StorageConnectionString"));

                // Create the queue client.
                CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

                // Retrieve a reference to a container.
                CloudQueue queue = queueClient.GetQueueReference("filapedido");

                // Create the queue if it doesn't already exist
                queue.CreateIfNotExists();

                var objPedido = pedidoDB.SelecionarPedido(idPedido);


                var objToJson = JsonConvert.SerializeObject(objPedido);


                CloudQueueMessage message = new CloudQueueMessage(objToJson);
                queue.AddMessage(message);


                return true;
            }

            public PedidoViewModel PegarProximoPedido()
            {

                // Retrieve storage account from connection string.
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                    CloudConfigurationManager.GetSetting("StorageConnectionString"));

                // Create the queue client.
                CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

                // Retrieve a reference to a container.
                CloudQueue queue = queueClient.GetQueueReference("filapedido");

                // Create the queue if it doesn't already exist
                queue.CreateIfNotExists();


                CloudQueueMessage peekedMessage = queue.GetMessage();


                var ProximoPedido = JsonConvert.DeserializeObject<PedidoViewModel>(peekedMessage.AsString);

                queue.DeleteMessage(peekedMessage);



                return ProximoPedido;
            }


        }
    }
