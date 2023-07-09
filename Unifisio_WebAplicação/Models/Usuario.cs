using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Unifisio_WebAplicação.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        [Display(Name = "Tipo de Usuário")]
        public string Tipousuario { get; set; }
        public bool Logado { get; set; }



    }
}