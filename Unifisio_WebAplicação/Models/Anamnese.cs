using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Unifisio_WebAplicação.Models
{
    public class Anamnese
    {
        public int id { get; set; }
        public int idFisio { get; set; }
        [Display(Name = "Título")]
        public string titulo { get; set; }
    }

    public class AnamneseItens
    {
        public int id { get; set; }
        public int? id_anamenese { get; set; }
        public string pergunta  { get; set; }
        public string tipo  { get; set; }

    }

    public  class TiposPerguntas
    {
        public int id { get; set; }
        public string tipo { get; set; }

    }
}