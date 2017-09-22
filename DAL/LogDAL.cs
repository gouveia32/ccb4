using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class LogDAL
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public LogDAL()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo local>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(Log modelo)
        {
            try
            {
                p = new List<MySqlParametro>();

                p.Add(new MySqlParametro("@data", modelo.data));
                p.Add(new MySqlParametro("@grupo", modelo.grupo));
                p.Add(new MySqlParametro("@sub_grupo", modelo.sub_grupo));
                p.Add(new MySqlParametro("@descricao", modelo.descricao));
                p.Add(new MySqlParametro("@objeto", modelo.objeto));
                sql = "INSERT INTO log (data,grupo,sub_grupo,descricao,objeto) VALUES (@data,@grupo,@sub_grupo,@descricao,@objeto)";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        /// <Alterar os dados de um Local>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        public void Altera(Log modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", modelo.id));
                p.Add(new MySqlParametro("@data", modelo.data));
                p.Add(new MySqlParametro("@grupo", modelo.grupo));
                p.Add(new MySqlParametro("@sub_grupo", modelo.sub_grupo));
                p.Add(new MySqlParametro("@descricao", modelo.descricao));
                p.Add(new MySqlParametro("@objeto", modelo.objeto));

                sql = "UPDATE log SET data=@data,grupo=@grupo,sub_grupo=@sub_grupo,descricao=@descricao,objeto=@objeto WHERE id = @id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        /// <Excluir o registro>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Exclui(int id)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));

                sql = "DELETE FROM log WHERE id = @id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        /// <Carrega registros que atendem ao filtro valor>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public DataTable Filtrar(String valor, String where = "")
        {
            DataTable tabela = new DataTable();
            string[] mValor;
            string sWhere = "";

            if (valor.Contains("|"))
            {
                mValor = valor.Split('|');
                sWhere = "WHERE grupo LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%' OR descricao LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE (log LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%') AND (descricao LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 17);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE descricao LIKE '%{0:s}%'", valor);
            }
            if (where != "")
                sWhere += " And " + where;
            else
                sWhere += ";";

            sql = "SELECT * FROM log " + sWhere + " ORDER BY id DESC";
            return bd.exePesquisa(sql, p);
        }

        private Log BancoParaModelo(MySqlDataReader registro)
        {
            Log modelo = new Log();

            modelo.id = Convert.ToInt32(registro["id"].ToString());
            modelo.data = Convert.ToDateTime(registro["data"]);
            modelo.grupo = Convert.ToString(registro["grupo"]);
            modelo.sub_grupo = Convert.ToString(registro["sub_grupo"]);
            modelo.descricao = Convert.ToString(registro["descricao"]);
            modelo.objeto = Convert.ToString(registro["objeto"]);

            return modelo;
        }

        /// <Carrega um Local >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Log CarregaLog(int id)
        {
            Log modelo = new Log();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM log WHERE id = @id";
                registro = bd.Reader(sql, p);

                registro.Read(); //Le o primeiro registro, como é chave única só existe este
                modelo = BancoParaModelo(registro);

            }
            finally
            {
                bd.FecharReader(registro);
            }
            return modelo;
        }
    }
}
