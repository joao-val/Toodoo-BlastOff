using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMInvestigacao.Model
{
    public class Vilao
    {
        public int IdVilao { get; set; }
        public string? Nome { get; set; }
        public int NumCrime { get; set; }
        public IList<Crime> Crimes { get; set; }
    }
}
