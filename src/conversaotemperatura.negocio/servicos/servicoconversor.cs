using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using conversaotemperatura.modelo;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;

namespace conversaotemperatura.negocio.servicos
{

    

    public static class servicoconversor
    {
        //public static ObjectPool<conversor> ConversorPool;

        private static ObjectCache PoolConversor;

        public static sconversorRetorno executar(string tipoConversao, string valororigem)
        {
            double valor = 0.00;
            double.TryParse(valororigem, out valor);
            sconversorRetorno retorno = new sconversorRetorno(tipoConversao, valor);

            try
            {
                registrar();
                conversor conv = (conversor)PoolConversor.Get(tipoConversao, null);
                if (conv == null) throw new ExceptionNegocio("CVR001");
                retorno.ValorDestino = conv.executar(tipoConversao, System.Convert.ToDouble(valororigem));
            }
            catch (ExceptionNegocio exn)
            {
                retorno.erro = exn.erronegocio;
            }
            catch (Exception ex) {
                retorno.erro = new serronegocio("", ex.Message);
            }

            return retorno;
        }

        public static Listarecursos conversores()
        {
            registrar();
            Listarecursos rs = new Listarecursos();
            foreach (var item in PoolConversor)
            {
                sdadosrecurso dado = new sdadosrecurso()
                {
                    path = "api/" + item.Key + "/<valorbase>",
                    Descricao = ((conversor)item.Value).Desc

                };
                rs.recursos.Add(dado);
            }
            return rs;
        }


        private static void registrar() {
           

            if (PoolConversor == null)
            {
                PoolConversor = new MemoryCache("PoolConversor", null);
                PoolConversor.Add("CF", new conversorCelciusFarenheit(), null);
                PoolConversor.Add("CK", new conversorCelciusKelvin(), null);
                PoolConversor.Add("FC", new conversorFarenheitCelsius(), null);
                PoolConversor.Add("FK", new conversorFarenheitKelvin(), null);
                PoolConversor.Add("KC", new conversorKelvinCelcius(), null);
                PoolConversor.Add("KF", new conversorKelvinFarenheit(), null);
            }

        }

    }
}
