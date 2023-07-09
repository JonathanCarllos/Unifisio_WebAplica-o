using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unifisio_WebAplicação.Models;

namespace Unifisio_WebAplicação.Controllers
{
    public class LoginController : Controller
    {
        List<Usuario> lstusuario = new List<Usuario>();
        ListaController listaController = new ListaController();

        // GET: Login
        public ActionResult Index()
        {
            return View();


        }


        public ActionResult Homepage(Usuario usuario)
        {
            return View();
        }

        public ActionResult HomepageAdm(Usuario usuario)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Logado(Usuario usuario)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "select * from tb_logins where ";
            StrQuery += "Email = '" + usuario.Email + "' and ";
            StrQuery += "Senha = '" + usuario.Senha + "';";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    _=dr.Read();
                    Session["Tipousuario"] = Convert.ToString(dr["Tipousuario"]);
                    if (Session["Tipousuario"].ToString()== "Fisioterapeuta")
                    {
                        Session["Logado"] = "Sim";
                        return RedirectToAction("Homepage", usuario);
                    }
                    if (Session["Tipousuario"].ToString() == "Administrador")
                    {
                        Session["Logado"] = "Sim";
                        return RedirectToAction("HomepageAdm", usuario);
                    }
                    else
                    {
                        Session["Logado"] = "Sim";
                        return RedirectToAction("Homepage", usuario);
                    }

                }
                else
                {
                    Session["Logado"] = null;
                    return RedirectToAction("Index");
                }
               
            }
        }

        public ActionResult ListaUsuarios()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_logins order by Email";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Email = Convert.ToString(dr["Email"]),
                        Senha = Convert.ToString(dr["Senha"]),
                        Tipousuario = Convert.ToString(dr["TipoUsuario"])
                        
                    };
                    lstusuario.Add(usuario);
                }
                return View(lstusuario);

            }
        }

        public ActionResult Novo()
        {
            ViewBag.TipoUsuarios=listaController.ListaTipoUsuario();
            return View();
        }



        [HttpPost]
        public ActionResult Salvar(Usuario usuario)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "insert into tb_logins(Email,Senha,TipoUsuario) values(";
                StrQuery += "'" + usuario.Email + "',";
                StrQuery += "'" + usuario.Senha + "',";
                StrQuery += "'" + usuario.Tipousuario + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("ListaUsuarios");

            }

        }

        public ActionResult Editar(int Id)
        {
            ViewBag.TipoUsuarios = listaController.ListaTipoUsuario();
            Conexao conexao = new Conexao();
            String StrQuery = "Select * from tb_logins where ";
            StrQuery += "id = " + Id + ";";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Usuario usuario = new Usuario();
                    usuario.Email = Convert.ToString(dt["Email"]);
                    usuario.Senha = Convert.ToString(dt["Senha"]);
                    usuario.Tipousuario = Convert.ToString(dt["TipoUsuario"]);
                    return View(usuario);
                }
                else
                {
                    return RedirectToAction("ListaUsuarios");
                }
            }
        }

        [HttpPost]
        public ActionResult Atualizar(Usuario usuario)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Update  tb_logins set ";
                StrQuery += "Email= '" + usuario.Email + "', ";
                StrQuery += "Senha= '" + usuario.Senha + "', ";
                StrQuery += "TipoUsuario= '" + usuario.Tipousuario + "' ";
                StrQuery += "where Id = " + usuario.Id + ";";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("ListaUsuarios");

            }

        }

        public ActionResult Delete(int Id)
        {
            Conexao conexao = new Conexao();
            String StrQuery = "Select * from tb_logins where ";
            StrQuery += "id = " + Id + ";";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Usuario usuario = new Usuario();
                    usuario.Email = Convert.ToString(dt["Email"]);
                    usuario.Senha = Convert.ToString(dt["Senha"]);
                    usuario.Tipousuario = Convert.ToString(dt["TipoUsuario"]);
                    return View(usuario);
                }
                else
                {
                    return RedirectToAction("ListaUsuarios");
                }
            }
        }

        [HttpPost]
        public ActionResult Deletar(Usuario usuario)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Delete from tb_logins";
                StrQuery += " where Id = " + usuario.Id + ";";

                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("ListaUsuarios");


            }
        }
    }
}