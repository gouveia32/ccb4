using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class DALLocal
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALLocal()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo local>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(Local modelo)
        {
            try
            {
                p = new List<MySqlParametro>();

                p.Add(new MySqlParametro("@local", modelo.local));
                sql = "INSERT INTO locais(local) VALUES (@local)";
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
        public void Altera(Local modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", modelo.id));
                p.Add(new MySqlParametro("@local", modelo.local));

                sql = "UPDATE locais SET local = @local WHERE id = @id";
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

                sql = "DELETE FROM locais WHERE id = @id";
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
        public DataTable Filtrar(String valor)
        {
            DataTable tabela = new DataTable();
            string[] mValor;
            string sWhere = "";

            if (valor.Contains("|"))
            {
                mValor = valor.Split('|');
                sWhere = "WHERE local LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%' OR local LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE (local LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%') AND (local LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 17);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE local LIKE '%{0:s}%'", valor);
            }

            sql = "SELECT id, local FROM locais " + sWhere + " ORDER BY id;";
            return bd.exePesquisa(sql, p);
        }

        private Local BancoParaModelo(MySqlDataReader registro)
        {
            Local modelo = new Local();

            modelo.id = Convert.ToInt32(registro["id"].ToString());
            modelo.local = Convert.ToString(registro["local"]);

            return modelo;
        }

        /// <Carrega um Local >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Local CarregaModeloLocal(int id)
        {
            Local modelo = new Local();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM locais WHERE id = @id";
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
