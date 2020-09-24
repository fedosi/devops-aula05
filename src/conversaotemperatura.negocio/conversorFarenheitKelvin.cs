using System;
using System.Collections.Generic;
using System.Text;

namespace conversaotemperatura.negocio
{
    class conversorFarenheitKelvin : conversor
    {
        public conversorFarenheitKelvin()
        {
            Desc = "Farenheit para Kelvin";
        }

    public override double executar(string tipoConversao, double valororigem)
        {
            return Math.Round((valororigem-32) * 5/9 + 273.15, 3);
        }

    }
}
