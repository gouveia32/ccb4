using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class AgendaPedidoDAL
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public AgendaPedidoDAL()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo AgendaPedidoDAL>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(AgendaPedido modelo)
        {
            try
            {
                p = new List<MySqlParametro>();

                p.Add(new MySqlParametro("@pedido_id", modelo.pedido_id));
                p.Add(new MySqlParametro("@subject", modelo.subject));
                p.Add(new MySqlParametro("@description", modelo.description));
                p.Add(new MySqlParametro("@location", modelo.location));
                p.Add(new MySqlParametro("@label", modelo.label));
                p.Add(new MySqlParametro("@status", modelo.status));
                p.Add(new MySqlParametro("@start", modelo.start));
                p.Add(new MySqlParametro("@end", modelo.end));
                p.Add(new MySqlParametro("@id", Convert.ToInt32(modelo.id)));

                sql = "INSERT INTO agenda_pedido(pedido_id,subject,description,location,label,status,start,end)"
                    + "VALUES (@pedido_id,@subject,@description,@location,@label,@status,@start,@end)";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        /// <Alterar os dados de um AgendaPedidoDAL>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        public void Altera(AgendaPedido modelo)
        {
            try
            {
                p = new List<MySqlParametro>();

                p.Add(new MySqlParametro("@pedido_id", modelo.pedido_id));
                p.Add(new MySqlParametro("@subject", modelo.subject));
                p.Add(new MySqlParametro("@description", modelo.description));
                p.Add(new MySqlParametro("@location", modelo.location));
                p.Add(new MySqlParametro("@label", modelo.label));
                p.Add(new MySqlParametro("@status", modelo.status));
                p.Add(new MySqlParametro("@start", modelo.start));
                p.Add(new MySqlParametro("@end", modelo.end));
                p.Add(new MySqlParametro("@id", Convert.ToInt32(modelo.id)));

                sql = "UPDATE agenda_pedido SET pedido_id=@pedido_id,subject=@subject,description=@description,location=@location,"
                    + "label=@label,status=@status,start=@start,end=@end"
                    + " WHERE id=@id;";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void AlteraSituacao(int pedido_id, int situacao)
        {
            try
            {
                p = new List<MySqlParametro>();

                p.Add(new MySqlParametro("@pedido_id", pedido_id));
                p.Add(new MySqlParametro("@status", situacao));

                sql = "UPDATE agenda_pedido SET status=@status"
                    + " WHERE pedido_id=@pedido_id;";
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

                sql = "DELETE FROM agenda_pedido WHERE id = @id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void ExcluirPorPedido(int pedido_id)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", pedido_id));

                sql = "DELETE FROM agenda_pedido WHERE pedido_id = @pedido_id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        private AgendaPedido BancoParaModelo(MySqlDataReader registro)
        {
            AgendaPedido modelo = new AgendaPedido();

            modelo.id = Convert.ToInt32(registro["id"].ToString());
            modelo.pedido_id = Convert.ToInt32(registro["pedido_id"].ToString());
            modelo.subject = Convert.ToString(registro["subject"]);
            modelo.description = Convert.ToString(registro["description"]);
            modelo.location = Convert.ToString(registro["location"]);
            modelo.label = Convert.ToInt32(registro["label"].ToString());
            modelo.status = Convert.ToInt32(registro["status"].ToString());
            modelo.start = (registro["start"] == DBNull.Value) ? (DateTime?)null : ((DateTime)registro["start"]);
            modelo.start = (registro["end"] == DBNull.Value) ? (DateTime?)null : ((DateTime)registro["end"]);

            return modelo;
        }

        /// <Carrega um AgendaPedido >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AgendaPedido CarregaEntrada(int id)
        {
            AgendaPedido modelo = new AgendaPedido();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM agenda_pedido WHERE id = @id";
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

        public AgendaPedido EntradaDoPedido(int pedido_id)
        {
            AgendaPedido modelo = new AgendaPedido();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", pedido_id));
                sql = "SELECT * FROM agenda_pedido WHERE pedido_id = @pedido_id";
                registro = bd.Reader(sql, p);

                if (registro.HasRows )
                {
                    registro.Read(); //Le o primeiro registro, como é chave única só existe este
                    modelo = BancoParaModelo(registro);
                }
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
            sql = "SELECT * FROM agenda_pedido ORDER BY id DESC;";
            return bd.exePesquisa(sql, null);
        }

        public MySqlDataAdapter FillDataSet(DataSet ds, string where = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            if (where == "")
            {
                sql = "SELECT * FROM agenda_pedido ORDER BY id DESC;";
            }
            else
            {
                sql = "SELECT * FROM agenda_pedido WHERE " + where + " ORDER BY id DESC;";
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
                sql = "SELECT * FROM agenda_pedido ORDER BY id DESC;";
            else
                sql = string.Format( "SELECT * FROM agenda_pedido WHERE {0} ORDER BY id DESC;",where);
            return bd.exePesquisa(sql, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        public DataTable CarregaUltimaEntrada(DateTime dia)
        {
           sql = string.Format("SELECT * FROM agenda_pedido WHERE DATE(START) = '{0:yyyy-MM-dd}' AND " 
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
            sql = "SELECT * FROM agenda_pedido " + sWhere + " ORDER BY id DESC";
            return bd.exePesquisa(sql, null);
        }

    }
}
