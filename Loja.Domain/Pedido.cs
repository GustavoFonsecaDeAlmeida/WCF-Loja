using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Domain
{
    public class Pedido
    {
        [Key]
        public int idPedido { get; set; }

        public bool PedidoEmpacotado { get; set; }

        public bool PedidoEnviado { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}





