using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace conversaotemperatura.modelo
{
    public class serronegocio 
    {
        public string codigo { get; set; }

        public string mensagem { get; set; }

        public serronegocio() {
            codigo = string.Empty;
            mensagem = string.Empty;

        }

        public serronegocio(string Codigo, string Mensagem)
        {
            codigo = Codigo;
            mensagem = Mensagem;
        }


    }
}
