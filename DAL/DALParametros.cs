using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALParametros
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALParametros()
        {
            bd = ClassBD.create();
        }

        private Parametros BancoParaModelo(MySqlDataReader registro)
        {
            Parametros modelo = new Parametros();

            modelo.id = Convert.ToInt32(registro["id"].ToString());

            if (registro["caixa_aberto"] == "S")
                modelo.caixa_aberto = true;
            else
                modelo.caixa_aberto = false;

            modelo.NomeEmpresa = Convert.ToString(registro["NomeEmpresa"]);
            modelo.endereco = Convert.ToString(registro["endereco"]);
            modelo.telefone = Convert.ToString(registro["telefone"]);

            modelo.TempoAtualizaPedidos = Convert.ToInt32(registro["TempoAtualizaPedidos"]);
            modelo.SessaoTimeOut = Convert.ToInt32(registro["SessaoTimeOut"]);

            modelo.corPedidoNormal = Convert.ToInt32(registro["corPedidoNormal"]);
            modelo.corPedidoMensal = Convert.ToInt32(registro["corPedidoMensal"]);
            modelo.corCriacaoNormal = Convert.ToInt32(registro["corCriacaoNormal"]);
            modelo.corCriacaoUrgente = Convert.ToInt32(registro["corCriacaoUrgente"]);
            modelo.corTarefaSelecionada = Convert.ToInt32(registro["corTarefaSelecionada"]);

            return modelo;
        }

        /// <Carrega um Grupo >
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Parametros CarregaModeloParametros(int id)
        {
            Parametros modelo = new Parametros();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM parametros WHERE id = @id";
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

        public void GravaModeloParametros(Parametros modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@NomeEmpresa", modelo.NomeEmpresa));
                p.Add(new MySqlParametro("@endereco", modelo.endereco));
                p.Add(new MySqlParametro("@telefone", modelo.telefone));
                p.Add(new MySqlParametro("@TempoAtualizaPedidos", modelo.TempoAtualizaPedidos));
                p.Add(new MySqlParametro("@SessaoTimeOut", modelo.SessaoTimeOut));
                p.Add(new MySqlParametro("@corPedidoNormal", modelo.corPedidoNormal));
                p.Add(new MySqlParametro("@corPedidoMensal", modelo.corPedidoMensal));
                p.Add(new MySqlParametro("@corCriacaoNormal", modelo.corCriacaoNormal));
                p.Add(new MySqlParametro("@corCriacaoUrgente", modelo.corCriacaoUrgente));
                p.Add(new MySqlParametro("@corTarefaSelecionada", modelo.corTarefaSelecionada));
                p.Add(new MySqlParametro("@id", Convert.ToInt32(modelo.id)));

                sql = "UPDATE parametros SET NomeEmpresa=@NomeEmpresa,endereco=@endereco,telefone=@telefone,"
                    + "TempoAtualizaPedidos=@TempoAtualizaPedidos,SessaoTimeOut=@SessaoTimeOut,corPedidoNormal=@corPedidoNormal,"
                    + "corPedidoMensal=@corPedidoMensal,corCriacaoNormal=@corCriacaoNormal,corCriacaoUrgente=@corCriacaoUrgente,corTarefaSelecionada=@corTarefaSelecionada"
                    + " WHERE id=@id;";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
