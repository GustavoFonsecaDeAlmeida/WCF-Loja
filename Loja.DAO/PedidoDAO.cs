using Loja.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAO
{
    
    public class PedidoDAO
    {
        private Context db = new Context();

         public bool AdicionarPedido(Pedido pedido)
        {
            db.Pedidos.Add(pedido);
            db.SaveChanges();
            return true;
        }

        public bool RemoverPedido(int idPedido) {

            Pedido pedido = db.Pedidos.Find(idPedido);

            db.Pedidos.Remove(pedido);
            db.SaveChanges();

            return true;

        }

        public bool EditarPedido(Pedido pedido) {

            var objPedido = SelecionarPedido(pedido.idPedido);


            objPedido.idPedido = pedido.idPedido;

            objPedido.PedidoEmpacotado = pedido.PedidoEmpacotado;

            objPedido.PedidoEnviado = pedido.PedidoEnviado;

            objPedido.Produtos = pedido.Produtos;

            db.SaveChanges();


            return true;
        }

        public Pedido SelecionarPedido(int idPedido) {

            var pegandoPedido = db.Pedidos.Where(a => a.idPedido == idPedido);

            var objPedido = pegandoPedido.FirstOrDefault<Pedido>();

            return objPedido;

        }

        public IQueryable<Pedido> Pedidos()
        {
            return db.Pedidos;
        }


       
    }
}
