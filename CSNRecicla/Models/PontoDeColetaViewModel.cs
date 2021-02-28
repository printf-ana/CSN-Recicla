using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Models
{
    public class PontoDeColetaViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string CEP { get; set; }
        //[Required(ErrorMessage = "Campo obrigatório.")]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string NumeroDoc { get; set; }
    }
}
