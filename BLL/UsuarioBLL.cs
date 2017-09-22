using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Modelo;

namespace BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL DALobj;

        public UsuarioBLL()
        {

            DALobj = new UsuarioDAL();

        }

        public void Incluir(Usuario user)
        {

            if (user.login.Trim().Length == 0 && user.senha.Trim().Length == 0)
            {
                throw new Exception("O login e senha obrigatórios");
            }

            if (DALobj.verifica(user) != 0)
            {
                throw new Exception("Usuário já existe!");
            }

            DALobj.Insere(user);

        }

        public void Altera(Usuario user)
        {

            if (user.login.Trim().Length == 0 && user.senha.Trim().Length == 0)
            {
                throw new Exception("O login e senha obrigatórios");
            }

            if (DALobj.verifica(user) != 0)
            {
                throw new Exception("Usuário já existe!");
            }

            DALobj.Altera(user);

        }

        public void Exclui(int codigo)
        {
            DALobj.Exclui(codigo);
        }

        public DataTable Localiza(string valor)
        {
            return DALobj.Pesquisa(valor);
        }

        public Usuario CarregaUsuario(string login, string senha)
        {
            return DALobj.CarregaUsuario(login, senha);
        }

        public void AcessoSistema(Usuario user)
        {
            if (DALobj.verifica(user) != 1)
            {
                throw new Exception("Usuário/senha inválido(s)");
            }
        }
    }
}
