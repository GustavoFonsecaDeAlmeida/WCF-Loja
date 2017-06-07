using GerenciamentoProduto.Model;
using Loja.DAO;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoProduto.Service
{
    public class ProdutoFilaService
    {
        private ProdutoDAO produtoDB = new ProdutoDAO();

        public bool AdicionarAFila(ProdutoViewModel produto)
        {
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a container.
            CloudQueue queue = queueClient.GetQueueReference("filaproduto");

            // Create the queue if it doesn't already exist
            queue.CreateIfNotExists();



            var objToJson = JsonConvert.SerializeObject(produto);


            CloudQueueMessage message = new CloudQueueMessage(objToJson);
            queue.AddMessage(message);

            return true;
        }

        public bool ConsumirAFila() {

            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a container.
            CloudQueue queue = queueClient.GetQueueReference("filaproduto");

            // Create the queue if it doesn't already exist
            queue.CreateIfNotExists();

            var mensagem = queue.GetMessage().AsString;

            var JsonToObj = JsonConvert.DeserializeObject<ProdutoViewModel>(mensagem);

            switch (JsonToObj.Flag)
            {
                case "Adicionar":
                    Loja.Domain.Produto produto = new Loja.Domain.Produto();
                    produto.idProduto = JsonToObj.idProduto;
                    produto.Categoria = JsonToObj.Categoria;
                    produto.Imagem = JsonToObj.Imagem;
                    produto.NomeProduto = JsonToObj.NomeProduto;
                    produto.preco = JsonToObj.Preco;
                    produto.Quantidade = JsonToObj.Quantidade;
                    produtoDB.AdicionarProduto(produto);
                    break;

                case "Remover":
                    produtoDB.RemoverProduto(JsonToObj.idProduto);
                    break;

                case "Editar":
                    Loja.Domain.Produto produto2 = new Loja.Domain.Produto();
                    produto2.idProduto = JsonToObj.idProduto;
                    produto2.Categoria = JsonToObj.Categoria;
                    produto2.Imagem = JsonToObj.Imagem;
                    produto2.NomeProduto = JsonToObj.NomeProduto;
                    produto2.preco = JsonToObj.Preco;
                    produto2.Quantidade = JsonToObj.Quantidade;
                    produtoDB.EditarProduto(produto2);
                    break;


                default:
                    return false;
                    
            }

            return true;
        }
    }
}