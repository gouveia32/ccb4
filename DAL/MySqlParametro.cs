using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MySqlParametro
    {
        private string parametro;
        private object valor;

        public string Parametro
        {
            get { return parametro; }
            set { parametro = value; }
        }

        public object Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public MySqlParametro(string parametro, object valor)
        {
            this.Parametro = parametro;
            this.Valor = valor;
        }
    }
}
