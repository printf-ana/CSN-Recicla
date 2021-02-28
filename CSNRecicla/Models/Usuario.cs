using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSNRecicla.Models
{
    public class Usuario : IdentityUser
    {
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string NumeroDoc { get; set; }
        public int Pontos { get; set; }
        public IList<PontoDeColeta> PontosDeColeta { get; set; }
    }
}
