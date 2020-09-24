using System;
using System.Collections.Generic;
using System.Text;

namespace conversaotemperatura.negocio
{
    public class conversorCelciusFarenheit : conversor
    {
        public conversorCelciusFarenheit() 
        {
            Desc = "Celcius para Farenheit";
        }

        public override double executar(string tipoConversao, double valororigem)
        {
            return Math.Round((valororigem*9/5)+32,3);
        }
    }
}
