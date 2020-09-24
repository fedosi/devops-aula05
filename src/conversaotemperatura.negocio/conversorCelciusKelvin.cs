using conversaotemperatura.modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace conversaotemperatura.negocio
{
    public class conversorCelciusKelvin : conversor
    {
        public conversorCelciusKelvin()
        {
            Desc = "Celcius para Kelvin";    
        }


    public override double executar(string tipoConversao, double valororigem)
        {
            return Math.Round(valororigem + 273.15,3);
        }
    }
}
