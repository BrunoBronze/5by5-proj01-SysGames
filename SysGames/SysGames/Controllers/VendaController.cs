using SysGames.Dal;
using SysGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysGames.Controllers {
    public class VendaController : Controller {
        private SysGamesContext db = new SysGamesContext();
        // GET: Venda
        public ActionResult Index() {
            return View(db.Vendas.ToList());
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Venda venda) {
            if (ModelState.IsValid) {
                var cliente = db.Clientes.Find(venda.Pagamento.Carrinho.Cliente.ClienteID);
                if (cliente != null)
                {
                    var produto = db.Produtos.Find(venda.Pagamento.Carrinho.Produto.ProdutoID);
                    if (produto != null)
                    {
                        venda.Pagamento.Carrinho.Cliente = cliente;
                        venda.Pagamento.Carrinho.Produto = produto;
                        venda.DataHora = DateTime.Now;
                        db.Vendas.Add(venda);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        //msg de erro Produto ID
                    }
                }
                else
                {
                    //venda.Pagamento.Carrinho.Cliente.ClienteID = ;
                    //msg de erro Cliente ID
                }
            }
            return View(venda);
        }

        public ActionResult Edit(int id) {
            return View(db.Vendas.First(v => v.VendaID == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Venda venda) {
            if (ModelState.IsValid) {
                var vendaUpdate = db.Vendas.First(v => v.VendaID == venda.VendaID);
                vendaUpdate.DataHora = venda.DataHora;
                vendaUpdate.Previsao = venda.Previsao;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(venda);
        }

        public ActionResult Details(int id) {
            return View(db.Vendas.First(v => v.VendaID == id));
        }
        
        public ActionResult Delete(int id) {
            return View(db.Vendas.First(v => v.VendaID == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id) {
            db.Vendas.Remove(db.Vendas.First(v => v.VendaID == id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}