using Loja.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAO
{
    public class ProdutoDAO
    {
        private Context db = new Context();

        public bool AdicionarProduto(Produto produto)
        {
            db.Produtos.Add(produto);
            db.SaveChanges();
            return true;
        }

        public bool RemoverProduto(int idProduto) {

            Produto produto = db.Produtos.Find(idProduto);

            db.Produtos.Remove(produto);
            db.SaveChanges();

            return true;

        }

        public bool EditarProduto(Produto produto) {

           var pegandoProduto = db.Produtos.Where(a => a.idProduto == produto.idProduto);

            var objProduto = pegandoProduto.FirstOrDefault<Produto>();

            objProduto.idProduto = produto.idProduto;

            objProduto.NomeProduto = produto.NomeProduto;

            objProduto.Categoria = produto.Categoria;

            objProduto.preco = produto.preco;

            objProduto.Imagem = produto.Imagem;

            objProduto.Quantidade = produto.Quantidade;

            db.SaveChanges();


            return true;
        }

        public Produto SelecionarProduto(int idProduto) {

            var pegandoProduto = db.Produtos.Where(a => a.idProduto == idProduto);

            var objProduto = pegandoProduto.FirstOrDefault<Produto>();

            return objProduto;

        }

        public IQueryable<Produto> Produtos()
        {
            
            return db.Produtos.Where(x => x.pedido == null);
        }


        public bool VenderProduto(int idProduto , int quantidade) {

            Produto produto = db.Produtos.Find(idProduto);

         
            if (produto.Quantidade == 0 )
            {
                return false;

            }
            else if (quantidade <= 0)
            {
                return false;

            }
            else
            {
                produto.Quantidade = produto.Quantidade - quantidade;

                db.SaveChanges();
                return true;

            }
      
        }

    }
}
