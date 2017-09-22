using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class NotaEspecificaDAL
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public NotaEspecificaDAL()
        {
            bd = ClassBD.create();
        }

        public void Insere(NotaEspecifica modelo)
        {
            try
            {
                p = new List<MySqlParametro>();

                p.Add(new MySqlParametro("@bordado_id", modelo.bordado_id));
                p.Add(new MySqlParametro("@cliente_id", modelo.cliente_id));
                p.Add(new MySqlParametro("@valor", modelo.valor));
                p.Add(new MySqlParametro("@data_atualizacao", modelo.data_atualizacao));
                p.Add(new MySqlParametro("@obs", modelo.obs));

                sql = "INSERT INTO notas_especificas(bordado_id,cliente_id,valor,data_atualizacao,obs) VALUES (@bordado_id,@cliente_id,@valor,@data_atualizacao,@obs)";
                bd.exeNonQuery(sql, p);
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
        public void Altera(NotaEspecifica modelo)
        {
            try
            {
                p = new List<MySqlParametro>();

                p.Add(new MySqlParametro("@bordado_id", modelo.bordado_id));
                p.Add(new MySqlParametro("@cliente_id", modelo.cliente_id));
                p.Add(new MySqlParametro("@valor", modelo.valor));
                p.Add(new MySqlParametro("@data_atualizacao", modelo.data_atualizacao));
                p.Add(new MySqlParametro("@obs", modelo.obs));

                sql = "UPDATE notas_especificas SET valor=@valor, data_atualizacao=@data_atualizacao, obs=@obs " +
                      "WHERE bordado_id=@bordado_id AND cliente_id=@cliente_id";
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
        public void Exclui(int bordado_id, int cliente_id)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@bordado_id", bordado_id));
                p.Add(new MySqlParametro("@cliente_id", cliente_id));

                sql = "DELETE FROM notas_especificas WHERE bordado_id=@bordado_id AND cliente_id=@cliente_id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public DataTable NotasDoBordado(int bordado_id)
        {
            DataTable tabela = new DataTable();

            p = new List<MySqlParametro>();
            p.Add(new MySqlParametro("@bordado_id", bordado_id));
            sql = "SELECT notas_especificas.cliente_id as id, clientes.nome as cliente, " +
                  "notas_especificas.valor as valor, notas_especificas.obs as obs," +
                  "notas_especificas.data_atualizacao as data_atualizacao FROM notas_especificas left Join clientes On " +
                  "notas_especificas.cliente_id = clientes.id WHERE notas_especificas.bordado_id=@bordado_id";
                return bd.exePesquisa(sql, p);
        }
    }
}
