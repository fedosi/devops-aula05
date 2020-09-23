using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conversaotemperatura.estrutura
{
    public class sconversor
    {
        public sconversor(string unidadeorigem, string valororigem, string unidadedestino)
        {
            TipoOrigem = unidadeorigem;
            ValorOrigem = valororigem;
            TipoDestino = unidadedestino;
        }

        public string TipoOrigem { get; set; }
        public string ValorOrigem { get; set; }
        public string TipoDestino { get; set; }
        public string ValorDestino { get; set; }

    }
}
