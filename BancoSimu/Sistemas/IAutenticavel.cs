using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimu.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
