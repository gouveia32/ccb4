﻿using MySql.Data.MySqlClient;
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

        public void Insere(DALNotaEspecifica modelo)
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
