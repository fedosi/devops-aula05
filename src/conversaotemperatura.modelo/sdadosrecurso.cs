using System;
using System.Collections.Generic;
using System.Text;

namespace conversaotemperatura.modelo
{
    public class sdadosrecurso
    {
        public string Descricao { get; set; }
        public string path { get; set; }

    }

    public class Listarecursos
    {
        public Listarecursos() {
            recursos = new List<sdadosrecurso>();
        }
        public List<sdadosrecurso> recursos { get; set; }

    }
}