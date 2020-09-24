using conversaotemperatura.modelo;
using conversaotemperatura.negocio.servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace conversaotemperatura.negocio
{
    public class ExceptionNegocio : Exception
    {
        public serronegocio erronegocio;
        public ExceptionNegocio(string codigo):base()
        {
            erronegocio = new serronegocio(codigo, servicomensagem.executar(codigo));
        }

    }
}
