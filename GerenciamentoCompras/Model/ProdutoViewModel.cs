using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GerenciamentoCompras.Model
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
    }
}