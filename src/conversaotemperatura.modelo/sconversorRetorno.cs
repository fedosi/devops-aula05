using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conversaotemperatura.modelo
{
    [Serializable()]
    public class sconversorRetorno : sretornonegocio
    {
        public sconversorRetorno(string tipoconversao, double valororigem)
        {
            TipoConversao = tipoconversao;
            ValorOrigem = valororigem;
        }

        public string TipoConversao { get; set; }
        public double ValorOrigem { get; set; }
        public double ValorDestino { get; set; }

    }


    
}
