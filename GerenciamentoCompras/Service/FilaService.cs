using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Queue; // Namespace for Queue storage types
using Newtonsoft.Json;
using GerenciamentoCompras.Model;
using Loja.DAO;

namespace GerenciamentoCompras.Service
{
    public class FilaService
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

            var objPedido = pedidoDB.SelecionarPedido(idPedido) ;


            var objToJson = JsonConvert.SerializeObject(objPedido);

  
            CloudQueueMessage message = new CloudQueueMessage(objToJson);
            queue.AddMessage(message);
            

            return true;
        }

        public String PegarProximoPedido()
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


            CloudQueueMessage peekedMessage = queue.PeekMessage();

            queue.DeleteMessage(peekedMessage);



            return peekedMessage.AsString;
        }

         
    }
}
