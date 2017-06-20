using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private int _id;
        private string _email;
        private string _nome;
        private string _login;
        private string _senha;
        private string _nivel;
        private string _form_inicial;

        public Usuario(string login, string senha)
        {
            this._login = login;
            this._senha = senha;
        }

        public Usuario()
        {
            this._id = 0;
            this._email = "";
            this._nome = "";
            this._login = "";
            this._senha = "";
            this._nivel = "1";
            this._form_inicial = "";
        }

        public int id { get; set; }

        public string email { get; set; }

        public string nome { get; set; }

        public string login { get; set; }

        public string senha { get; set; }

        public string nivel { get; set; }

        public string form_inicial { get; set; }
    }
}
