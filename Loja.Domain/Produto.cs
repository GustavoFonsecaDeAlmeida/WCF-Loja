
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Domain
{
    public class Produto
    {
        [Key]
        public int idProduto { get; set; }

        public string NomeProduto { get; set; }

        public string Categoria { get; set; }
        
        public string Imagem { get; set; }

        public string preco { get; set; }

        public int Quantidade { get; set; }

        public virtual Pedido pedido { get; set; }

       


    }
}
