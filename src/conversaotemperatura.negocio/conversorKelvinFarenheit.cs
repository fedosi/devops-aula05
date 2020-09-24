using System;
using System.Collections.Generic;
using System.Text;

namespace conversaotemperatura.negocio
{
    public class conversorKelvinFarenheit : conversor
    {
        public conversorKelvinFarenheit()
        {
            Desc = "Kelvin para Farenheit";            
        }

        public override double executar(string tipoConversao, double valororigem)
        {
            return Math.Round((valororigem-273.15)*9/5 + 32,3);
        }

    }
}

