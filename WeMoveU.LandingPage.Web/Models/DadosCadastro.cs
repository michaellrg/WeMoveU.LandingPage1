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
        [Required(ErrorMessage = "Entre com o nome")]
        [DisplayName("Nome:")]
        [MinLength(5, ErrorMessage = "Nome com no mínimo 5 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Entre com o email")]
        [DisplayName("Email:")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required (ErrorMessage ="Entre com o website")]
        [DataType(DataType.Html)]
        [DisplayName ("Website:")]
        public string Website { get; set; }
        [Required (ErrorMessage ="Entre com o Endereço")]
        [DisplayName ("Endereço:")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Entre com a Cidade")]
        [DisplayName("Cidade:")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Entre com o Estado")]
        [DisplayName("Estado:")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Entre com o CEP")]
        [DisplayName("CEP:")]
        
        public int Cep { get; set; }
        [Required(ErrorMessage = "Entre com o País")]
        [DisplayName("País:")]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Entre com a Empresa")]
        [DisplayName("Empresa:")]
        public string Empresa { get; set; }
    }
}