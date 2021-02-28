using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Models
{
    public class HorarioFuncionamento
    {
        public int HorarioFuncionamentoId { get; set; }
        public int PontoDeColetaId { get; set; }
        public PontoDeColeta PontosDeColeta { get; set; }
        public TimeSpan Inicio { get; set; }
        public TimeSpan Termino { get; set; }
        public string DiaSemana { get; set; }
    }
}
