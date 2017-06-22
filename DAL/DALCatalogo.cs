using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALCatalogo
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALCatalogo()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo grupo>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(Catalogo modelo)
        {
            try
            {
                p = new List<MySqlParametro>();

                p.Add(new MySqlParametro("@nome", modelo.nome));
                p.Add(new MySqlParametro("@bordado_id", modelo.bordado_id));
                sql = "INSERT INTO catalogod(nome,bordado_id) VALUES (@nome,@bordado_id)";
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
        public void Altera(Catalogo modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", modelo.id));
                p.Add(new MySqlParametro("@nome", modelo.nome));
                p.Add(new MySqlParametro("@bordado_id", modelo.bordado_id));

                sql = "UPDATE catalogos SET nome=@nome,bordado_id=@bordado_id WHERE id = @id";
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
        /// <param name="nome"></param>
        public void Exclui(string nome)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@nome", nome));

                sql = "DELETE FROM catalogos WHERE nome=@nome";
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
                sWhere = "WHERE nome LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%' OR nome LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE (nome LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%'" + s + "%') AND (grupo LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 17);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE nome LIKE '%{0:s}%'", valor);
            }

            sql = "SELECT id, nome, bordado_id FROM catalogos " + sWhere;
            return bd.exePesquisa(sql, p);
        }

        private Catalogo BancoParaModelo(MySqlDataReader registro)
        {
            Catalogo modelo = new Catalogo();

            modelo.id = Convert.ToInt32(registro["id"].ToString());
            modelo.nome = Convert.ToString(registro["nome"]);
            modelo.bordado_id = Convert.ToInt32(registro["bordado_id"]);

            return modelo;
        }

        /// <Carrega um Grupo >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Catalogo CarregaModeloGrupo(int id)
        {
            Catalogo modelo = new Catalogo();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM catalogos WHERE id = @id";
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
