using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GerenciamentoProduto.Model
{
    [DataContract]
    public class ProdutoViewModel
    {
        [DataMember]
        public int idProduto { get; set; }
        [DataMember]
        public string NomeProduto { get; set; }
        [DataMember]
        public int Quantidade { get; set; }
        [DataMember]
        public string Categoria { get; set; }
        [DataMember]
        public string Preco { get; set; }
        [DataMember]
        public string Imagem { get; set; }
        [DataMember]
        public string Flag { get; set; }
    }
}