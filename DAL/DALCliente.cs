using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALCliente
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALCliente()
        {
            bd = ClassBD.create();
        }

        /// <Inserir um novo cliente>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        //
        //
        public void Insere(Cliente modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@nome", modelo.nome));
                p.Add(new MySqlParametro("@contato_funcao", modelo.contato_funcao));
                p.Add(new MySqlParametro("@contato_nome", modelo.contato_nome));
                p.Add(new MySqlParametro("@cgc_cpf", modelo.cgc_cpf));
                p.Add(new MySqlParametro("@inscr_estadual", modelo.inscr_estadual));
                p.Add(new MySqlParametro("@endereco", modelo.endereco));
                p.Add(new MySqlParametro("@cidade", modelo.cidade));
                p.Add(new MySqlParametro("@estado", modelo.estado));
                p.Add(new MySqlParametro("@cep", modelo.cep));
                p.Add(new MySqlParametro("@telefone1", modelo.telefone1));
                p.Add(new MySqlParametro("@telefone2", modelo.telefone2));
                p.Add(new MySqlParametro("@telefone3", modelo.telefone3));
                p.Add(new MySqlParametro("@email", modelo.email));
                p.Add(new MySqlParametro("@obs", modelo.obs));

                sql = "INSERT INTO clientes(nome,contato_funcao,contato_nome,cgc_cpf,inscr_estadual,endereco,cidade,estado,cep,telefone1,telefone2,telefone3,email,obs)"
                    + "VALUES (@nome,@contato_funcao,@contato_nome,@cgc_cpf,@inscr_estadual,@endereco,@cidade,@estado,@cep,@telefone1,@telefone2,@telefone3,@email,@obs)";
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
        public void Altera(Cliente modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@nome", modelo.nome));
                p.Add(new MySqlParametro("@contato_funcao", modelo.contato_funcao));
                p.Add(new MySqlParametro("@contato_nome", modelo.contato_nome));
                p.Add(new MySqlParametro("@cgc_cpf", modelo.cgc_cpf));
                p.Add(new MySqlParametro("@inscr_estadual", modelo.inscr_estadual));
                p.Add(new MySqlParametro("@endereco", modelo.endereco));
                p.Add(new MySqlParametro("@cidade", modelo.cidade));
                p.Add(new MySqlParametro("@estado", modelo.estado));
                p.Add(new MySqlParametro("@cep", modelo.cep));
                p.Add(new MySqlParametro("@telefone1", modelo.telefone1));
                p.Add(new MySqlParametro("@telefone2", modelo.telefone2));
                p.Add(new MySqlParametro("@telefone3", modelo.telefone3));
                p.Add(new MySqlParametro("@email", modelo.email));
                p.Add(new MySqlParametro("@obs", modelo.obs));
                p.Add(new MySqlParametro("@id", Convert.ToInt32(modelo.id)));

                sql = "UPDATE clientes SET nome=@nome,contato_funcao=@contato_funcao,contato_nome=@contato_nome,"
                    + "cgc_cpf=@cgc_cpf,inscr_estadual=@inscr_estadual,endereco=@endereco,cidade=@cidade,estado=@estado,cep=@cep,"
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

                sql = "DELETE FROM clientes WHERE id = @id";
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
                    sWhere += s + "%' OR contato_nome LIKE '%" + s + "%' OR nome LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE (nome LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%' OR contato_nome LIKE '%" + s + "%') AND (nome LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 17);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE nome LIKE '%{0:s}%' OR contato_nome LIKE '%{0:s}%'", valor);
            }

            sql = "SELECT id, nome, contato_nome FROM clientes " + sWhere + " ORDER BY nome";
            return bd.exePesquisa(sql, null);
        }


        private Cliente BancoParaModelo(MySqlDataReader registro)
        {
            Cliente modelo = new Cliente();

            modelo.id = Convert.ToInt32(registro["id"].ToString());
            modelo.nome = Convert.ToString(registro["nome"]);
            modelo.contato_funcao = Convert.ToString(registro["contato_funcao"]);
            modelo.contato_nome = Convert.ToString(registro["contato_nome"]);
            modelo.inscr_estadual = Convert.ToString(registro["inscr_estadual"]);
            modelo.cgc_cpf = Convert.ToString(registro["cgc_cpf"]);
            modelo.endereco = Convert.ToString(registro["endereco"]);
            modelo.cidade = Convert.ToString(registro["cidade"]);
            modelo.estado = Convert.ToString(registro["estado"]);
            modelo.cep = Convert.ToString(registro["cep"]);
            modelo.telefone1 = Convert.ToString(registro["telefone1"]);
            modelo.telefone2 = Convert.ToString(registro["telefone2"]);
            modelo.telefone3 = Convert.ToString(registro["telefone3"]);
            modelo.email = Convert.ToString(registro["email"]);
            modelo.obs = Convert.ToString(registro["obs"]);

            return modelo;
        }


        /// <Carrega um Cliente >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente CarregaCliente(int id)
        {
            Cliente modelo = new Cliente();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM clientes WHERE id = @id";
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
