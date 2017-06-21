using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class DALLinhaHistorico
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALLinhaHistorico()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo local>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(LinhaHistorico modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@linha_id", modelo.linha_id));
                p.Add(new MySqlParametro("@data", modelo.data));
                p.Add(new MySqlParametro("@acao", modelo.acao));
                p.Add(new MySqlParametro("@est1_anterior", modelo.est1_anterior));
                p.Add(new MySqlParametro("@est1_atual", modelo.est1_atual));
                p.Add(new MySqlParametro("@est2_anterior", modelo.est2_anterior));
                p.Add(new MySqlParametro("@est2_atual", modelo.est2_atual));
                sql = "INSERT INTO linhas_historico (linha_id,data,acao,est1_anterior,est1_atual,est2_anterior,est2_atual) VALUES (@linha_id,@data,@acao,@est1_anterior,@est1_atual,est2_anterior,est2_atual)";
                bd.exeNonQuery(sql, p);
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
        public void Altera(LinhaHistorico modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@linha_id", modelo.linha_id));
                p.Add(new MySqlParametro("@data", modelo.data));
                p.Add(new MySqlParametro("@acao", modelo.acao));
                p.Add(new MySqlParametro("@est1_anterior", modelo.est1_anterior));
                p.Add(new MySqlParametro("@est1_atual", modelo.est1_atual));
                p.Add(new MySqlParametro("@est2_anterior", modelo.est2_anterior));
                p.Add(new MySqlParametro("@est2_atual", modelo.est2_atual));

                sql = "UPDATE linhas_historico SET linha_id=@linha_id,data=@data,acao=@acao,est1_anterior=@est1_anterior,est1_atual=@est1_atual,est2_anterior=@est2_anterior,est2_atual=@est2_atual WHERE id = @id";
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
        public void Exclui(int linha_id)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@linha_id", linha_id));

                sql = "DELETE FROM linhas_historico WHERE linha_id = @linha_id";
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
                sWhere = "WHERE data LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%' OR acao LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE (data LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%') AND (acao LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 17);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE acao LIKE '%{0:s}%'", valor);
            }
            if (where != "")
                sWhere += " And " + where;
            else
                sWhere += ";";

            sql = "SELECT linha_id,DATE_FORMAT(data,'%Y_%m') AS mes, acao,SUM(Est1_Anterior) AS est1_anterior,SUM(Est1_Atual) AS est1_atual,SUM(Est2_Anterior) AS est2_anterior,SUM(Est2_Atual) AS est2_atual, "
                + "SUM(IF(acao='Baixa',(Est1_Anterior-Est1_Atual),0))+SUM(IF(acao='Baixa',(Est2_Anterior-Est2_Atual),0)) AS uso, "
                + "SUM(IF(acao='Entrada',(Est1_Atual-Est1_Anterior),0))+SUM(IF(acao='Entrada',(Est2_Atual-Est2_Anterior),0)) AS compra "
                + "FROM linhas_historico "
                + sWhere + " GROUP BY mes;";
            return bd.exePesquisa(sql, p);
        }

        private LinhaHistorico BancoParaModelo(MySqlDataReader registro)
        {
            LinhaHistorico modelo = new LinhaHistorico();

            modelo.linha_id = Convert.ToString(registro["linha_id"].ToString());
            modelo.data = Convert.ToDateTime(registro["data"]);
            modelo.acao = Convert.ToString(registro["acao"]);
            modelo.est1_anterior = Convert.ToInt32(registro["est1_anterior"]);
            modelo.est1_atual = Convert.ToInt32(registro["est1_atual"]);
            modelo.est2_anterior = Convert.ToInt32(registro["est2_anterior"]);
            modelo.est2_atual = Convert.ToInt32(registro["est2_atual"]);

            return modelo;
        }

        /// <Carrega um Local >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LinhaHistorico CarregaLinhaHistorico(int linha_id)
        {
            LinhaHistorico modelo = new LinhaHistorico();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@linha_id", linha_id));
                sql = "SELECT DATE_FORMAT(data,'%Y_%m') AS mes,  "
                    + "SUM(IF(acao='Entrada',(Est1_Atual-Est1_Anterior),0))+SUM(IF(acao='Entrada',(Est2_Atual-Est2_Anterior),0)) AS compra, "
                    + "SUM(IF(acao='Baixa',(Est1_Anterior-Est1_Atual),0))+SUM(IF(acao='Baixa',(Est2_Anterior-Est2_Atual),0)) AS uso "
                    + "FROM linhas_historico "
                    + "WHERE linha_id = @linha_id";
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
