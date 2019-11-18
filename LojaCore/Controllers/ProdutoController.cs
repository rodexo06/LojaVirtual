using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LojaCore.Models;

namespace LojaCore.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar()
        {
            var produto = GetProduto(); 

            return View(produto);
            //return new ContentResult() { Content = "Produto --> Visualizar", ContentType = "text/html"};
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Playstation",
                Descricao = "Top",
                Valor = 2000
            };
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}