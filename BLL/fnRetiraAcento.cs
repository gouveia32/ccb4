using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    class fnRetiraAcento
    {
        public string RetiraAcento(string str)
        {
            str = str.ToUpper().Replace("Ã", "A");
            str = str.ToUpper().Replace("Á", "A");
            str = str.ToUpper().Replace("Â", "A");
            str = str.ToUpper().Replace("À", "A");
            str = str.ToUpper().Replace("É", "E");
            str = str.ToUpper().Replace("Ê", "E");
            str = str.ToUpper().Replace("Í", "I");
            str = str.ToUpper().Replace("Ó", "O");
            str = str.ToUpper().Replace("Õ", "O");
            str = str.ToUpper().Replace("Ú", "U");
            str = str.ToUpper().Replace("Ç", "C");

            return str;

            //Str = ace("ç", "c").Replace("á", "a").Replace("à", "a").Replace("â", "a").Replace("ã", "a").Replace("ä", "a").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e").Replace("í", "i").Replace("ì", "i").Replace("î", "i").Replace("ï", "i").Replace("ó", "o").Replace("ò", "o").Replace("ô", "o").Replace("õ", "o").Replace("ö", "o").Replace("ú", "u").Replace("ù", "u").Replace("û", "u").Replace("ü", "u").Replace("ý", "y").Replace("ÿ", "y").Replace("ç", "c")
            //Str = Str.Replace("á", "a").Replace("à", "a").Replace("â", "a").Replace("ã", "a").Replace("ä", "a").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e").Replace("í", "i").Replace("ì", "i").Replace("î", "i").Replace("ï", "i").Replace("ó", "o").Replace("ò", "o").Replace("ô", "o").Replace("õ", "o").Replace("ö", "o").Replace("ú", "u").Replace("ù", "u").Replace("û", "u").Replace("ü", "u").Replace("ý", "y").Replace("ÿ", "y").Replace("ñ", "nh").Replace("ç", "c").Replace("á", "a").Replace("à", "a").Replace("â", "a").Replace("ã", "a").Replace("ä", "a").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e").Replace("í", "i").Replace("ì", "i").Replace("î", "i").Replace("ï", "i").Replace("ó", "o").Replace("ò", "o").Replace("ô", "o").Replace("õ", "o").Replace("ö", "o").Replace("ú", "u").Replace("ù", "u").Replace("û", "u").Replace("ü", "u").Replace("ý", "y").Replace("ÿ", "y").Replace("ç", "c")
        }
    }
}
