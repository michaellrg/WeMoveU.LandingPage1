using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeMoveU.LandingPage.Web.Models
{
    public class DadosEbook
    {
        [Required(ErrorMessage = "Nome Inválido")]
        [DisplayName("Nome:")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email Inválido")]
        [DisplayName("Email:")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefone inválido.")]  
        public string Telefone { get; set; }
    }
}