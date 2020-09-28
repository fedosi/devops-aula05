using conversaotemperatura.estrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conversaotemperatura.imp
{
    public static class conversor
    {
        //public static double FahrenheitToCelsius(double ent)
        //{
        //    return (5.0 / 9.0) * (ent - 32);
        //}

        //public static double CelsiusToFahrenheit(double ent)
        //{
        //    return (5.0 / 9.0) * (f - 32);
        //}


        private static double CelsiusToKelvin(double ent)
        {
            return ent + 273.15;
        }

        private static double KelvinToCelsius(double ent)
        {
            return ent - 273.15;
        }

        public static sconversor executar(sconversor ent)
        {
            if (ent.TipoOrigem == "C" && ent.TipoDestino=="K")
            {
                ent.ValorDestino = CelsiusToKelvin(System.Convert.ToDouble(ent.ValorOrigem)).ToString();
            } else if (ent.TipoOrigem == "K" && ent.TipoDestino == "C")
            {
                ent.ValorDestino = KelvinToCelsius(System.Convert.ToDouble(ent.ValorOrigem)).ToString();
            }

            return ent;
        }



    }
}
