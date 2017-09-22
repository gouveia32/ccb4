using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

using System.ComponentModel;
using System.Text;
using System.Reflection;

namespace DAL
{
    public class ClassBD
    {
        private MySqlConnection conn;
        private MySqlCommand comando;
        private MySqlCommand comandoTemp;
        private MySqlDataAdapter adap;
        private string strConn;

        public static String servidor = "localhost";
        public static String banco = "ccb";
        public static String usuario = "gouveia";
        public static String senha = "123456";
        public static String StringDeConexao;


        public ClassBD()
        {
            this.strConn = StringDeConexao;
        }

        public static ClassBD create()
        {
            return new ClassBD();
        }

        public DataTable exePesquisa(string query, List<MySqlParametro> Param = null)
        {
            DataTable dados = new DataTable();

            //executa a query
            try
            {
                this.adap = new MySqlDataAdapter(query, this.strConn);

                //insere os parametros na query
                if (Param != null)
                {
                    foreach (MySqlParametro p in Param)
                    {
                        this.adap.SelectCommand.Parameters.AddWithValue(p.Parametro, p.Valor);
                    }
                }
                this.adap.Fill(dados);

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }

            this.adap.Dispose();

            return dados;
        }

        public int exeNonQuery(string query, List<MySqlParametro> param = null)
        {
            int id = 0;
            try
            {
                this.conn = new MySqlConnection(this.strConn);
                this.conn.Open();

                this.comando = new MySqlCommand(query, this.conn);
                //adiciona parametros
                if (param != null)
                {
                    foreach (MySqlParametro p in param)
                    {
                        this.comando.Parameters.AddWithValue(p.Parametro, p.Valor);
                    }
                }
                //executa a query
                this.comando.ExecuteNonQuery();
                id = Convert.ToInt32(comando.LastInsertedId); //Retorna o novo Id
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
            this.comando.Dispose();
            this.conn.Dispose();
            return id;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public int exeScalar(string query, List<MySqlParametro> param = null)
        {
            int resultado = 0;

            try
            {
                this.conn = new MySqlConnection(this.strConn);
                this.conn.Open();

                this.comando = new MySqlCommand(query, this.conn);
                //adiciona parametros
                if (param != null)
                {
                    foreach (MySqlParametro p in param)
                    {
                        this.comando.Parameters.AddWithValue(p.Parametro, p.Valor);
                    }
                }
                //executa a query
                object result = comando.ExecuteScalar();
                if (result != null)
                {
                    resultado = Convert.ToInt32(result);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }

            this.comando.Dispose();
            this.conn.Dispose();
            return resultado;
        }

        /// <Letura de varios registros>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public MySqlDataReader Reader(string query, List<MySqlParametro> param = null)
        {
            MySqlDataReader registro = null;

            try
            {
                this.conn = new MySqlConnection(strConn);
                this.conn.Open();

                this.comandoTemp = new MySqlCommand(query, conn);

                if (param != null)
                {
                    foreach (MySqlParametro p in param)
                    {
                        comandoTemp.Parameters.AddWithValue(p.Parametro, p.Valor);
                    }
                }
                registro = comandoTemp.ExecuteReader();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
            return registro;
        }

        public MySqlDataAdapter Fill(string query, List<MySqlParametro> Param = null)
        {
            DataTable dados = new DataTable();

            //executa a query
            try
            {
                this.adap = new MySqlDataAdapter(query, this.strConn);

                //insere os parametros na query
                if (Param != null)
                {
                    foreach (MySqlParametro p in Param)
                    {
                        this.adap.SelectCommand.Parameters.AddWithValue(p.Parametro, p.Valor);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }

           // this.adap.Dispose();

            return adap;
        }

        public bool TestarConexao()
        {
            try
            {
                this.conn = new MySqlConnection(this.strConn);
                this.conn.Open();
                return true;
            }
            catch (Exception erro)
            {
                throw new Exception("Falha na conexão com o BD!");
            }

            this.comando.Dispose();
            this.conn.Dispose();
        }

        /// <Fechar a a leitura aberta por Reader>
        /// 
        /// </summary>
        /// <param name="r"></param>
        public void FecharReader(MySqlDataReader r)
        {
            r.Close();
            this.comandoTemp.Dispose();
            this.conn.Dispose();
        }
    }
}
