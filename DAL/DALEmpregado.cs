using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALEmpregado
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALEmpregado()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo empregado>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(Empregado modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@nome", modelo.nome));
                p.Add(new MySqlParametro("@funcao", modelo.funcao));
                p.Add(new MySqlParametro("@nascimento", modelo.nascimento));
                p.Add(new MySqlParametro("@admissao", modelo.admissao));
                p.Add(new MySqlParametro("@demissao", modelo.demissao));
                p.Add(new MySqlParametro("@endereco", modelo.endereco));
                p.Add(new MySqlParametro("@cidade", modelo.cidade));
                p.Add(new MySqlParametro("@uf", modelo.uf));
                p.Add(new MySqlParametro("@cep", modelo.cep));
                p.Add(new MySqlParametro("@telefone1", modelo.telefone1));
                p.Add(new MySqlParametro("@telefone2", modelo.telefone2));
                p.Add(new MySqlParametro("@telefone3", modelo.telefone3));
                p.Add(new MySqlParametro("@email", modelo.email));
                p.Add(new MySqlParametro("@obs", modelo.obs));

                sql = "INSERT INTO empregados(nome,funcao,nascimento,admissao,demissao,endereco,cidade,uf,cep,telefone1,telefone2,telefone3,email,obs)"
                    + "VALUES (@nome,@funcao,@nasciennto,@admissao,@demissao,@endereco,@cidade,@uf,@cep,@telefone1,@telefone2,@telefone3,@email,@obs)";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        /// <Alterar os dados de um Empregado>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        public void Altera(Empregado modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@nome", modelo.nome));
                p.Add(new MySqlParametro("@funcao", modelo.funcao));

                p.Add(new MySqlParametro("@nascimento", modelo.nascimento));
                p.Add(new MySqlParametro("@admissao", modelo.admissao));
                p.Add(new MySqlParametro("@demissao", modelo.demissao));

                p.Add(new MySqlParametro("@endereco", modelo.endereco));
                p.Add(new MySqlParametro("@cidade", modelo.cidade));
                p.Add(new MySqlParametro("@uf", modelo.uf));
                p.Add(new MySqlParametro("@cep", modelo.cep));
                p.Add(new MySqlParametro("@telefone1", modelo.telefone1));
                p.Add(new MySqlParametro("@telefone2", modelo.telefone2));
                p.Add(new MySqlParametro("@telefone3", modelo.telefone3));
                p.Add(new MySqlParametro("@email", modelo.email));
                p.Add(new MySqlParametro("@obs", modelo.obs));
                p.Add(new MySqlParametro("@id", Convert.ToInt32(modelo.id)));
                
                sql = "UPDATE empregados SET nome=@nome,funcao=@funcao,nascimento=@nascimento,"
                + "admissao=@admissao,demissao=@demissao,endereco=@endereco,cidade=@cidade,uf=@uf,cep=@cep,"
                + "telefone1=@telefone1,telefone2=@telefone2,telefone3=@telefone3,email=@email,obs=@obs"
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

                sql = "DELETE FROM empregados WHERE id = @id";
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
                    sWhere += s + "%' OR funcao LIKE '%" + s + "%' OR nome LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE (nome LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%' OR funcao LIKE '%" + s + "%') AND (nome LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 17);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE nome LIKE '%{0:s}%' OR funcao LIKE '%{0:s}%'", valor);
            }

            sql = "SELECT id, nome, funcao FROM empregados " + sWhere;
            return bd.exePesquisa(sql, p);
        }

        private Empregado BancoParaModelo(MySqlDataReader registro)
        {
            Empregado modelo = new Empregado();

            modelo.id = Convert.ToInt32(registro["id"].ToString());
            modelo.nome = Convert.ToString(registro["nome"]);
            modelo.funcao = Convert.ToString(registro["funcao"]);

            DateTime? dt = null;

            if (registro["nascimento"] != DBNull.Value)
            {
                dt = (DateTime)registro["nascimento"];
            }
            modelo.nascimento = Convert.ToDateTime(dt);

            dt = null;
            if (registro["admissao"] != DBNull.Value)
            {
                dt = (DateTime)registro["admissao"];
            }
            modelo.admissao = Convert.ToDateTime(dt);

            dt = null;
            if (registro["demissao"] != DBNull.Value)
            {
                dt = (DateTime)registro["demissao"];
            }
            modelo.demissao = Convert.ToDateTime(dt);

            modelo.endereco = Convert.ToString(registro["endereco"]);
            modelo.cidade = Convert.ToString(registro["cidade"]);
            modelo.uf = Convert.ToString(registro["uf"]);
            modelo.cep = Convert.ToString(registro["cep"]);
            modelo.telefone1 = Convert.ToString(registro["telefone1"]);
            modelo.telefone2 = Convert.ToString(registro["telefone2"]);
            modelo.telefone3 = Convert.ToString(registro["telefone3"]);
            modelo.email = Convert.ToString(registro["email"]);
            modelo.obs = Convert.ToString(registro["obs"]);

            return modelo;
        }

        /// <Carrega um Empregado >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Empregado CarregaModeloEmpregado(int id)
        {
            Empregado modelo = new Empregado();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM empregados WHERE id = @id";
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
