using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeMoveU.LandingPage.Web.Models
{
    public class DadosCadastro
    {
        [Required (ErrorMessage ="Nome Inválido")]
        [DisplayName("Nome:")]
        [MinLength(3,ErrorMessage ="Mínimo 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome Inválido")]
        [DisplayName("Sobrenome:")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Email Inválido")]
        [DisplayName("Email:")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Website Inválido")]
        [DisplayName("Website:")]
        [DataType(DataType.Url)]
        public string Website { get; set; }
        
        [DisplayName ("Mensagem:")]
        public string Mensagem { get; set; }
        
       
    }
}