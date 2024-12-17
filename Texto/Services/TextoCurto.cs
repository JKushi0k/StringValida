using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Texto.Services
{
    public class TextoCurto
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public bool ContemAPalavraQualquerNoTexto(string texto, string palavraProcurado)
        {
            var contem = texto.Contains(palavraProcurado);
            return contem;
        }
    }
}