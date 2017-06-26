using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALBordado
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALBordado()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo bordado>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(Bordado modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@arquivo", modelo.arquivo));
                p.Add(new MySqlParametro("@descricao", modelo.descricao));
                p.Add(new MySqlParametro("@caminho", modelo.caminho));
                p.Add(new MySqlParametro("@disquete", modelo.disquete));
                p.Add(new MySqlParametro("@bastidor", modelo.bastidor));
                p.Add(new MySqlParametro("@grupo_id", modelo.grupo_id));
                p.Add(new MySqlParametro("@preco", modelo.preco));
                p.Add(new MySqlParametro("@cores", modelo.cores));
                p.Add(new MySqlParametro("@pontos", modelo.pontos));
                p.Add(new MySqlParametro("@largura", modelo.largura));
                p.Add(new MySqlParametro("@altura", modelo.altura));
                p.Add(new MySqlParametro("@aprovado", modelo.aprovado));
                p.Add(new MySqlParametro("@metragem", modelo.metragem));
                p.Add(new MySqlParametro("@imagem", modelo.imagem));
                p.Add(new MySqlParametro("@obs_publica", modelo.obs_publica));
                p.Add(new MySqlParametro("@obs_restrita", modelo.obs_restrita));


                sql = "INSERT INTO bordados(arquivo,descricao,caminho,disquete,bastidor,grupo_id,preco,cores,pontos,largura,altura,aprovado,metragem,imagem,obs_publica,obs_restrita)"
                + "VALUES (@arquivo,@descricao,@caminho,@disquete,@bastidor,@grupo_id,@preco,@cores,@pontos,@largura,@altura,@aprovado,@metragem,@imagem,@obs_publica,@obs_restrita)";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        /// <Alterar os dados de um Cliente>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        public void Altera(Bordado modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@arquivo", modelo.arquivo));
                p.Add(new MySqlParametro("@descricao", modelo.descricao));
                p.Add(new MySqlParametro("@caminho", modelo.caminho));
                p.Add(new MySqlParametro("@disquete", modelo.disquete));
                p.Add(new MySqlParametro("@bastidor", modelo.bastidor));
                p.Add(new MySqlParametro("@grupo_id", modelo.grupo_id));
                p.Add(new MySqlParametro("@preco", modelo.preco));
                p.Add(new MySqlParametro("@cores", modelo.cores));
                p.Add(new MySqlParametro("@pontos", modelo.pontos));
                p.Add(new MySqlParametro("@largura", modelo.largura));
                p.Add(new MySqlParametro("@altura", modelo.altura));
                p.Add(new MySqlParametro("@aprovado", modelo.aprovado));
                p.Add(new MySqlParametro("@metragem", modelo.metragem));
                //cmd.Parameters.AddWithValue("@imagem", modelo.imagem));
                p.Add(new MySqlParametro("@obs_publica", modelo.obs_publica));
                p.Add(new MySqlParametro("@obs_restrita", modelo.obs_restrita));
                p.Add(new MySqlParametro("@id", modelo.id));

                sql = "UPDATE bordados SET arquivo=@arquivo,descricao=@descricao,caminho=@caminho," +
                "disquete=@disquete,bastidor=@bastidor,grupo_id=@grupo_id,preco=@preco,cores=@cores,pontos=@pontos," +
                "largura=@largura,altura=@altura,aprovado=@aprovado,metragem=@metragem,obs_publica=@obs_publica," +
                "obs_restrita=@obs_restrita WHERE id=@id;";
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

                sql = "DELETE FROM bordados WHERE id = @id";
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

            if (valor != "")
            {
                if (valor.Contains("|"))
                {
                    mValor = valor.Split('|');
                    sWhere = "WHERE arquivo LIKE '%";
                    foreach (string s in mValor)
                    {
                        sWhere += s + "%' OR descricao LIKE '%" + s + "%' OR arquivo LIKE '%";
                    }
                    sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
                }
                else if (valor.Contains("&"))
                {
                    mValor = valor.Split('&');
                    sWhere = "WHERE (arquivo LIKE '%";
                    foreach (string s in mValor)
                    {
                        sWhere += s + "%' OR descricao LIKE '%" + s + "%') AND (arquivo LIKE '%";
                    }
                    sWhere = sWhere.Substring(0, sWhere.Length - 21);  //retura o último o´perador
                }
                else
                {
                    sWhere = string.Format("WHERE (arquivo LIKE '%{0:s}%' OR descricao LIKE '%{0:s}%'", valor);
                }
                if (where != "")
                {
                    sql = "SELECT bordados.id, arquivo, descricao, obs_publica, obs_restrita FROM bordados LEFT JOIN catalogos ON catalogos.bordado_id = bordados.id " + sWhere + ") And " + where;
                }
                else
                {
                    sql = "SELECT bordados.id, arquivo, descricao, obs_publica, obs_restrita FROM bordados " + sWhere + ");";
                }
            }
            else
            {
                if (where != "")
                {
                    sql = "SELECT bordados.id, arquivo, descricao, obs_publica, obs_restrita FROM bordados LEFT JOIN catalogos ON catalogos.bordado_id = bordados.id " + "WHERE " + where;
                }
                else
                {
                    sql = "SELECT bordados.id, arquivo, descricao, obs_publica, obs_restrita FROM bordados;";
                }
            }

            return bd.exePesquisa(sql, p);
        }

        private Bordado BancoParaModelo(MySqlDataReader registro)
        {
            Bordado modelo = new Bordado();

            modelo.id = Convert.ToInt32(registro["id"].ToString());
            modelo.arquivo = Convert.ToString(registro["arquivo"]);
            modelo.descricao = Convert.ToString(registro["descricao"]);
            modelo.caminho = Convert.ToString(registro["caminho"]);
            modelo.disquete = Convert.ToString(registro["disquete"]);
            modelo.bastidor = Convert.ToString(registro["bastidor"]);
            modelo.grupo_id = Convert.ToInt32(registro["grupo_id"]);
            modelo.preco = Convert.ToDecimal(registro["preco"]);
            modelo.cores = Convert.ToInt32(registro["cores"]);
            modelo.pontos = Convert.ToInt32(registro["pontos"]);
            modelo.largura = Convert.ToInt32(registro["largura"]);
            modelo.altura = Convert.ToInt32(registro["altura"]);
            modelo.aprovado = Convert.ToBoolean(registro["aprovado"]);
            if (registro["metragem"] == DBNull.Value)
                modelo.metragem = 0;
            else
                modelo.metragem = Convert.ToInt32(registro["metragem"]);
            
            try
            {
                modelo.imagem = (byte[])registro["imagem"];
            }
            catch { }
            modelo.obs_publica = Convert.ToString(registro["obs_publica"]);
            modelo.obs_restrita = Convert.ToString(registro["obs_restrita"]);

            return modelo;
        }


        /// <Carrega um Bordado >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Bordado CarregaModeloBordado(int id)
        {
            Bordado modelo = new Bordado();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM bordados WHERE id = @id";
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
