using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALGrupo
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALGrupo()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo grupo>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(Grupo modelo)
        {
            try
            {
                p = new List<MySqlParametro>();

                p.Add(new MySqlParametro("@grupo", modelo.local));
                sql = "INSERT INTO grupos(grupo) VALUES (@grupo)";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        /// <Alterar os dados de um Grupo>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        public void Altera(Grupo modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", modelo.id));
                p.Add(new MySqlParametro("@grupo", modelo.local));

                sql = "UPDATE grupos SET grupo = @grupo WHERE id = @id";
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

                sql = "DELETE FROM grupos WHERE id = @id";
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
                sWhere = "WHERE grupo LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%' OR grupo LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE (grupo LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%') AND (grupo LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 17);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE grupo LIKE '%{0:s}%'", valor);
            }

            sql = "SELECT id, grupo FROM grupos " + sWhere;
            return bd.exePesquisa(sql, p);
        }

        private Grupo BancoParaModelo(MySqlDataReader registro)
        {
            Grupo modelo = new Grupo();

            modelo.id = Convert.ToInt32(registro["id"].ToString());
            modelo.local = Convert.ToString(registro["grupo"]);

            return modelo;
        }

        /// <Carrega um Grupo >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Grupo CarregaModeloGrupo(int id)
        {
            Grupo modelo = new Grupo();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM grupos WHERE id = @id";
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
