using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "Campo é obrigatório.")]
        public string PrimeiroNome { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório.")]
        public string UltimoNome { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório.")]
        public string NumeroDoc { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório.")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório.")]
        [Compare("Senha", ErrorMessage = "As senhas não estão iguais")]
        public string ConfirmaSenha { get; set; }
    }
}
