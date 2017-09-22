using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAL
{
    public class UsuarioDAL
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public UsuarioDAL()
        {
            bd = ClassBD.create();
        }

        public void Insere(Usuario modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@login", modelo.login));
                p.Add(new MySqlParametro("@senha", modelo.senha));

                sql = "INSERT INTO usuarios(login, senha) VALUES(@nome, @senha)";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Altera(Usuario usuario)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", usuario.id));
                p.Add(new MySqlParametro("@nome", usuario.login));
                p.Add(new MySqlParametro("@senha", usuario.senha));

                sql = "UPDATE usuarios SET login = @login, senha = @senha WHERE id = @id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Exclui(int codigo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", codigo));

                sql = "DELETE FROM usuarios WHERE id = @id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public DataTable Pesquisa(string valor)
        {
            p = new List<MySqlParametro>();
            p.Add(new MySqlParametro("@pesquisa", "%" + valor + "%"));
            sql = "SELECT * FROM usuarios WHERE login LIKE @pesquisa";

            return bd.exePesquisa(sql, p);
        }

        public Usuario CarregaUsuario(string login, string senha)
        {
            Usuario us = new Usuario();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@login", login));
                p.Add(new MySqlParametro("@senha", senha));
                sql = "SELECT * FROM usuarios WHERE login = @login AND senha = @senha";
                registro = bd.Reader(sql, p);

                while (registro.Read())
                {
                    us.id = Convert.ToInt32(registro["id"]);
                    us.login = Convert.ToString(registro["login"]);
                    us.senha = Convert.ToString(registro["senha"]);
                }
            }
            finally
            {
                bd.FecharReader(registro);
            }

            return us;
        }

        /// <Verifica se usuário existe no banco usuarios>
        /// 
        /// </summary>
        /// <param name="us"></param>
        /// <returns></returns>
        public int verifica(Usuario us)
        {
            p = new List<MySqlParametro>();
            p.Add(new MySqlParametro("@login", us.login));
            p.Add(new MySqlParametro("@senha", us.senha));

            sql = "SELECT COUNT(id) FROM usuarios WHERE login = @login AND senha = @senha";

            return bd.exeScalar(sql, p);
        }
    }
}
