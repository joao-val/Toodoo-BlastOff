using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public abstract class Content
    {

        public Content()
        {
            Id = Guid.NewGuid();  // SPOF (ponto único de falha)
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }
    }
}
