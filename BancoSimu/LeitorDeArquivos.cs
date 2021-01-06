using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimu
{
    class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; set; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
        }

        public string LerProximaLinha()
        {
            return "Linha";
        }

        public void Dispose()
        {

        }
    }
}
