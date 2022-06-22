using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMInvestigacao.Model
{
    public class Crime
    {
        public int IdCrime { get; set; }
        public DateTime? Data { get; set; }
        public string? Nome { get; set; }
        public string? Local { get; set; }
        public int Duracao { get; set; }
        public Vilao? Vilao { get; set; }
    }
}
