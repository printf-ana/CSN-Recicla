using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Models
{
    public class PontoDeColeta
    {
        public int PontoDeColetaId { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Telefone { get; set; }
        public IList<HorarioFuncionamento> HorarioFuncionamentos { get; set; }
        public IList<Embalagem> Embalagens { get; set; }
    }
}
