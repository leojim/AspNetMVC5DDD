using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1AspNetMCV.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Preencher campo nome")]
        public string Nome { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Sobrenome")]
        [Required(ErrorMessage = "Preencher campo sobrenome")]
        public string Sobrenome { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Data do Cadastro")]
        public DateTime DataCadastro { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Preencher o campo e-mail")]
        [EmailAddress (ErrorMessage = "E-mail em formato inválido")]
        public string Email { get; set; }
    }
}