using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimu
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get;}
        public string Argumentos { get; set; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("A string " + nameof(url) + " não pode ser nula ou vazia",nameof(url));
            
            URL = url;
            Argumentos = url[(url.IndexOf('?')+1)..];
        }

        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro + "=";
            int indice = Argumentos.IndexOf(termo);
            string resultado = Argumentos.Substring(indice+termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
                return resultado;

            return resultado.Remove(indiceEComercial);

        }
    }
}
