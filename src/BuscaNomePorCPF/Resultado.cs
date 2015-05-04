using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaNomePorCPF
{
    public class Resultado
    {
        public string key { get; set; }
        public string keyword { get; set; }
        public IList<ResultadoItem> items { get; set; }
        public string search_info { get; set; }
        public bool found { get; set; }
    }
}
