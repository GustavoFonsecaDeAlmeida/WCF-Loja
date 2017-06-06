using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Queue; // Namespace for Queue storage types

namespace GerenciamentoCompras.Service
{
    public class FilaService
    {
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

           var idPedidoToString =  idPedido.ToString();
            

            CloudQueueMessage message = new CloudQueueMessage(idPedidoToString);
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

            

            return peekedMessage.AsString;
        }
    }
}
