using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unifisio_WebAplicação.Models;

namespace Unifisio_WebAplicação.Controllers
{
    public class ListaController : Controller
    {
        // GET: Lista
        public List<Sexo> ListaSexo()
        {
            List<Sexo> lstsexo = new List<Sexo>();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_sexo order by Descricao";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Sexo sexo = new Sexo()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Descricao = Convert.ToString(dr["Descricao"])
                    };
                    lstsexo.Add(sexo);
                }

            }
            return lstsexo;
        }

        public List<Estado> ListaUf()
        {
            List<Estado> lstuf = new List<Estado>();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_uf order by Estados";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Estado uf = new Estado()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Estados = Convert.ToString(dr["Estados"])
                    };
                    lstuf.Add(uf);
                }

            }
            return lstuf;
        }

        public List<EstadoCivil> ListaEstadoCivil()
        {
            List<EstadoCivil> lstestadocivil = new List<EstadoCivil>();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_estadocivil order by Definicao";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    EstadoCivil estadoCivil = new EstadoCivil()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Definicao = Convert.ToString(dr["Definicao"])
                    };
                    lstestadocivil.Add(estadoCivil);

                }
            }
            return lstestadocivil;
        }

        public List<TiposPlanos> ListaTiposPlanos()
        {
            List<TiposPlanos> lstplanos = new List<TiposPlanos>();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_tiposplanos order by Definicao";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    TiposPlanos tiposPlanos = new TiposPlanos()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Definicao = Convert.ToString(dr["Definicao"])
                    };
                    lstplanos.Add(tiposPlanos);

                }
            }
            return lstplanos;
        }

        public List<TipoUsuario> ListaTipoUsuario()
        {
            List<TipoUsuario> lstusuario = new List<TipoUsuario>();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_TipoUsuario order by Definicao";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    TipoUsuario tipoUsuario= new TipoUsuario()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Definicao = Convert.ToString(dr["Definicao"])
                    };
                    lstusuario.Add(tipoUsuario);

                }
            }
            return lstusuario;
        }

        public List<QtdIncontinencia> ListaQtd()
        {
            List<QtdIncontinencia> lstqtd = new List<QtdIncontinencia>();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_qtdincotinencia order by Id";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    QtdIncontinencia qtd = new QtdIncontinencia()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Descricao = Convert.ToString(dr["Descricao"])
                    };
                    lstqtd.Add(qtd);
                }

            }
            return lstqtd;
        }

        public List<Series> ListaSeries()
        {
            List<Series> lstseries = new List<Series>();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_series order by Id";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Series serie = new Series()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Definicao = Convert.ToString(dr["Definicao"])
                    };
                    lstseries.Add(serie);
                }


            }
            return lstseries;
        }

        public List<Intervalo> ListaIntervalo()
        {
            List<Intervalo> lstintervalo = new List<Intervalo>();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_intervalo order by Id";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Intervalo intervalo = new Intervalo()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Definicao = Convert.ToString(dr["Definicao"])
                    };
                    lstintervalo.Add(intervalo);
                }
            }
            return lstintervalo;
        }

        public List<Repeticao> ListaRepeticao()
        {
            List<Repeticao> lstRepeticao = new List<Repeticao>();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_Repeticao order by Id";
            using(MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Repeticao repeticao = new Repeticao()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Definicao = Convert.ToString(dr["Definicao"])
                    };
                    lstRepeticao.Add(repeticao);
                }
            }
            return lstRepeticao;
        }
    }
}