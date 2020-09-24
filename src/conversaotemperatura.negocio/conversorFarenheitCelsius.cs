using System;
using System.Collections.Generic;
using System.Text;

namespace conversaotemperatura.negocio
{
    public class conversorFarenheitCelsius : conversor
    {
        public conversorFarenheitCelsius()
        {
            Desc = "Farenheit para Celsius";
        }

    public override double executar(string tipoConversao, double valororigem)
        {
            return Math.Round((valororigem-32)*5/9, 3);
        }

    }
}
