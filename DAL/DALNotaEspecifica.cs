using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALNotaEspecifica
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALNotaEspecifica()
        {
            bd = ClassBD.create();
        }

        public DataTable NotasDoBordado(int bordado_id)
        {
            DataTable tabela = new DataTable();

            p = new List<MySqlParametro>();
            p.Add(new MySqlParametro("@bordado_id", bordado_id));
            sql = "SELECT clientes.id as id, clientes.nome as cliente, " +
                  "notas_especificas.valor as valor, notas_especificas.obs as obs," +
                  "notas_especificas.data_atualizacao as data_atualizacao FROM notas_especificas left Join clientes On " +
                  "notas_especificas.cliente_id = clientes.id WHERE notas_especificas.bordado_id=@bordado_id";
                return bd.exePesquisa(sql, p);
        }
    }
}
