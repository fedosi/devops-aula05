using System;
using System.Collections.Generic;
using System.Text;

namespace conversaotemperatura.negocio
{
    public class conversorKelvinCelcius : conversor
    {
        public conversorKelvinCelcius()
        {
            Desc = "Kelvin para Celcius";
        }

    public override double executar(string tipoConversao, double valororigem)
        {
            return Math.Round(valororigem - 273.15,3);
        }

    }
}

