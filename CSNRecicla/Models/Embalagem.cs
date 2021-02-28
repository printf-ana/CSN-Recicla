using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Models
{
    public class Embalagem
    {
        public int EmbalagemId { get; set; }
        public int PontoDeColetaId { get; set; }
        public int Pontos { get; set; }
        public string Imagem { get; set; }
        public IList<PontoDeColeta> PontosDeColeta { get; set; }
    }
}
