using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Caching;
using conversaotemperatura.modelo;

namespace conversaotemperatura.negocio.servicos
{
    public class servicomensagem
    {
        private static ObjectCache CacheMensagem;

        public static string executar(string codigo) {
            try
            {
                registrar();
                return (string)CacheMensagem.Get(codigo, null);
            }
            catch { return $"Arrg!! Mensagem de erro {codigo} não registrada"; }
        }

        private static void registrar()
        {
            if (CacheMensagem == null)
            {
                CacheMensagem = new MemoryCache("CacheMensagem", null);
                CacheMensagem.Add("CVR001", "Oops! Essa conversão não é suportada.", null);
            }

        }



    }
}
