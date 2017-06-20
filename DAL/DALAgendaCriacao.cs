﻿using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALAgendaCriacao
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALAgendaCriacao()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo DALAgendaCriacao>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(AgendaCriacao modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", modelo.pedido_id));
                p.Add(new MySqlParametro("@contato_funcao", modelo.subject));
                p.Add(new MySqlParametro("@contato_nome", modelo.location));
                p.Add(new MySqlParametro("@cgc_cpf", modelo.label));
                p.Add(new MySqlParametro("@inscr_estadual", modelo.status));
                p.Add(new MySqlParametro("@endereco", modelo.start));
                p.Add(new MySqlParametro("@cidade", modelo.end));

                sql = "INSERT INTO agenda_criacao(pedido_id,subject,location,label,status,endereco,start,end)"
                    + "VALUES (@pedido_id,@subject,@location,@label,@status,@start,@end)";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        /// <Alterar os dados de um DALAgendaCriacao>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        public void Altera(AgendaCriacao modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", modelo.pedido_id));
                p.Add(new MySqlParametro("@subject", modelo.subject));
                p.Add(new MySqlParametro("@location", modelo.location));
                p.Add(new MySqlParametro("@label", modelo.label));
                p.Add(new MySqlParametro("@status", modelo.status));
                p.Add(new MySqlParametro("@start", modelo.start));
                p.Add(new MySqlParametro("@end", modelo.end));
                p.Add(new MySqlParametro("@id", Convert.ToInt32(modelo.id)));

                sql = "UPDATE agena_criacao SET pedido_id=@pedido_id,subject=@subject,location=@location,"
                    + "label=@label,status=@status,start=@start,end=@end"
                    + " WHERE id=@id;";
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

                sql = "DELETE FROM agenda_criacao WHERE id = @id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        private AgendaCriacao BancoParaModelo(MySqlDataReader registro)
        {
            AgendaCriacao modelo = new AgendaCriacao();

            modelo.id = Convert.ToInt32(registro["id"].ToString());
            modelo.pedido_id = Convert.ToInt32(registro["pedido_id"].ToString());
            modelo.subject = Convert.ToString(registro["subject"]);
            modelo.location = Convert.ToString(registro["location"]);
            modelo.label = Convert.ToInt32(registro["label"].ToString());
            modelo.status = Convert.ToInt32(registro["status"].ToString());
            modelo.start = (registro["start"] == DBNull.Value) ? (DateTime?)null : ((DateTime)registro["start"]);
            modelo.start = (registro["end"] == DBNull.Value) ? (DateTime?)null : ((DateTime)registro["end"]);

            return modelo;
        }

        /// <Carrega um AgendaCriacao >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AgendaCriacao CarregaEntrada(int id)
        {
            AgendaCriacao modelo = new AgendaCriacao();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM agenda_criacao WHERE id = @id";
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

        /// <Carrega todos registros>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public DataTable CarregaTodasEntradas()
        {
            sql = "SELECT * FROM agenda_criacao ORDER BY id DESC;";
            return bd.exePesquisa(sql, null);
        }

        public MySqlDataAdapter FillDataSet(DataSet ds, string where = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            if (where == "")
            {
                sql = "SELECT * FROM agenda_criacao ORDER BY id DESC;";
            }
            else
            {
                sql = "SELECT * FROM agenda_criacao WHERE " + where + " ORDER BY id DESC;";
            }
            da = bd.Fill(sql);
            da.Fill(ds);
            return da;
        }

        /// <Carrega todos registros>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public DataTable CarregaEntradas(string where = "")
        {
            if (where == "")
                sql = "SELECT * FROM agenda_criacao ORDER BY id DESC;";
            else
                sql = string.Format("SELECT * FROM agenda_criacao WHERE {0} ORDER BY id DESC;", where);
            return bd.exePesquisa(sql, null);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        public DataTable CarregaUltimaEntrada(DateTime dia)
        {
            sql = string.Format("SELECT * FROM agenda_criacao WHERE DATE(START) = '{0:yyyy-MM-dd}' AND "
                              + " status > 0 ORDER BY id DESC LIMIT 1;",
                dia);
            return bd.exePesquisa(sql, null);
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
                sWhere = "WHERE (subject LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%' OR location LIKE '%" + s + "%' OR subject LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE (subject LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%' OR location LIKE '%" + s + "%') AND (subject LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 17);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE (subject LIKE '%{0:s}%' OR location LIKE '%{0:s}%'", valor);
            }

            if (where != "")
                sWhere += ") And " + where;
            else
                sWhere += ")";
            sql = "SELECT * FROM agenda_criacao " + sWhere + " ORDER BY id DESC";
            return bd.exePesquisa(sql, null);
        }

    }
}
