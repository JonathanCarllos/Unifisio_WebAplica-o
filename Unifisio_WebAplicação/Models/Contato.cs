using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Unifisio_WebAplicação.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Assunto { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

    }
}