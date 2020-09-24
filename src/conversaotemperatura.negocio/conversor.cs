using conversaotemperatura.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.IO;
using System.Globalization;
using System.CodeDom.Compiler;
using System.Text;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.CodeDom;

namespace conversaotemperatura.negocio
{
    public class conversor
    {

        public string Desc { get; set; }

        public virtual double executar(string tipoConversao, double valororigem)
        {
            return 0.00;
        }


        

    }
}
