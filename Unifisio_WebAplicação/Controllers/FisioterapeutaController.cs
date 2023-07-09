using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Unifisio_WebAplicação.Models;

namespace Unifisio_WebAplicação.Controllers
{
    public class FisioterapeutaController : Controller
    {
        List<Fisioterapeuta> lstFisioterapeuta = new List<Fisioterapeuta>();
        ListaController lista = new ListaController();

        public ActionResult Index()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM tb_fisioterapeuta ORDER BY Nome";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Fisioterapeuta fisioterapeuta = new Fisioterapeuta()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nome = Convert.ToString(dr["Nome"]),
                        Cpf = Convert.ToString(dr["Cpf"]),
                        DataNascimento = Convert.ToString(dr["DataNascimento"]),
                        Email = Convert.ToString(dr["Email"]),
                        Celular = Convert.ToString(dr["Celular"]),
                        Crefito = Convert.ToString(dr["Crefito"]),
                        Sexo = Convert.ToString(dr["Sexo"]),
                        Logradouro = Convert.ToString(dr["Logradouro"]),
                        Numero = Convert.ToString(dr["Numero"]),
                        Bairro = Convert.ToString(dr["Bairro"]),
                        Cidade = Convert.ToString(dr["Cidade"]),
                        Cep = Convert.ToString(dr["Cep"]),
                        Estado = Convert.ToString(dr["Estado"])

                    };
                    lstFisioterapeuta.Add(fisioterapeuta);
                }
            }
            return View(lstFisioterapeuta);
        }


        public ActionResult Novo()
        {
            ViewBag.Sexo = lista.ListaSexo();
            ViewBag.Estados = lista.ListaUf();
            return View();
        }

        public ActionResult Editar(int Id)
        {
            ViewBag.Sexo = lista.ListaSexo();
            ViewBag.Estados = lista.ListaUf();
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM tb_fisioterapeuta WHERE ";
            StrQuery += "id = " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Fisioterapeuta fisioterapeuta = new Fisioterapeuta();
                    fisioterapeuta.Nome = Convert.ToString(dr["Nome"]);
                    fisioterapeuta.Cpf = Convert.ToString(dr["Cpf"]);
                    fisioterapeuta.DataNascimento = Convert.ToString(dr["DataNascimento"]);
                    fisioterapeuta.Email = Convert.ToString(dr["Email"]);
                    fisioterapeuta.Celular = Convert.ToString(dr["Celular"]);
                    fisioterapeuta.Crefito = Convert.ToString(dr["Crefito"]);
                    fisioterapeuta.Sexo = Convert.ToString(dr["Sexo"]);
                    fisioterapeuta.Logradouro = Convert.ToString(dr["Logradouro"]);
                    fisioterapeuta.Numero = Convert.ToString(dr["Numero"]);
                    fisioterapeuta.Bairro = Convert.ToString(dr["Bairro"]);
                    fisioterapeuta.Cidade = Convert.ToString(dr["Cidade"]);
                    fisioterapeuta.Cep = Convert.ToString(dr["Cep"]);
                    fisioterapeuta.Estado = Convert.ToString(dr["Estado"]);
                    return View(fisioterapeuta);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public ActionResult Salvar(Fisioterapeuta fisioterapeuta)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "INSERT INTO tb_fisioterapeuta(Nome,Cpf,DataNascimento,Email,Celular,Crefito,Sexo,Logradouro,Numero,Bairro,Cidade,Cep,Estado) values (";
                StrQuery += "'" + fisioterapeuta.Nome + "', ";
                StrQuery += "'" + fisioterapeuta.Cpf + "', ";
                StrQuery += "'" + fisioterapeuta.DataNascimento + "', ";
                StrQuery += "'" + fisioterapeuta.Email + "', ";
                StrQuery += "'" + fisioterapeuta.Celular + "', ";
                StrQuery += "'" + fisioterapeuta.Crefito + "', ";
                StrQuery += "'" + fisioterapeuta.Sexo + "', ";
                StrQuery += "'" + fisioterapeuta.Logradouro + "', ";
                StrQuery += "'" + fisioterapeuta.Numero + "', ";
                StrQuery += "'" + fisioterapeuta.Bairro + "', ";
                StrQuery += "'" + fisioterapeuta.Cidade + "', ";
                StrQuery += "'" + fisioterapeuta.Cep + "', ";
                StrQuery += "'" + fisioterapeuta.Estado + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Atualizar(Fisioterapeuta fisioterapeuta)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "UPDATE tb_fisioterapeuta SET ";
                StrQuery += "Nome = '" + fisioterapeuta.Nome + "', ";
                StrQuery += "Cpf = '" + fisioterapeuta.Cpf + "', ";
                StrQuery += "DataNascimento = '" + fisioterapeuta.DataNascimento + "', ";
                StrQuery += "Email = '" + fisioterapeuta.Email + "', ";
                StrQuery += "Celular = '" + fisioterapeuta.Celular + "', ";
                StrQuery += "Crefito = '" + fisioterapeuta.Crefito + "', ";
                StrQuery += "Sexo = '" + fisioterapeuta.Sexo + "', ";
                StrQuery += "Logradouro = '" + fisioterapeuta.Logradouro + "', ";
                StrQuery += "Numero = '" + fisioterapeuta.Numero + "', ";
                StrQuery += "Bairro = '" + fisioterapeuta.Bairro + "', ";
                StrQuery += "Cidade = '" + fisioterapeuta.Cidade + "', ";
                StrQuery += "Cep = '" + fisioterapeuta.Cep + "', ";
                StrQuery += "Estado = '" + fisioterapeuta.Estado + "' ";
                StrQuery += "where Id = " + fisioterapeuta.Id + ";";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM tb_fisioterapeuta WHERE ";
            StrQuery += "id = " + Id + ";";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Fisioterapeuta fisioterapeuta = new Fisioterapeuta();
                    fisioterapeuta.Nome = Convert.ToString(dr["Nome"]);
                    fisioterapeuta.Cpf = Convert.ToString(dr["Cpf"]);
                    fisioterapeuta.DataNascimento = Convert.ToString(dr["DataNascimento"]);
                    fisioterapeuta.Email = Convert.ToString(dr["Email"]);
                    fisioterapeuta.Celular = Convert.ToString(dr["Celular"]);
                    fisioterapeuta.Crefito = Convert.ToString(dr["Crefito"]);
                    fisioterapeuta.Sexo = Convert.ToString(dr["Sexo"]);
                    fisioterapeuta.Logradouro = Convert.ToString(dr["Logradouro"]);
                    fisioterapeuta.Numero = Convert.ToString(dr["Numero"]);
                    fisioterapeuta.Bairro = Convert.ToString(dr["Bairro"]);
                    fisioterapeuta.Cidade = Convert.ToString(dr["Cidade"]);
                    fisioterapeuta.Cep = Convert.ToString(dr["Cep"]);
                    fisioterapeuta.Estado = Convert.ToString(dr["Estado"]);
                    return View(fisioterapeuta);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
        [HttpPost]
        public ActionResult Deletar(Fisioterapeuta fisioterapeuta)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Delete from tb_fisioterapeuta";
                StrQuery += " where Id = " + fisioterapeuta.Id + ";";

                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");


            }
        }
        public ActionResult DadosPessoais(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM tb_fisioterapeuta WHERE ";
            StrQuery += "id = " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Fisioterapeuta fisioterapeuta = new Fisioterapeuta();
                    fisioterapeuta.Nome = Convert.ToString(dr["Nome"]);
                    fisioterapeuta.Cpf = Convert.ToString(dr["Cpf"]);
                    fisioterapeuta.DataNascimento = Convert.ToString(dr["DataNascimento"]);
                    fisioterapeuta.Email = Convert.ToString(dr["Email"]);
                    fisioterapeuta.Celular = Convert.ToString(dr["Celular"]);
                    fisioterapeuta.Crefito = Convert.ToString(dr["Crefito"]);
                    fisioterapeuta.Sexo = Convert.ToString(dr["Sexo"]);
                    fisioterapeuta.Logradouro = Convert.ToString(dr["Logradouro"]);
                    fisioterapeuta.Numero = Convert.ToString(dr["Numero"]);
                    fisioterapeuta.Bairro = Convert.ToString(dr["Bairro"]);
                    fisioterapeuta.Cidade = Convert.ToString(dr["Cidade"]);
                    fisioterapeuta.Cep = Convert.ToString(dr["Cep"]);
                    fisioterapeuta.Estado = Convert.ToString(dr["Estado"]);
                    return View(fisioterapeuta);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
    }
}