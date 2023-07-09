using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unifisio_WebAplicação.Models;

namespace Unifisio_WebAplicação.Controllers
{
    public class PacienteController : Controller
    {
        List<Paciente> lstpaciente = new List<Paciente>();
        ListaController lista = new ListaController();
        // GET: Paciente
        public ActionResult Index()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente order by Nome";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Paciente paciente = new Paciente()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nome = Convert.ToString(dr["Nome"]),
                        CPF = Convert.ToString(dr["Cpf"]),
                        Celular = Convert.ToString(dr["Celular"]),
                        Sexo = Convert.ToString(dr["Sexo"]),
                        Profissao = Convert.ToString(dr["Profissao"]),
                        EstadoCivil = Convert.ToString(dr["EstadoCivil"]),
                        Logradouro = Convert.ToString(dr["Logradouro"]),
                        NumeroCasa = Convert.ToString(dr["NumeroCasa"]),
                        Bairro = Convert.ToString(dr["Bairro"]),
                        Cidade = Convert.ToString(dr["cidade"]),
                        Cep = Convert.ToString(dr["Cep"]),
                        Estado = Convert.ToString(dr["Estado"]),
                        DataNascimento = Convert.ToString(dr["DataNascimento"]),
                        Email = Convert.ToString(dr["Email"]),
                        Telefone = Convert.ToString(dr["Telefone"]),
                        CelularResponsavel = Convert.ToString(dr["CelularResponsavel"]),
                        NomeResponsavel = Convert.ToString(dr["NomeResponsavel"]),
                        CpfResponsavel = Convert.ToString(dr["CpfResponsavel"]),
                        //com convenio
                        RazaoSocial = Convert.ToString(dr["RazaoSocial"]),
                        Fisioterapeuta = Convert.ToString(dr["Fisioterapeuta"]),
                        Cnpj = Convert.ToString(dr["Cnpj"]),
                        TelefoneConv = Convert.ToString(dr["TelefoneConv"]),
                        LogradouroConv = Convert.ToString(dr["LogradouroConv"]),
                        Avaliador = Convert.ToString(dr["Avaliador"]),
                        NumeroConv = Convert.ToString(dr["NumeroConv"]),
                        BairroConv = Convert.ToString(dr["BairroConv"]),
                        CidadeConv = Convert.ToString(dr["CidadeConv"]),
                        CepConv = Convert.ToString(dr["CepConv"]),
                        UfConvenio = Convert.ToString(dr["UfConv"]),
                        TipoPlanos = Convert.ToString(dr["TipoPlanos"]),
                        ObsMedica = Convert.ToString(dr["ObsMedica"])

                    };
                    lstpaciente.Add(paciente);
                }
            }
            return View(lstpaciente);
        }

        public ActionResult Novo() //fazer tela
        {
            ViewBag.Sexo = lista.ListaSexo();
            ViewBag.Estados = lista.ListaUf();
            ViewBag.EstadoCivil = lista.ListaEstadoCivil();
            ViewBag.TiposPlanos = lista.ListaTiposPlanos();
            return View();
        }

        public ActionResult Editar(int Id) //feito
        {
            ViewBag.Sexo = lista.ListaSexo();
            ViewBag.Estados = lista.ListaUf();
            ViewBag.EstadoCivil = lista.ListaEstadoCivil();
            ViewBag.TiposPlanos = lista.ListaTiposPlanos();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente where ";
            StrQuery += "id= " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.Nome = Convert.ToString(dt["Nome"]);
                    paciente.CPF = Convert.ToString(dt["Cpf"]);
                    paciente.Celular = Convert.ToString(dt["Celular"]);
                    paciente.Sexo = Convert.ToString(dt["Sexo"]);
                    paciente.Profissao = Convert.ToString(dt["Profissao"]);
                    paciente.EstadoCivil = Convert.ToString(dt["EstadoCivil"]);
                    paciente.Logradouro = Convert.ToString(dt["Logradouro"]);
                    paciente.NumeroCasa = Convert.ToString(dt["NumeroCasa"]);
                    paciente.Bairro = Convert.ToString(dt["Bairro"]);
                    paciente.Cidade = Convert.ToString(dt["Cidade"]);
                    paciente.Cep = Convert.ToString(dt["Cep"]);
                    paciente.Estado = Convert.ToString(dt["Estado"]);
                    paciente.DataNascimento = Convert.ToString(dt["DataNascimento"]);
                    paciente.Email = Convert.ToString(dt["Email"]);
                    paciente.Telefone = Convert.ToString(dt["Telefone"]);
                    paciente.CelularResponsavel = Convert.ToString(dt["CelularResponsavel"]);
                    paciente.NomeResponsavel = Convert.ToString(dt["NomeResponsavel"]);
                    paciente.CpfResponsavel = Convert.ToString(dt["CpfResponsavel"]);
                    //com convenio
                    paciente.RazaoSocial = Convert.ToString(dt["RazaoSocial"]);
                    paciente.Fisioterapeuta = Convert.ToString(dt["Fisioterapeuta"]);
                    paciente.Cnpj = Convert.ToString(dt["Cnpj"]);
                    paciente.TelefoneConv = Convert.ToString(dt["TelefoneConv"]);
                    paciente.LogradouroConv = Convert.ToString(dt["LogradouroConv"]);
                    paciente.Avaliador = Convert.ToString(dt["Avaliador"]);
                    paciente.NumeroConv = Convert.ToString(dt["NumeroConv"]);
                    paciente.BairroConv = Convert.ToString(dt["BairroConv"]);
                    paciente.CidadeConv = Convert.ToString(dt["CidadeConv"]);
                    paciente.CepConv = Convert.ToString(dt["CepConv"]);
                    paciente.UfConvenio = Convert.ToString(dt["UfConv"]);
                    paciente.TipoPlanos = Convert.ToString(dt["TipoPlanos"]);
                    paciente.ObsMedica = Convert.ToString(dt["ObsMedica"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("Index");
                }

            }

        }

        [HttpPost]
        public ActionResult Salvar(Paciente paciente) //feito
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "insert into tb_paciente(Nome,Cpf,Celular,Sexo,Profissao,EstadoCivil,Logradouro,NumeroCasa,Bairro,Cidade,Cep,Estado,DataNascimento," +
                    "Email,Telefone,CelularResponsavel,NomeResponsavel,CpfResponsavel,RazaoSocial,Fisioterapeuta,Cnpj,TelefoneConv,LogradouroConv,Avaliador,NumeroConv,BairroConv,CidadeConv,CepConv,UfConv,TipoPlanos,ObsMedica) values(";
                StrQuery += "'" + paciente.Nome + "',";
                StrQuery += "'" + paciente.CPF + "',";
                StrQuery += "'" + paciente.Celular + "',";
                StrQuery += "'" + paciente.Sexo + "',";
                StrQuery += "'" + paciente.Profissao + "',";
                StrQuery += "'" + paciente.EstadoCivil + "',";
                StrQuery += "'" + paciente.Logradouro + "',";
                StrQuery += "'" + paciente.NumeroCasa + "',";
                StrQuery += "'" + paciente.Bairro + "',";
                StrQuery += "'" + paciente.Cidade + "',";
                StrQuery += "'" + paciente.Cep + "',";
                StrQuery += "'" + paciente.Estado + "',";
                StrQuery += "'" + paciente.DataNascimento + "',";
                StrQuery += "'" + paciente.Email + "',";
                StrQuery += "'" + paciente.Telefone + "',";
                StrQuery += "'" + paciente.CelularResponsavel + "',";
                StrQuery += "'" + paciente.NomeResponsavel + "',";
                StrQuery += "'" + paciente.CpfResponsavel + "',";
                StrQuery += "'" + paciente.RazaoSocial + "',";
                StrQuery += "'" + paciente.Fisioterapeuta + "',";
                StrQuery += "'" + paciente.Cnpj + "',";
                StrQuery += "'" + paciente.TelefoneConv + "',";
                StrQuery += "'" + paciente.LogradouroConv + "',";
                StrQuery += "'" + paciente.Avaliador + "',";
                StrQuery += "'" + paciente.NumeroConv + "',";
                StrQuery += "'" + paciente.BairroConv + "',";
                StrQuery += "'" + paciente.CidadeConv + "',";
                StrQuery += "'" + paciente.CepConv + "',";
                StrQuery += "'" + paciente.UfConvenio + "',";
                StrQuery += "'" + paciente.TipoPlanos + "',";
                StrQuery += "'" + paciente.ObsMedica + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");

            }

        }

        [HttpPost]
        public ActionResult Atualizar(Paciente paciente)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Update tb_paciente set ";
                StrQuery += "Nome = '" + paciente.Nome + "',";
                StrQuery += "Cpf = '" + paciente.CPF + "',";
                StrQuery += "Celular = '" + paciente.Celular + "',";
                StrQuery += "Sexo = '" + paciente.Sexo + "',";
                StrQuery += "Profissao = '" + paciente.Profissao + "',";
                StrQuery += "EstadoCivil = '" + paciente.EstadoCivil + "',";
                StrQuery += "Logradouro = '" + paciente.Logradouro + "',";
                StrQuery += "NumeroCasa = '" + paciente.NumeroCasa + "',";
                StrQuery += "Bairro = '" + paciente.Bairro + "',";
                StrQuery += "Cidade = '" + paciente.Cidade + "',";
                StrQuery += "Cep = '" + paciente.Cep + "',";
                StrQuery += "Estado = '" + paciente.Estado + "',";
                StrQuery += "DataNascimento = '" + paciente.DataNascimento + "',";
                StrQuery += "Email = '" + paciente.Email + "',";
                StrQuery += "Telefone = '" + paciente.Telefone + "',";
                StrQuery += "CelularResponsavel = '" + paciente.CelularResponsavel + "',";
                StrQuery += "NomeResponsavel = '" + paciente.NomeResponsavel + "',";
                StrQuery += "CpfResponsavel = '" + paciente.CpfResponsavel + "',";
                StrQuery += "RazaoSocial = '" + paciente.RazaoSocial + "',";
                StrQuery += "Fisioterapeuta = '" + paciente.Fisioterapeuta + "',";
                StrQuery += "Cnpj ='" + paciente.Cnpj + "',";
                StrQuery += "TelefoneConv = '" + paciente.TelefoneConv + "',";
                StrQuery += "LogradouroConv = '" + paciente.LogradouroConv + "',";
                StrQuery += "Avaliador = '" + paciente.Avaliador + "',";
                StrQuery += "NumeroConv = '" + paciente.NumeroConv + "',";
                StrQuery += "BairroConv = '" + paciente.BairroConv + "',";
                StrQuery += "CidadeConv = '" + paciente.CidadeConv + "',";
                StrQuery += "CepConv = '" + paciente.CepConv + "',";
                StrQuery += "UfConv = '" + paciente.UfConvenio + "',";
                StrQuery += "TipoPlanos = '" + paciente.TipoPlanos + "',";
                StrQuery += "ObsMedica = '" + paciente.ObsMedica + "' ";
                StrQuery += " where Id = " + paciente.Id + ";";

                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");

            }
        }

        public ActionResult Delete(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente where";
            StrQuery += " Id=" + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.Nome = Convert.ToString(dt["Nome"]);
                    paciente.CPF = Convert.ToString(dt["Cpf"]);
                    paciente.Celular = Convert.ToString(dt["Celular"]);
                    paciente.Sexo = Convert.ToString(dt["Sexo"]);
                    paciente.Profissao = Convert.ToString(dt["Profissao"]);
                    paciente.EstadoCivil = Convert.ToString(dt["EstadoCivil"]);
                    paciente.Logradouro = Convert.ToString(dt["Logradouro"]);
                    paciente.NumeroCasa = Convert.ToString(dt["NumeroCasa"]);
                    paciente.Bairro = Convert.ToString(dt["Bairro"]);
                    paciente.Cidade = Convert.ToString(dt["Cidade"]);
                    paciente.Cep = Convert.ToString(dt["Cep"]);
                    paciente.Estado = Convert.ToString(dt["Estado"]);
                    paciente.DataNascimento = Convert.ToString(dt["DataNAscimento"]);
                    paciente.Email = Convert.ToString(dt["Email"]);
                    paciente.Telefone = Convert.ToString(dt["Telefone"]);
                    paciente.CelularResponsavel = Convert.ToString(dt["CelularResponsavel"]);
                    paciente.NomeResponsavel = Convert.ToString(dt["NomeResponsavel"]);
                    paciente.CpfResponsavel = Convert.ToString(dt["CpfResponsavel"]);
                    //com convenio
                    paciente.RazaoSocial = Convert.ToString(dt["RazaoSocial"]);
                    paciente.Fisioterapeuta = Convert.ToString(dt["Fisioterapeuta"]);
                    paciente.Cnpj = Convert.ToString(dt["Cnpj"]);
                    paciente.TelefoneConv = Convert.ToString(dt["TelefoneConv"]);
                    paciente.LogradouroConv = Convert.ToString(dt["LogradouroConv"]);
                    paciente.Avaliador = Convert.ToString(dt["Avaliador"]);
                    paciente.NumeroConv = Convert.ToString(dt["NumeroConv"]);
                    paciente.CidadeConv = Convert.ToString(dt["CidadeConv"]);
                    paciente.CepConv = Convert.ToString(dt["CepConv"]);
                    paciente.UfConvenio = Convert.ToString(dt["UfConv"]);
                    paciente.TipoPlanos = Convert.ToString(dt["TipoPlanos"]);
                    paciente.ObsMedica = Convert.ToString(dt["ObsMedica"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("Index");
                }

            }

        }



        [HttpPost]
        public ActionResult Deletar(Paciente paciente)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Delete from tb_paciente";
                StrQuery += " where Id = " + paciente.Id + ";";

                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");


            }
        }

        public ActionResult DadosPessoais(int Id) //atualizada
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente where ";
            StrQuery += "Id= " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.Nome = Convert.ToString(dt["Nome"]);
                    paciente.CPF = Convert.ToString(dt["Cpf"]);
                    paciente.Celular = Convert.ToString(dt["Celular"]);
                    paciente.Sexo = Convert.ToString(dt["Sexo"]);
                    paciente.Profissao = Convert.ToString(dt["Profissao"]);
                    paciente.EstadoCivil = Convert.ToString(dt["EstadoCivil"]);
                    paciente.Logradouro = Convert.ToString(dt["Logradouro"]);
                    paciente.NumeroCasa = Convert.ToString(dt["NumeroCasa"]);
                    paciente.Bairro = Convert.ToString(dt["Bairro"]);
                    paciente.Cidade = Convert.ToString(dt["Cidade"]);
                    paciente.Cep = Convert.ToString(dt["Cep"]);
                    paciente.Estado = Convert.ToString(dt["Estado"]);
                    paciente.DataNascimento = Convert.ToString(dt["DataNAscimento"]);
                    paciente.Email = Convert.ToString(dt["Email"]);
                    paciente.Telefone = Convert.ToString(dt["Telefone"]);
                    paciente.CelularResponsavel = Convert.ToString(dt["CelularResponsavel"]);
                    paciente.NomeResponsavel = Convert.ToString(dt["NomeResponsavel"]);
                    paciente.CpfResponsavel = Convert.ToString(dt["CpfResponsavel"]);
                    //com convenio
                    paciente.RazaoSocial = Convert.ToString(dt["RazaoSocial"]);
                    paciente.Fisioterapeuta = Convert.ToString(dt["Fisioterapeuta"]);
                    paciente.Cnpj = Convert.ToString(dt["Cnpj"]);
                    paciente.TelefoneConv = Convert.ToString(dt["TelefoneConv"]);
                    paciente.LogradouroConv = Convert.ToString(dt["LogradouroConv"]);
                    paciente.Avaliador = Convert.ToString(dt["Avaliador"]);
                    paciente.NumeroConv = Convert.ToString(dt["NumeroConv"]);
                    paciente.BairroConv = Convert.ToString(dt["BairroConv"]);
                    paciente.CidadeConv = Convert.ToString(dt["CidadeConv"]);
                    paciente.CepConv = Convert.ToString(dt["CepConv"]);
                    paciente.UfConvenio = Convert.ToString(dt["UfConv"]);
                    paciente.TipoPlanos = Convert.ToString(dt["TipoPlanos"]);
                    paciente.ObsMedica = Convert.ToString(dt["ObsMedica"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("Index");
                }

            }

        }

        public ActionResult ListaExercicios()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente order by Nome";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Paciente paciente = new Paciente()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nome = Convert.ToString(dr["Nome"]),
                        Perguntar = Convert.ToString(dr["Pergunta"])
                    };
                    lstpaciente.Add(paciente);
                }
            }
            return View(lstpaciente);
        }

        public ActionResult EnviarExercicios(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente where ";
            StrQuery += "id= " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.Perguntar = Convert.ToString(dt["Pergunta"]);
                    paciente.Pergunta2 = Convert.ToString(dt["Pergunta2"]);
                    paciente.Pergunta3 = Convert.ToString(dt["Pergunta3"]);
                    paciente.Pergunta4 = Convert.ToString(dt["Pergunta4"]);
                    paciente.Pergunta5 = Convert.ToString(dt["Pergunta5"]);
                
                    paciente.Series = Convert.ToString(dt["Series"]);
                    paciente.Series2 = Convert.ToString(dt["Series2"]);
                    paciente.Series3 = Convert.ToString(dt["Series3"]);
                    paciente.Series4 = Convert.ToString(dt["Series4"]);
                    paciente.Series5 = Convert.ToString(dt["Series5"]);
                    paciente.Series6 = Convert.ToString(dt["Series6"]);
                    paciente.Series7 = Convert.ToString(dt["Series7"]);
                    paciente.Series8 = Convert.ToString(dt["Series8"]);
                    paciente.Intervalos = Convert.ToString(dt["Intervalos"]);
                    paciente.Intervalos2 = Convert.ToString(dt["Intervalos2"]);
                    paciente.Intervalos3 = Convert.ToString(dt["Intervalos3"]);
                    paciente.Intervalos4 = Convert.ToString(dt["Intervalos4"]);
                    paciente.Intervalos5 = Convert.ToString(dt["Intervalos5"]);
                    paciente.Intervalos6 = Convert.ToString(dt["Intervalos6"]);
                    paciente.Intervalos7 = Convert.ToString(dt["Intervalos7"]);
                    paciente.Intervalos8 = Convert.ToString(dt["Intervalos8"]);
                    paciente.Data = Convert.ToString(dt["DataExer"]);
                    paciente.Hora = Convert.ToString(dt["Hora"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("ListaExercicios");
                }

            }

        }

        [HttpPost]
        public ActionResult EnviarMensagem(Paciente paciente)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Update tb_paciente set ";
                StrQuery += "Pergunta = '" + paciente.Perguntar + "', ";
                StrQuery += "Pergunta2 = '" + paciente.Pergunta2 + "', ";
                StrQuery += "Pergunta3 = '" + paciente.Pergunta3 + "', ";
                StrQuery += "Pergunta4 = '" + paciente.Pergunta4 + "', ";
                StrQuery += "Pergunta5 = '" + paciente.Pergunta5 + "', ";
                StrQuery += "Series = '" + paciente.Series + "', ";
                StrQuery += "Series2 = '" + paciente.Series2 + "', ";
                StrQuery += "Series3 = '" + paciente.Series3 + "', ";
                StrQuery += "Series4 = '" + paciente.Series4 + "', ";
                StrQuery += "Series5 = '" + paciente.Series5 + "', ";
                StrQuery += "Series6 = '" + paciente.Series6 + "', ";
                StrQuery += "Series7 = '" + paciente.Series7 + "', ";
                StrQuery += "Series8 = '" + paciente.Series8 + "', ";
                StrQuery += "Intervalos = '" + paciente.Intervalos + "', ";
                StrQuery += "Intervalos2 = '" + paciente.Intervalos2 + "', ";
                StrQuery += "Intervalos3 = '" + paciente.Intervalos3 + "', ";
                StrQuery += "Intervalos4 = '" + paciente.Intervalos4 + "', ";
                StrQuery += "Intervalos5 = '" + paciente.Intervalos5 + "', ";
                StrQuery += "Intervalos6 = '" + paciente.Intervalos6 + "', ";
                StrQuery += "Intervalos7 = '" + paciente.Intervalos7 + "', ";
                StrQuery += "Intervalos8 = '" + paciente.Intervalos8 + "', ";
                StrQuery += "Reperticoes = '" + paciente.Repeticoes + "', ";
                StrQuery += "Reperticoes2 = '" + paciente.Repeticoes2 + "', ";
                StrQuery += "Reperticoes3 = '" + paciente.Repeticoes3 + "', ";
                StrQuery += "Reperticoes4 = '" + paciente.Repeticoes4 + "', ";
                StrQuery += "Reperticoes5 = '" + paciente.Repeticoes5 + "', ";
                StrQuery += "Reperticoes6 = '" + paciente.Repeticoes6 + "', ";
                StrQuery += "Reperticoes7 = '" + paciente.Repeticoes7 + "', ";
                StrQuery += "Reperticoes8 = '" + paciente.Repeticoes8 + "', ";
                StrQuery += "DataExer = '" + paciente.Data + "', ";
                StrQuery += "Hora = '" + paciente.Hora + "' ";
                StrQuery += " where Id = " + paciente.Id + ";";

                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("ListaExercicios");

            }
        }

        public ActionResult DadosExercicios(int id) //atualizado
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_exercicios where ";
            StrQuery += "Id= " + id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.IdExercicio = Convert.ToInt32(dt["Id"]);
                    paciente.Exercicios1 = Convert.ToString(dt["Exercicios1"]);
                    paciente.Repeticoes = Convert.ToString(dt["Reperticoes1"]);
                    paciente.Intervalos = Convert.ToString(dt["Intervalos1"]);
                    paciente.Series = Convert.ToString(dt["Series1"]);
                    paciente.Exercicios2 = Convert.ToString(dt["Exercicios2"]);
                    paciente.Repeticoes2 = Convert.ToString(dt["Reperticoes2"]);
                    paciente.Intervalos2 = Convert.ToString(dt["Intervalos2"]);
                    paciente.Series2 = Convert.ToString(dt["Series2"]);
                    paciente.Exercicios3 = Convert.ToString(dt["Exercicios3"]);
                    paciente.Repeticoes3 = Convert.ToString(dt["Reperticoes3"]);
                    paciente.Intervalos3 = Convert.ToString(dt["Intervalos3"]);
                    paciente.Series3 = Convert.ToString(dt["Series3"]);
                    paciente.Exercicios4 = Convert.ToString(dt["Exercicios4"]);
                    paciente.Repeticoes4 = Convert.ToString(dt["Reperticoes4"]);
                    paciente.Intervalos4 = Convert.ToString(dt["Intervalos4"]);
                    paciente.Series4 = Convert.ToString(dt["Series4"]);
                    paciente.Exercicios5 = Convert.ToString(dt["Exercicios5"]);
                    paciente.Repeticoes5 = Convert.ToString(dt["Reperticoes5"]);
                    paciente.Intervalos5 = Convert.ToString(dt["Intervalos5"]);
                    paciente.Series5 = Convert.ToString(dt["Series5"]);
                    paciente.Exercicios6 = Convert.ToString(dt["Exercicios6"]);
                    paciente.Repeticoes6 = Convert.ToString(dt["Reperticoes6"]);
                    paciente.Intervalos6 = Convert.ToString(dt["Intervalos6"]);
                    paciente.Series6 = Convert.ToString(dt["Series6"]);
                    paciente.Exercicios7 = Convert.ToString(dt["Exercicios7"]);
                    paciente.Repeticoes7 = Convert.ToString(dt["Reperticoes7"]);
                    paciente.Intervalos7 = Convert.ToString(dt["Intervalos7"]);
                    paciente.Series7 = Convert.ToString(dt["Series7"]);
                    paciente.Exercicios8 = Convert.ToString(dt["Exercicios8"]);
                    paciente.Repeticoes8 = Convert.ToString(dt["Reperticoes8"]);
                    paciente.Intervalos8 = Convert.ToString(dt["Intervalos8"]);
                    paciente.Series8 = Convert.ToString(dt["Series8"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("ListaExercicios");
                }

            }
        }

        public ActionResult DadosExercicios2(int id) //atualizado
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_exercicios where ";
            StrQuery += "Id= " + id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.IdExercicio = Convert.ToInt32(dt["Id"]);
                    paciente.Exercicios1 = Convert.ToString(dt["Exercicios1"]);
                    paciente.Repeticoes = Convert.ToString(dt["Reperticoes1"]);
                    paciente.Intervalos = Convert.ToString(dt["Intervalos1"]);
                    paciente.Series = Convert.ToString(dt["Series1"]);
                    paciente.Exercicios2 = Convert.ToString(dt["Exercicios2"]);
                    paciente.Repeticoes2 = Convert.ToString(dt["Reperticoes2"]);
                    paciente.Intervalos2 = Convert.ToString(dt["Intervalos2"]);
                    paciente.Series2 = Convert.ToString(dt["Series2"]);
                    paciente.Exercicios3 = Convert.ToString(dt["Exercicios3"]);
                    paciente.Repeticoes3 = Convert.ToString(dt["Reperticoes3"]);
                    paciente.Intervalos3 = Convert.ToString(dt["Intervalos3"]);
                    paciente.Series3 = Convert.ToString(dt["Series3"]);
                    paciente.Exercicios4 = Convert.ToString(dt["Exercicios4"]);
                    paciente.Repeticoes4 = Convert.ToString(dt["Reperticoes4"]);
                    paciente.Intervalos4 = Convert.ToString(dt["Intervalos4"]);
                    paciente.Series4 = Convert.ToString(dt["Series4"]);
                    paciente.Exercicios5 = Convert.ToString(dt["Exercicios5"]);
                    paciente.Repeticoes5 = Convert.ToString(dt["Reperticoes5"]);
                    paciente.Intervalos5 = Convert.ToString(dt["Intervalos5"]);
                    paciente.Series5 = Convert.ToString(dt["Series5"]);
                    paciente.Exercicios6 = Convert.ToString(dt["Exercicios6"]);
                    paciente.Repeticoes6 = Convert.ToString(dt["Reperticoes6"]);
                    paciente.Intervalos6 = Convert.ToString(dt["Intervalos6"]);
                    paciente.Series6 = Convert.ToString(dt["Series6"]);
                    paciente.Exercicios7 = Convert.ToString(dt["Exercicios7"]);
                    paciente.Repeticoes7 = Convert.ToString(dt["Reperticoes7"]);
                    paciente.Intervalos7 = Convert.ToString(dt["Intervalos7"]);
                    paciente.Series7 = Convert.ToString(dt["Series7"]);
                    paciente.Exercicios8 = Convert.ToString(dt["Exercicios8"]);
                    paciente.Repeticoes8 = Convert.ToString(dt["Reperticoes8"]);
                    paciente.Intervalos8 = Convert.ToString(dt["Intervalos8"]);
                    paciente.Series8 = Convert.ToString(dt["Series8"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("ListaExercicios");
                }

            }
        }

        public ActionResult LoginPaciente()
        {
            return View();
        }

        public ActionResult Homepage(Paciente paciente)
        {
            return View();
        }

        [HttpPost]
        public ActionResult PacienteLogado(Paciente paciente)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "select * from tb_paciente where ";
            StrQuery += "Email = '" + paciente.Email + "' and ";
            StrQuery += "Senha = '" + paciente.Senha + "';";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    Session["Logado"] = "Sim";
                    dr.Read();
                    Session["Id"] = Convert.ToInt32(dr["Id"]);
                    paciente.Id = Convert.ToInt32(dr["Id"]);
                    return RedirectToAction("Homepage", paciente);
                }
                else
                {
                    Session["Logado"] = null;
                    return RedirectToAction("LoginPaciente");
                }

            }

        }

        public ActionResult DadosExerciciosPaciente(Paciente paciente2)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_exercicios where ";
            StrQuery += "Id= " + paciente2.Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.Exercicios1 = Convert.ToString(dt["Exercicio1"]);
                    paciente.Repeticoes = Convert.ToString(dt["Reperticoes1"]);
                    paciente.Intervalos = Convert.ToString(dt["Intervalos1"]);
                    paciente.Series = Convert.ToString(dt["Series1"]);
                    paciente.Exercicios2 = Convert.ToString(dt["Exercicio2"]);
                    paciente.Repeticoes2 = Convert.ToString(dt["Reperticoes2"]);
                    paciente.Intervalos2 = Convert.ToString(dt["Intervalos2"]);
                    paciente.Series2 = Convert.ToString(dt["Series2"]);
                    paciente.Exercicios3 = Convert.ToString(dt["Exercicio3"]);
                    paciente.Repeticoes3 = Convert.ToString(dt["Reperticoes3"]);
                    paciente.Intervalos3 = Convert.ToString(dt["Intervalos3"]);
                    paciente.Series3 = Convert.ToString(dt["Series3"]);
                    paciente.Exercicios4 = Convert.ToString(dt["Exercicio4"]);
                    paciente.Repeticoes4 = Convert.ToString(dt["Reperticoes4"]);
                    paciente.Intervalos4 = Convert.ToString(dt["Intervalos4"]);
                    paciente.Series4 = Convert.ToString(dt["Series4"]);
                    paciente.Exercicios5 = Convert.ToString(dt["Exercicio5"]);
                    paciente.Repeticoes5 = Convert.ToString(dt["Reperticoes5"]);
                    paciente.Intervalos5 = Convert.ToString(dt["Intervalos5"]);
                    paciente.Series5 = Convert.ToString(dt["Series5"]);
                    paciente.Exercicios6 = Convert.ToString(dt["Exercicio6"]);
                    paciente.Repeticoes6 = Convert.ToString(dt["Reperticoes6"]);
                    paciente.Intervalos6 = Convert.ToString(dt["Intervalos6"]);
                    paciente.Series6 = Convert.ToString(dt["Series6"]);
                    paciente.Exercicios7 = Convert.ToString(dt["Exercicio7"]);
                    paciente.Repeticoes7 = Convert.ToString(dt["Reperticoes7"]);
                    paciente.Intervalos7 = Convert.ToString(dt["Intervalos7"]);
                    paciente.Series7 = Convert.ToString(dt["Series7"]);
                    paciente.Exercicios8 = Convert.ToString(dt["Exercicio8"]);
                    paciente.Repeticoes8 = Convert.ToString(dt["Reperticoes8"]);
                    paciente.Intervalos8 = Convert.ToString(dt["Intervalos8"]);
                    paciente.Series8 = Convert.ToString(dt["Series8"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("ListaExercicios");
                }

            }
        }

        public ActionResult DadosPaciente(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente where ";
            StrQuery += "Id= " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.Nome = Convert.ToString(dt["Nome"]);
                    paciente.CPF = Convert.ToString(dt["Cpf"]);
                    paciente.Celular = Convert.ToString(dt["Celular"]);
                    paciente.Sexo = Convert.ToString(dt["Sexo"]);
                    paciente.Profissao = Convert.ToString(dt["Profissao"]);
                    paciente.EstadoCivil = Convert.ToString(dt["EstadoCivil"]);
                    paciente.Logradouro = Convert.ToString(dt["Logradouro"]);
                    paciente.NumeroCasa = Convert.ToString(dt["NumeroCasa"]);
                    paciente.Bairro = Convert.ToString(dt["Bairro"]);
                    paciente.Cidade = Convert.ToString(dt["Cidade"]);
                    paciente.Cep = Convert.ToString(dt["Cep"]);
                    paciente.Estado = Convert.ToString(dt["Estado"]);
                    paciente.DataNascimento = Convert.ToString(dt["DataNAscimento"]);
                    paciente.Email = Convert.ToString(dt["Email"]);
                    paciente.Telefone = Convert.ToString(dt["Telefone"]);
                    paciente.CelularResponsavel = Convert.ToString(dt["CelularResponsavel"]);
                    paciente.NomeResponsavel = Convert.ToString(dt["NomeResponsavel"]);
                    paciente.CpfResponsavel = Convert.ToString(dt["CpfResponsavel"]);
                    //com convenio
                    paciente.RazaoSocial = Convert.ToString(dt["RazaoSocial"]);
                    paciente.Cnpj = Convert.ToString(dt["Cnpj"]);
                    paciente.TelefoneConv = Convert.ToString(dt["TelefoneConv"]);
                    paciente.LogradouroConv = Convert.ToString(dt["LogradouroConv"]);
                    paciente.NumeroConv = Convert.ToString(dt["NumeroConv"]);
                    paciente.CidadeConv = Convert.ToString(dt["CidadeConv"]);
                    paciente.CepConv = Convert.ToString(dt["CepConv"]);
                    paciente.UfConvenio = Convert.ToString(dt["UfConv"]);
                    paciente.TipoPlanos = Convert.ToString(dt["TipoPlanos"]);
                    paciente.ObsMedica = Convert.ToString(dt["ObsMedica"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("Index");
                }

            }
        }

        public ActionResult Relatorio(int Id)
        {
            ViewBag.Qtd = lista.ListaQtd();
            return View();
        }

        

        [HttpPost]
        public ActionResult SalvarRelatorio(Paciente paciente)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "insert into tb_relatorio(Relatorio,QtdRelatorio,DataRelatorio,ExerciciosFeitos,IdPaciente) values (";
                StrQuery += "'" + paciente.Relatorio + "', ";
                StrQuery += "'" + paciente.QtdRelatorio + "', ";
                StrQuery += "now(), ";
                StrQuery += "'" + paciente.ExercicioFeitos + "',";
                StrQuery += paciente.Id + ");";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Homepage");

            }

        }

        public ActionResult RelatorioDados(int Id)
        {
            ViewBag.Qtd = lista.ListaQtd();
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_relatorio where ";
            StrQuery += "IdPaciente= " + Id + ";";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.DataRelatorio = Convert.ToString(dt["DataRelatorio"]);
                    paciente.QtdRelatorio = Convert.ToString(dt["QtdRelatorio"]);
                    paciente.Relatorio = Convert.ToString(dt["Relatorio"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("Homepage");
                }

            }
        }

        public ActionResult ListaRelatorio()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente order by Nome";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Paciente paciente = new Paciente()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nome = Convert.ToString(dr["Nome"])
                    };
                    lstpaciente.Add(paciente);
                }
            }
            return View(lstpaciente);
        }

        public ActionResult RelatorioDetalhes(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente where ";
            StrQuery += "id= " + Id + ";";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    Paciente paciente = new Paciente();
                    paciente.Nome = Convert.ToString(dt["Nome"]);
                    paciente.DataRelatorio = Convert.ToString(dt["DataRelatorio"]);
                    paciente.QtdRelatorio = Convert.ToString(dt["QtdRelatorio"]);
                    paciente.Relatorio = Convert.ToString(dt["Relatorio"]);

                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("Homepage");
                }

            }
        }

        public ActionResult ListaUsuario()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente order by Nome ";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Paciente paciente = new Paciente()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nome = Convert.ToString(dr["Nome"])
                    };
                    lstpaciente.Add(paciente);
                }
            }
            return View(lstpaciente);
        }

        public ActionResult LoginPacienteNovo(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente where ";
            StrQuery += "Id= " + Id + ";";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Paciente paciente = new Paciente();
                    paciente.Email = Convert.ToString(dr["Email"]);
                    paciente.Senha = Convert.ToString(dr["Senha"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("ListaUsuario");
                }
            }
        }

        [HttpPost]
        public ActionResult SalvarSenha(Paciente paciente)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Update tb_paciente set ";
                StrQuery += "Email= '" + paciente.Email + "', ";
                StrQuery += "Senha= '" + paciente.Senha + "' ";
                StrQuery += "where Id= " + paciente.Id + ";";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
            }
            return RedirectToAction("ListaUsuario");

        }

        public ActionResult LoginDetalhes(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from tb_paciente where ";
            StrQuery += "Id=" + Id + ";";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Paciente paciente = new Paciente();
                    paciente.Email = Convert.ToString(dr["Email"]);
                    paciente.Senha = Convert.ToString(dr["Senha"]);
                    return View(paciente);
                }
                else
                {
                    return RedirectToAction("ListaUsuario");
                }
            }
        }
        public ActionResult ListaRelatorio2(int id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = $"Select * from tb_relatorio where IdPaciente ={id}";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Paciente paciente = new Paciente()
                    {
                        Id = Convert.ToInt32(dr["IdPaciente"]),
                        Relatorio = Convert.ToString(dr["Relatorio"]),
                        DataRelatorio = Convert.ToString(dr["DataRelatorio"]),
                        QtdRelatorio = Convert.ToString(dr["QtdRelatorio"]),
                        ExercicioFeitos = Convert.ToString(dr["ExerciciosFeitos"])
                    };
                    lstpaciente.Add(paciente);
                }
            }
            return View(lstpaciente);
        }

        public ActionResult ListaExercicios2(int id)
        {
            Conexao conexao = new Conexao();
            string Strquery = $"Select * from tb_Exercicios where IdPaciente={id}";
            using (MySqlCommand comando = new MySqlCommand(Strquery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Paciente paciente = new Paciente()
                    {
                        Id = Convert.ToInt32(dr["IdPaciente"]),
                        IdExercicio = Convert.ToInt32(dr["Id"]),
                        Exercicios1 = Convert.ToString(dr["Exercicios1"]),
                        Exercicios2 = Convert.ToString(dr["Exercicios2"]),
                        Exercicios3 = Convert.ToString(dr["Exercicios3"]),
                        Exercicios4 = Convert.ToString(dr["Exercicios4"]),
                        Exercicios5 = Convert.ToString(dr["Exercicios5"]),
                        Exercicios6 = Convert.ToString(dr["Exercicios6"]),
                        Exercicios7 = Convert.ToString(dr["Exercicios7"]),
                        Exercicios8 = Convert.ToString(dr["Exercicios8"]),
                        Series = Convert.ToString(dr["Series1"]),
                        Series2 = Convert.ToString(dr["Series2"]),
                        Series3 = Convert.ToString(dr["Series3"]),
                        Series4 = Convert.ToString(dr["Series4"]),
                        Series5 = Convert.ToString(dr["Series5"]),
                        Series6 = Convert.ToString(dr["Series6"]),
                        Series7 = Convert.ToString(dr["Series7"]),
                        Series8 = Convert.ToString(dr["Series8"]),
                        Intervalos = Convert.ToString(dr["Intervalos1"]),
                        Intervalos2 = Convert.ToString(dr["Intervalos2"]),
                        Intervalos3 = Convert.ToString(dr["Intervalos3"]),
                        Intervalos4 = Convert.ToString(dr["Intervalos4"]),
                        Intervalos5 = Convert.ToString(dr["Intervalos5"]),
                        Intervalos6 = Convert.ToString(dr["Intervalos6"]),
                        Intervalos7 = Convert.ToString(dr["Intervalos7"]),
                        Intervalos8 = Convert.ToString(dr["Intervalos8"]),
                        Repeticoes = Convert.ToString(dr["Reperticoes1"]),
                        Repeticoes2 = Convert.ToString(dr["Reperticoes2"]),
                        Repeticoes3 = Convert.ToString(dr["Reperticoes3"]),
                        Repeticoes4 = Convert.ToString(dr["Reperticoes4"]),
                        Repeticoes5 = Convert.ToString(dr["Reperticoes5"]),
                        Repeticoes6 = Convert.ToString(dr["Reperticoes6"]),
                        Repeticoes7 = Convert.ToString(dr["Reperticoes7"]),
                        Repeticoes8 = Convert.ToString(dr["Reperticoes8"]),
                        DataExercicios = Convert.ToString(dr["DataExercicio"]),
                        Secao = Convert.ToString(dr["Secao"])
                    };
                    lstpaciente.Add(paciente);
                }
            }
            return View(lstpaciente);
        }

        public ActionResult ListaExercicios3(int id)
        {
            Conexao conexao = new Conexao();
            string Strquery = $"Select * from tb_Exercicios where IdPaciente={id}";
            using (MySqlCommand comando = new MySqlCommand(Strquery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Paciente paciente = new Paciente()
                    {
                        Id = Convert.ToInt32(dr["IdPaciente"]),
                        IdExercicio = Convert.ToInt32(dr["Id"]),
                        Exercicios1 = Convert.ToString(dr["Exercicios1"]),
                        Exercicios2 = Convert.ToString(dr["Exercicios2"]),
                        Exercicios3 = Convert.ToString(dr["Exercicios3"]),
                        Exercicios4 = Convert.ToString(dr["Exercicios4"]),
                        Exercicios5 = Convert.ToString(dr["Exercicios5"]),
                        Exercicios6 = Convert.ToString(dr["Exercicios6"]),
                        Exercicios7 = Convert.ToString(dr["Exercicios7"]),
                        Exercicios8 = Convert.ToString(dr["Exercicios8"]),
                        Series = Convert.ToString(dr["Series1"]),
                        Series2 = Convert.ToString(dr["Series2"]),
                        Series3 = Convert.ToString(dr["Series3"]),
                        Series4 = Convert.ToString(dr["Series4"]),
                        Series5 = Convert.ToString(dr["Series5"]),
                        Series6 = Convert.ToString(dr["Series6"]),
                        Series7 = Convert.ToString(dr["Series7"]),
                        Series8 = Convert.ToString(dr["Series8"]),
                        Intervalos = Convert.ToString(dr["Intervalos1"]),
                        Intervalos2 = Convert.ToString(dr["Intervalos2"]),
                        Intervalos3 = Convert.ToString(dr["Intervalos3"]),
                        Intervalos4 = Convert.ToString(dr["Intervalos4"]),
                        Intervalos5 = Convert.ToString(dr["Intervalos5"]),
                        Intervalos6 = Convert.ToString(dr["Intervalos6"]),
                        Intervalos7 = Convert.ToString(dr["Intervalos7"]),
                        Intervalos8 = Convert.ToString(dr["Intervalos8"]),
                        Repeticoes = Convert.ToString(dr["Reperticoes1"]),
                        Repeticoes2 = Convert.ToString(dr["Reperticoes2"]),
                        Repeticoes3 = Convert.ToString(dr["Reperticoes3"]),
                        Repeticoes4 = Convert.ToString(dr["Reperticoes4"]),
                        Repeticoes5 = Convert.ToString(dr["Reperticoes5"]),
                        Repeticoes6 = Convert.ToString(dr["Reperticoes6"]),
                        Repeticoes7 = Convert.ToString(dr["Reperticoes7"]),
                        Repeticoes8 = Convert.ToString(dr["Reperticoes8"]),
                        DataExercicios = Convert.ToString(dr["DataExercicio"]),
                        Secao = Convert.ToString(dr["Secao"])
                    };
                    lstpaciente.Add(paciente);
                }
            }
            return View(lstpaciente);
        }

        public ActionResult Secao( int Id)
        {
            ViewBag.repeticao = lista.ListaRepeticao();
            ViewBag.intervalo = lista.ListaIntervalo();
            ViewBag.series = lista.ListaSeries();
            return View();
        }

        [HttpPost]
        public ActionResult SalvarExercicios(Paciente paciente)
        {
            using (Conexao conexao = new Conexao())
            {
                string Strquery = "INSERT INTO tb_exercicios(Exercicios1,Exercicios2,Exercicios3,Exercicios4,Exercicios5,Exercicios6,Exercicios7,Exercicios8,Series1,Series2,Series3,Series4,Series5,Series6,Series7,Series8,Intervalos1,Intervalos2,Intervalos3,Intervalos4,Intervalos5,Intervalos6,Intervalos7,Intervalos8,Reperticoes1,Reperticoes2,Reperticoes3,Reperticoes4,Reperticoes5,Reperticoes6,Reperticoes7,Reperticoes8,Secao,DataExercicio,IdPaciente) values(";
                Strquery += "'" + paciente.Exercicios1 + "', ";
                Strquery += "'" + paciente.Exercicios2 + "', ";
                Strquery += "'" + paciente.Exercicios3 + "', ";
                Strquery += "'" + paciente.Exercicios4 + "', ";
                Strquery += "'" + paciente.Exercicios5 + "', ";
                Strquery += "'" + paciente.Exercicios6 + "', ";
                Strquery += "'" + paciente.Exercicios7 + "', ";
                Strquery += "'" + paciente.Exercicios8 + "', ";
                Strquery += "'" + paciente.Series + "', ";
                Strquery += "'" + paciente.Series2 + "', ";
                Strquery += "'" + paciente.Series3 + "', ";
                Strquery += "'" + paciente.Series4 + "', ";
                Strquery += "'" + paciente.Series5 + "', ";
                Strquery += "'" + paciente.Series6 + "', ";
                Strquery += "'" + paciente.Series7 + "', ";
                Strquery += "'" + paciente.Series8 + "', ";
                Strquery += "'" + paciente.Intervalos + "', ";
                Strquery += "'" + paciente.Intervalos2 + "', ";
                Strquery += "'" + paciente.Intervalos3 + "', ";
                Strquery += "'" + paciente.Intervalos4 + "', ";
                Strquery += "'" + paciente.Intervalos5 + "', ";
                Strquery += "'" + paciente.Intervalos6 + "', ";
                Strquery += "'" + paciente.Intervalos7 + "', ";
                Strquery += "'" + paciente.Intervalos8 + "', ";
                Strquery += "'" + paciente.Repeticoes + "', ";
                Strquery += "'" + paciente.Repeticoes2 + "', ";
                Strquery += "'" + paciente.Repeticoes3 + "', ";
                Strquery += "'" + paciente.Repeticoes4 + "', ";
                Strquery += "'" + paciente.Repeticoes5 + "', ";
                Strquery += "'" + paciente.Repeticoes6 + "', ";
                Strquery += "'" + paciente.Repeticoes7 + "', ";
                Strquery += "'" + paciente.Repeticoes8 + "', ";
                Strquery += "'" + paciente.Secao + "',";
                Strquery += "now(), ";
                Strquery += paciente.Id + ");";
                using (MySqlCommand comando = new MySqlCommand(Strquery,conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("ListaExercicios");
            }

        }
    }
}