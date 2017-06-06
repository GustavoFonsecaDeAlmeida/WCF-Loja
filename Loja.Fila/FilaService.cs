using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Queue; // Namespace for Queue storage types

namespace Loja.Fila
{
    public class FilaService
    {

 

        public bool AdicionarPedidoAFila(int idPedido) {

            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a container.
            CloudQueue queue = queueClient.GetQueueReference("FilaPedidos");

            // Create the queue if it doesn't already exist
            queue.CreateIfNotExists();

            
            byte[] intBytes = BitConverter.GetBytes(idPedido);
            Array.Reverse(intBytes);
            byte[] result = intBytes;

            CloudQueueMessage message = new CloudQueueMessage(intBytes);

            return true;
        }

        public bool PegarProximoPedido() {

            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a container.
            CloudQueue queue = queueClient.GetQueueReference("FilaPedidos");

            // Create the queue if it doesn't already exist
            queue.CreateIfNotExists();


            CloudQueueMessage peekedMessage = queue.PeekMessage();

            return true;
        }
    }
}

