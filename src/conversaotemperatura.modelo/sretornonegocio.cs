using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace conversaotemperatura.modelo
{
    
    public class sretornonegocio 
    {
        [DataMember]
        public serronegocio erro { get; set; }

        public sretornonegocio()
        {
            erro = new serronegocio();
        }


    }
}
