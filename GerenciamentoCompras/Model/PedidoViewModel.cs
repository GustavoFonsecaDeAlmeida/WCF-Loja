using Loja.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GerenciamentoCompras.Model
{
    [DataContract]
    public class PedidoViewModel
    {
        [Key]
        [DataMember]
        public int idPedido { get; set; }
        [DataMember]
        public bool PedidoEmpacotado { get; set; }
        [DataMember]
        public bool PedidoEnviado { get; set; }
        [DataMember]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}