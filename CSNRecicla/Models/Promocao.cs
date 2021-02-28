using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Models
{
    public class Promocao
    {
        public int PromocaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int PontosNecessarios { get; set; }
        public string Imagem { get; set; }
    }
}
