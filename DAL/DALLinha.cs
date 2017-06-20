using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALLinha
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALLinha()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo linha>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(Linha modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@codigo", modelo.codigo));
                p.Add(new MySqlParametro("@material_nome", modelo.material_nome));
                p.Add(new MySqlParametro("@material_fabricante", modelo.material_fabricante));
                p.Add(new MySqlParametro("@material_tipo", modelo.material_tipo));
                p.Add(new MySqlParametro("@estoque_1", modelo.estoque_1));
                p.Add(new MySqlParametro("@estoque_2", modelo.estoque_2));
                p.Add(new MySqlParametro("@cor", modelo.cor));
                p.Add(new MySqlParametro("@minimo", modelo.minimo));
                p.Add(new MySqlParametro("@pedido", modelo.pedido));

                sql = "INSERT INTO linhas(codigo,nome,material_nome,material_fabricante,material_tipo,cor,@estoque_1,estoque_2,minimo,pedido) "
                + "VALUES (@codigo,@nome,@material_nome,@material_fabricante,@material_tipo,@cor,@estoque_1,@estoque_2,@minimo,@pedido)";
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
        public void Altera(Linha modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@codigo", modelo.codigo));
                p.Add(new MySqlParametro("@nome", modelo.nome));
                p.Add(new MySqlParametro("@material_nome", modelo.material_nome));
                p.Add(new MySqlParametro("@material_fabricante", modelo.material_fabricante));
                p.Add(new MySqlParametro("@material_tipo", modelo.material_tipo));
                p.Add(new MySqlParametro("@cor", modelo.cor));
                p.Add(new MySqlParametro("@estoque_1", modelo.estoque_1));
                p.Add(new MySqlParametro("@estoque_2", modelo.estoque_2));
                p.Add(new MySqlParametro("@minimo", modelo.minimo));
                p.Add(new MySqlParametro("@pedido", modelo.pedido));

                sql = "UPDATE linhas SET nome=@nome,material_nome=@material_nome,material_fabricante=@material_fabricante,"
                + "material_tipo=@material_tipo,cor=@cor,estoque_1=@estoque_1,estoque_2=@estoque_2,minimo=@minimo,pedido=@pedido WHERE codigo = @codigo";
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
        /// <param name="codigo"></param>
        public void Exclui(string codigo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@codigo", codigo));

                sql = "DELETE FROM bordados WHERE codigo = @codigo";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        private Linha BancoParaModelo(MySqlDataReader registro)
        {
            Linha modelo = new Linha();
            if (!registro.HasRows)
                return modelo;
            modelo.codigo = Convert.ToString(registro["codigo"]);
            modelo.nome = Convert.ToString(registro["nome"]);
            modelo.material_nome = Convert.ToString(registro["material_nome"]);
            modelo.material_fabricante = Convert.ToString(registro["material_fabricante"]);
            modelo.material_tipo = Convert.ToString(registro["material_tipo"]);
            modelo.cor = Convert.ToInt32(registro["cor"]);
            modelo.estoque_1 = Convert.ToInt32(registro["estoque_1"]);
            modelo.estoque_2 = Convert.ToInt32(registro["estoque_2"]);

            return modelo;
        }

        /// <Carrega uma Linha >
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Linha CarregaModeloLinha(string codigo)
        {
            Linha modelo = new Linha();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@codigo", codigo));
                sql = "SELECT * FROM linhas WHERE codigo = @codigo";
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

        /// <Seleciona as linhas de um bordado>
        /// 
        /// </summary>
        /// <param name="bordado_id"></param>
        /// <returns></returns>
        public DataTable LinhasDoBordado(int bordado_id)
        {
            DataTable tabela = new DataTable();
            p = new List<MySqlParametro>();
            p.Add(new MySqlParametro("@bordado_id", bordado_id));
            sql = "SELECT seq, linhas.codigo, cor, linhas.nome, pontos, metragem FROM linhas_utilizadas LEFT JOIN linhas ON linhas.codigo = linhas_utilizadas.linha_id WHERE bordado_id = @bordado_id";
            return bd.exePesquisa(sql, p);
        }

        /// <Carrega registros que atendem ao filtro valor>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public DataTable Filtrar(String valor)
        {
            string[] mValor;
            string sWhere = "";

            if (valor.Contains("|"))
            {
                mValor = valor.Split('|');
                sWhere = "WHERE codigo='";
                foreach (string s in mValor)
                {
                    sWhere += s + "' OR nome LIKE '%" + s + "%' OR codigo='";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 11);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE nome LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%' AND nome LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 16);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE codigo='{0:s}' OR nome LIKE '%{0:s}%'", valor);
            }

            sql = "SELECT codigo, nome, estoque_1, minimo, cor FROM linhas " + sWhere;
            return bd.exePesquisa(sql);
        }

    }
}
