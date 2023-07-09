using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Unifisio_WebAplicação.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Cpf { get; set; }
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string DataNascimento { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Ra { get; set; }
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Sexo { get; set; }
        public string Logradouro { get; set; }
        [Display(Name = "Número")]
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        [Display(Name = "UF")]
        public string Estado { get; set; }
    }
}