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
    public class AlunoController : Controller
    {
        List<Aluno> lstAluno = new List<Aluno>();
        ListaController lista = new ListaController();

        public ActionResult Index()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM tb_aluno ORDER BY Nome";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Aluno aluno = new Aluno()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nome = Convert.ToString(dr["Nome"]),
                        Cpf = Convert.ToString(dr["Cpf"]),
                        DataNascimento = Convert.ToString(dr["DataNascimento"]),
                        Email = Convert.ToString(dr["Email"]),
                        Celular = Convert.ToString(dr["Celular"]),
                        Ra = Convert.ToString(dr["Ra"]),
                        Sexo = Convert.ToString(dr["Sexo"]),
                        Logradouro = Convert.ToString(dr["Logradouro"]),
                        Numero = Convert.ToString(dr["Numero"]),
                        Bairro = Convert.ToString(dr["Bairro"]),
                        Cidade = Convert.ToString(dr["Cidade"]),
                        Cep = Convert.ToString(dr["Cep"]),
                        Estado = Convert.ToString(dr["Estado"])

                    };
                    lstAluno.Add(aluno);
                }
            }
            return View(lstAluno);
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
            string StrQuery = "SELECT * FROM tb_aluno WHERE ";
            StrQuery += "Id = " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Aluno aluno = new Aluno();
                    aluno.Nome = Convert.ToString(dr["Nome"]);
                    aluno.Cpf = Convert.ToString(dr["Cpf"]);
                    aluno.DataNascimento = Convert.ToString(dr["DataNascimento"]);
                    aluno.Email = Convert.ToString(dr["Email"]);
                    aluno.Celular = Convert.ToString(dr["Celular"]);
                    aluno.Ra = Convert.ToString(dr["Ra"]);
                    aluno.Sexo = Convert.ToString(dr["Sexo"]);
                    aluno.Logradouro = Convert.ToString(dr["Logradouro"]);
                    aluno.Numero = Convert.ToString(dr["Numero"]);
                    aluno.Bairro = Convert.ToString(dr["Bairro"]);
                    aluno.Cidade = Convert.ToString(dr["Cidade"]);
                    aluno.Cep = Convert.ToString(dr["Cep"]);
                    aluno.Estado = Convert.ToString(dr["Estado"]);
                    return View(aluno);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public ActionResult Salvar(Aluno aluno)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "INSERT INTO tb_Aluno(Nome,Cpf,DataNascimento,Email,Celular,Ra,Sexo,Logradouro,Numero,Bairro,Cidade,Cep,Estado) values (";
                StrQuery += "'" + aluno.Nome + "', ";
                StrQuery += "'" + aluno.Cpf + "', ";
                StrQuery += "'" + aluno.DataNascimento + "', ";
                StrQuery += "'" + aluno.Email + "', ";
                StrQuery += "'" + aluno.Celular + "', ";
                StrQuery += "'" + aluno.Ra + "', ";
                StrQuery += "'" + aluno.Sexo + "', ";
                StrQuery += "'" + aluno.Logradouro + "', ";
                StrQuery += "'" + aluno.Numero + "', ";
                StrQuery += "'" + aluno.Bairro + "', ";
                StrQuery += "'" + aluno.Cidade + "', ";
                StrQuery += "'" + aluno.Cep + "', ";
                StrQuery += "'" + aluno.Estado + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Atualizar(Aluno aluno)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "UPDATE tb_aluno SET ";
                StrQuery += "Nome = '" + aluno.Nome + "', ";
                StrQuery += "Cpf = '" + aluno.Cpf + "', ";
                StrQuery += "DataNascimento = '" + aluno.DataNascimento + "', ";
                StrQuery += "Email = '" + aluno.Email + "', ";
                StrQuery += "Celular = '" + aluno.Celular + "', ";
                StrQuery += "Ra = '" + aluno.Ra + "', ";
                StrQuery += "Sexo = '" + aluno.Sexo + "', ";
                StrQuery += "Logradouro = '" + aluno.Logradouro + "', ";
                StrQuery += "Numero = '" + aluno.Numero + "', ";
                StrQuery += "Bairro = '" + aluno.Bairro + "', ";
                StrQuery += "Cidade = '" + aluno.Cidade + "', ";
                StrQuery += "Cep = '" + aluno.Cep + "', ";
                StrQuery += "Estado = '" + aluno.Estado + "' ";
                StrQuery += "where Id = " + aluno.Id + ";";
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
            string StrQuery = "SELECT * FROM tb_aluno WHERE ";
            StrQuery += "Id = " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Aluno aluno = new Aluno();
                    aluno.Nome = Convert.ToString(dr["Nome"]);
                    aluno.Cpf = Convert.ToString(dr["Cpf"]);
                    aluno.DataNascimento = Convert.ToString(dr["DataNascimento"]);
                    aluno.Email = Convert.ToString(dr["Email"]);
                    aluno.Celular = Convert.ToString(dr["Celular"]);
                    aluno.Ra = Convert.ToString(dr["Ra"]);
                    aluno.Sexo = Convert.ToString(dr["Sexo"]);
                    aluno.Logradouro = Convert.ToString(dr["Logradouro"]);
                    aluno.Numero = Convert.ToString(dr["Numero"]);
                    aluno.Bairro = Convert.ToString(dr["Bairro"]);
                    aluno.Cidade = Convert.ToString(dr["Cidade"]);
                    aluno.Cep = Convert.ToString(dr["Cep"]);
                    aluno.Estado = Convert.ToString(dr["Estado"]);
                    return View(aluno);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public ActionResult Deletar(Aluno aluno)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Delete from tb_aluno";
                StrQuery += " where Id = " + aluno.Id + ";";

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
            string StrQuery = "SELECT * FROM tb_aluno WHERE ";
            StrQuery += "Id = " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Aluno aluno = new Aluno();
                    aluno.Nome = Convert.ToString(dr["Nome"]);
                    aluno.Cpf = Convert.ToString(dr["Cpf"]);
                    aluno.DataNascimento = Convert.ToString(dr["DataNascimento"]);
                    aluno.Email = Convert.ToString(dr["Email"]);
                    aluno.Celular = Convert.ToString(dr["Celular"]);
                    aluno.Ra = Convert.ToString(dr["Ra"]);
                    aluno.Sexo = Convert.ToString(dr["Sexo"]);
                    aluno.Logradouro = Convert.ToString(dr["Logradouro"]);
                    aluno.Numero = Convert.ToString(dr["Numero"]);
                    aluno.Bairro = Convert.ToString(dr["Bairro"]);
                    aluno.Cidade = Convert.ToString(dr["Cidade"]);
                    aluno.Cep = Convert.ToString(dr["Cep"]);
                    aluno.Estado = Convert.ToString(dr["Estado"]);
                    return View(aluno);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
    }
}