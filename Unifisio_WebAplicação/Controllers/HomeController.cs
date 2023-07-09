using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unifisio_WebAplicação.Models;

namespace Unifisio_WebAplicação.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Enviar(Contato contato)
        {
            using(Conexao conexao = new Conexao())
            {
                string Strquery = "Insert into tb_contato(Nome,Email,Assunto,Descricao) values(";
                Strquery += "'" + contato.Nome + "', ";
                Strquery += "'" + contato.Email + "', ";
                Strquery += "'" + contato.Assunto + "', ";
                Strquery += "'" + contato.Descricao + "');";
                using(MySqlCommand comando = new MySqlCommand(Strquery,conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Contact");
            }
        }
    }
}