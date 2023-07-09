using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Unifisio_WebAplicação.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Sexo { get; set; }
        [Display(Name = "Profissão")]

        public string Profissao { get; set; }

        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }
        public string Logradouro { get; set; }

        [Display(Name = "N° da Casa")]
        public string NumeroCasa { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        [Display(Name = "UF")]
        public string Estado { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Dt. Nasc.")]
        public string DataNascimento { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Telefone { get; set; }
        [Display(Name = "Celular do Responsável")]

        public string CelularResponsavel { get; set; }

        [Display(Name = "Nome do Responsável")]
        public string NomeResponsavel { get; set; }
        [Display(Name = "CPF do Responsável")]
        public string CpfResponsavel { get; set; }

        //convenio
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        [Display(Name = "Tel. Convênio")]
        public string TelefoneConv { get; set; }
        [Display(Name = "Logradouro Convênio")]
        public string LogradouroConv { get; set; }
        [Display(Name = "N° Convênio")]
        public string NumeroConv { get; set; }
        [Display(Name = "Bairro Convênio")]
        public string BairroConv { get; set; }
        [Display(Name = "Cidade Convênio")]
        public string CidadeConv { get; set; }
        [Display(Name = "Cep Convênio")]
        public string CepConv { get; set; }
        [Display(Name = "UF")]
        public string UfConvenio { get; set; }
        [Display(Name = "Tipos de Planos")]
        public string TipoPlanos { get; set; }
        [Display(Name = "Obs. Médica")]
        public string ObsMedica { get; set; }
        [Display(Name = "Exercício")]
        public string Perguntar { get; set; }
        [Display(Name = "Exercício 2")]
        public string Pergunta2 { get; set; }
        [Display(Name = "Exercício 3")]
        public string Pergunta3 { get; set; }
        [Display(Name = "Exercício 4")]
        public string Pergunta4 { get; set; }
        [Display(Name = "Exercício 5")]
        public string Pergunta5 { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        [Required(ErrorMessage ="Campo obrigatório")]
        public string Senha { get; set; }
        public bool Logado { get; set; }
        public string Tipo { get; set; }
        [Display(Name = "Relatório")]
        public string Relatorio { get; set; }
        [Display(Name = "Data Relatório")]
        public string DataRelatorio { get; set; }
        [Display(Name = "Qtd Vazamento durante o dia")]
        public string QtdRelatorio { get; set; }       
        public string Fisioterapeuta { get; set; }
        [Display(Name = "Fisioterapeuta/Aluno")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Avaliador { get; set; }
        [Display(Name = "Exercícios Feitos hoje?")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string ExercicioFeitos { get; set; }
        public bool Ativo { get; set; }
        [Display(Name = "Repetições")]
        public string Repeticoes { get; set; }
        [Display(Name = "Repetições")]
        public string Repeticoes2 { get; set; }
        [Display(Name = "Repetições")]
        public string Repeticoes3 { get; set; }
        [Display(Name = "Repetições")]
        public string Repeticoes4 { get; set; }
        [Display(Name = "Repetições")]
        public string Repeticoes5 { get; set; }
        [Display(Name = "Repetições")]
        public string Repeticoes6 { get; set; }
        [Display(Name = "Repetições")]
        public string Repeticoes7 { get; set; }
        [Display(Name = "Repetições")]
        public string Repeticoes8 { get; set; }
        [Display(Name = "Séries")]
        public string Series { get; set; }
        [Display(Name = "Séries")]
        public string Series2 { get; set; }
        [Display(Name = "Séries")]
        public string Series3 { get; set; }
        [Display(Name = "Séries")]
        public string Series4 { get; set; }
        [Display(Name = "Séries")]
        public string Series5 { get; set; }
        [Display(Name = "Séries")]
        public string Series6 { get; set; }
        [Display(Name = "Séries")]
        public string Series7 { get; set; }
        [Display(Name = "Séries")]
        public string Series8 { get; set; }
        [Display(Name = "Intervalo")]
        public string Intervalos { get; set; }
        [Display(Name = "Intervalo")]
        public string Intervalos2 { get; set; }
        [Display(Name = "Intervalo")]
        public string Intervalos3 { get; set; }
        [Display(Name = "Intervalo")]
        public string Intervalos4 { get; set; }
        [Display(Name = "Intervalo")]
        public string Intervalos5 { get; set; }
        [Display(Name = "Intervalo")]
        public string Intervalos6 { get; set; }
        [Display(Name = "Intervalo")]
        public string Intervalos7 { get; set; }
        [Display(Name = "Intervalo")]
        public string Intervalos8 { get; set; }        
        [Display(Name = "Link do Exercício")]
        public string Exercicios1 { get; set; }
        [Display(Name = "Link do Exercício")]
        public string Exercicios2 { get; set; }
        [Display(Name = "Link do Exercício")]
        public string Exercicios3 { get; set; }
        [Display(Name = "Link do Exercício")]
        public string Exercicios4 { get; set; }
        [Display(Name = "Link do Exercício")]
        public string Exercicios5 { get; set; }
        [Display(Name = "Link do Exercício")]
        public string Exercicios6 { get; set; }
        [Display(Name = "Link do Exercício")]
        public string Exercicios7 { get; set; }
        [Display(Name = "Link do Exercício")]
        public string Exercicios8 { get; set; }
        [Display(Name = "Data de envio")]
        public string DataExercicios { get; set; }
        [Display(Name = "Seção")]
        public string Secao { get; set; }

        public int IdExercicio { get; set; }

        //teste


    }
}