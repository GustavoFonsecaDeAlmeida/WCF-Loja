using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loja.Web.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var cliente = new ProdutoReferencia.ProdutosClient();
            var produtos = cliente.ListarTodosProdutos();

            IList<ProdutoReferencia.Produto> objprodutos = produtos; 

            //foreach (var item in produtos)
            //{
            //    ProdutoReferencia.Produto produto = new ProdutoReferencia.Produto();
            //    produto.idProduto = item.idProduto;
            //    produto.NomeProduto = item.NomeProduto;
            //    produto.Imagem = item.Imagem;
            //    produto.preco = item.preco;
            //    produto.Quantidade = item.Quantidade;
            //    produto.Categoria = item.Categoria;

            //    objprodutos.Add(produto);
                


            //}

           

            return View(objprodutos);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
