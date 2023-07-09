using MySql.Data.MySqlClient;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unifisio_WebAplicação.Models;

namespace Unifisio_WebAplicação.Controllers
{
    public class AnamneseController : Controller
    {
        // GET: Anamnese
        List<Anamnese> lstanamnese = new List<Anamnese>();
        public ActionResult Index()
        {

            Conexao conexao = new Conexao();
            List<Anamnese> lstAnamnese = new List<Anamnese>();
            string StrQuery = "SELECT * FROM tb_anamnese ORDER BY titulo";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Anamnese anamnese = new Anamnese()
                    {
                        id = Convert.ToInt32(dr["Id"]),
                        titulo = Convert.ToString(dr["Titulo"])
                    };
                    lstAnamnese.Add(anamnese);
                }
            }

            ViewBag.LstAnamnese = lstAnamnese;

            return View();
        }

        public JsonResult GetItens(int Id)
        {

            Conexao conexao = new Conexao();
            List<AnamneseItens> lstItens = new List<AnamneseItens>();
            string StrQuery = "SELECT * FROM tb_anamnese_itens where id_anamenese = " + Id + " ORDER BY pergunta";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AnamneseItens anamneseItem = new AnamneseItens()
                        {
                            id = Convert.ToInt32(dr["Id"]),
                            id_anamenese = Convert.ToInt32(dr["id_anamenese"]),
                            pergunta = Convert.ToString(dr["pergunta"]),
                            tipo = Convert.ToString(dr["Tipo"])
                        };
                        lstItens.Add(anamneseItem);
                    }
                }
                else
                {
                    AnamneseItens anamneseItem = new AnamneseItens();
                    anamneseItem.id_anamenese = Convert.ToInt32(Id);
                    anamneseItem.pergunta = "AINDA NÃO FORAM CADASTRADAS PERGUNTAS";
                    lstItens.Add(anamneseItem);
                }
            }
            return Json(lstItens, JsonRequestBehavior.AllowGet);

        }


        public ActionResult Novo(AnamneseItens anamneseItens)
        {

            Conexao conexao = new Conexao();
            List<TiposPerguntas> lstPerguntas = new List<TiposPerguntas>();
            string StrQuery = "SELECT * FROM tiposPerguntas ORDER BY TIPO";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    TiposPerguntas tiposPerguntas = new TiposPerguntas()
                    {
                        id = Convert.ToInt32(dr["Id"]),
                        tipo = Convert.ToString(dr["tipo"])
                    };
                    lstPerguntas.Add(tiposPerguntas);
                }
            }

            ViewBag.LstTiposPerguntas = lstPerguntas;
            //AnamneseItens anamneseItens = new AnamneseItens();
            //anamneseItens.id_anamenese = id;    

            return View(anamneseItens);

        }

        [HttpPost]
        public ActionResult Salvar(AnamneseItens anamnese)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Insert into tb_anamnese_itens(pergunta,id_anamenese,tipo) values(";
                StrQuery += "'" + anamnese.pergunta + "', ";
                StrQuery += "'" + anamnese.id_anamenese + "', ";
                StrQuery += "'" + anamnese.tipo + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public ActionResult Deletar(AnamneseItens anamneseItens)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Delete from tb_anamnese_itens";
                StrQuery += " where Id = " + anamneseItens.id + ";";

                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");


            }
        }
        public ActionResult NovoTitulo()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_anamnese order by titulo";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Anamnese anamnese = new Anamnese()
                    {
                        id = Convert.ToInt32(dr["id"]),
                        titulo = Convert.ToString(dr["titulo"])

                    };
                    lstanamnese.Add(anamnese);
                }
                return View(lstanamnese);
            }
        }

        public ActionResult NovoQuestionario()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SalvarQuestionario(Anamnese anamnese)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Insert into tb_anamnese(titulo) values(";
                StrQuery += "'" + anamnese.titulo + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");

            }

        }

        public ActionResult DeletarQuestionario(int id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_anamnese where";
            StrQuery += " id=" + id + ";";
            using (MySqlCommand commando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = commando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Anamnese anamnese = new Anamnese();
                    anamnese.titulo = Convert.ToString(dt["titulo"]);
                    return View(anamnese);
                }
                else
                {
                    return RedirectToAction("Index");
                }

            }
        }

        [HttpPost]
        public ActionResult DeletarQuestionario(Anamnese anamnese)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Delete from tb_anamnese";
                StrQuery += " where Id = " + anamnese.id + ";";

                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("NovoTitulo");


            }

        }

        public ActionResult Detalhar(int Id)
        {
            var lstPerguntas = new List<AnamneseItens>();
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM tb_anamnese_itens where id_anamenese = @Id";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                comando.Parameters.AddWithValue("@Id", Id);
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var item = new AnamneseItens();
                        item.pergunta = Convert.ToString(dr["pergunta"]);
                        item.tipo = Convert.ToString(dr["tipo"]);
                        lstPerguntas.Add(item);
                    }
                    ViewBag.Perguntas = lstPerguntas;
                }
            }

            var relatorioPDF = new ViewAsPdf
            {
                ViewName = "Detalhar",
                PageSize = Rotativa.Options.Size.A4,
                // Model = listaVendasViewModel.ToPagedList(paginaNumero, listaVendasViewModel.Count),
            };
            return relatorioPDF;

        }
    }
}

