using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAL
{
    public class DALPedido
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALPedido()
        {
            bd = ClassBD.create();
        }

        public void Insere(Pedido modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", modelo.id));
                p.Add(new MySqlParametro("@cliente_id", modelo.cliente_id));
                p.Add(new MySqlParametro("@empregado_id", modelo.empregado_id));
                p.Add(new MySqlParametro("@data_abertura", modelo.data_abertura));
                p.Add(new MySqlParametro("@data_fechamento", modelo.data_fechamento));
                p.Add(new MySqlParametro("@data_pagamento", modelo.data_pagamento));
                p.Add(new MySqlParametro("@adicional", modelo.adicional));
                p.Add(new MySqlParametro("@desconto", modelo.desconto));
                p.Add(new MySqlParametro("@pago", modelo.pago));
                p.Add(new MySqlParametro("@valor", modelo.valor));

                p.Add(new MySqlParametro("@quitado", modelo.quitado ? '1' : '0'));
                p.Add(new MySqlParametro("@mensal", modelo.mensal ? '1' : '0'));
                p.Add(new MySqlParametro("@pago_antecipado", modelo.pago_antecipado ? '1' : '0'));
                p.Add(new MySqlParametro("@executado", modelo.executado ? '1' : '0'));

                p.Add(new MySqlParametro("@obs_pedido", modelo.obs_pedido));
                p.Add(new MySqlParametro("@obs_pagamento", modelo.obs_pagamento));

                sql = "INSERT INTO pedidos(id,cliente_id,empregado_id,data_abertura,data_fechamento,data_pagamento,adicional,desconto,pago,valor,quitado,mensal,pago_antecipado,executado,obs_pedido,obs_pagamento) " +
                      " VALUES(@id,@cliente_id,@empregado_id,@data_abertura,@data_fechamento,@data_pagamento,@adicional,@desconto,@pago,@quitado,@mensal,@pago_antecipado,@executado,@obs_pedido,@obs_pagamento)";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Altera(Pedido modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", modelo.id));
                p.Add(new MySqlParametro("@cliente_id", modelo.cliente_id));
                p.Add(new MySqlParametro("@empregado_id", modelo.empregado_id));
                p.Add(new MySqlParametro("@data_abertura", modelo.data_abertura));
                p.Add(new MySqlParametro("@data_fechamento", modelo.data_fechamento));
                p.Add(new MySqlParametro("@data_pagamento", modelo.data_pagamento));
                p.Add(new MySqlParametro("@adicional", modelo.adicional ));
                p.Add(new MySqlParametro("@desconto", modelo.desconto));
                p.Add(new MySqlParametro("@pago", modelo.pago));
                p.Add(new MySqlParametro("@valor", modelo.valor));

                p.Add(new MySqlParametro("@quitado", modelo.quitado ? '1' : '0'));
                p.Add(new MySqlParametro("@mensal", modelo.mensal ? '1' : '0'));
                p.Add(new MySqlParametro("@pago_antecipado", modelo.pago_antecipado ? '1' : '0'));
                p.Add(new MySqlParametro("@executado", modelo.executado ? '1' : '0'));

                p.Add(new MySqlParametro("@obs_pedido", modelo.obs_pedido));
                p.Add(new MySqlParametro("@obs_pagamento", modelo.obs_pagamento));

                sql = "UPDATE pedidos SET cliente_id=@cliente_id, empregado_id=@empregado_id, obs_pedido=@obs_pedido, " +
                      "data_abertura=@data_abertura,data_fechamento=@data_fechamento,data_pagamento=@data_pagamento, " +
                      "obs_pagamento=@obs_pagamento,adicional=@adicional,desconto=@desconto,pago=@pago,valor=@valor, " +
                      "quitado=@quitado,mensal=@mensal,pago_antecipado=@pago_antecipado,executado=@executado  " +
                      "WHERE id = @id";
                bd.exeNonQuery(sql, p);

                DALItem dalItem = new DALItem();
                dalItem.ExcluiItensDoPedido(modelo.id);    // apaga inicialmente todos itens do pedido

                if (modelo.Itens.Count > 0)
                {
                    
                    foreach (var item in modelo.Itens)
                    {
                        dalItem.Insere(item);
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Exclui(int id)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));

                sql = "DELETE FROM pedidos WHERE id = @id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        private Pedido BancoParaModelo(MySqlDataReader registro)
        {
            Cliente cli = new Modelo.Cliente();
            Pedido ped = new Pedido(cli);

            ped.id = Convert.ToInt32(registro["id"]);
            ped.empregado_id = Convert.ToInt32(registro["empregado_id"]);


            ped.data_abertura = (registro["data_abertura"] == DBNull.Value) ? (DateTime?)null : ((DateTime)registro["data_abertura"]);
            ped.data_fechamento = (registro["data_fechamento"] == DBNull.Value) ? (DateTime?)null : ((DateTime)registro["data_fechamento"]);
            ped.data_pagamento = (registro["data_pagamento"] == DBNull.Value) ? (DateTime?)null : ((DateTime)registro["data_pagamento"]);

            ped.cliente_id  = Convert.ToInt32(registro["cliente_id"]);
            ped.empregado_id  = Convert.ToInt32(registro["empregado_id"]);
            ped.adicional = Convert.ToDouble(registro["adicional"]);
            ped.desconto = Convert.ToDouble(registro["desconto"]);
            ped.pago = Convert.ToDouble(registro["pago"]);
            ped.valor = Convert.ToDouble(registro["valor"]);
            int i;

            if (int.TryParse(registro["quitado"].ToString(), out i))
                ped.quitado = (i == 1) ? true : false; 
            else
                ped.quitado = false;

            if (int.TryParse(registro["executado"].ToString(), out i))
                ped.executado = (i == 1) ? true : false;
            else
                ped.executado = false;

            if (int.TryParse(registro["pago_antecipado"].ToString(), out i))
                ped.pago_antecipado = (i == 1) ? true : false;
            else
                ped.pago_antecipado = false;

            if (int.TryParse(registro["mensal"].ToString(), out i))
                ped.mensal = (i == 1) ? true : false;
            else
                ped.mensal = false;

            ped.Cliente.nome = Convert.ToString(registro["nome"]);
            ped.Cliente.telefone1 = Convert.ToString(registro["telefone1"]);
            ped.obs_pedido = Convert.ToString(registro["obs_pedido"]);
            return ped;
        }

        public Pedido CarregaPedido(int id)
        {
            Pedido modelo = new Pedido();

            MySqlDataReader registro = null;
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@id", id));
                sql = "SELECT * FROM pedidos LEFT JOIN clientes ON pedidos.cliente_id = clientes.id WHERE pedidos.id = @id";
                registro = bd.Reader(sql, p);

                registro.Read(); //Le o primeiro registro, como é chave única só existe este
                if (registro.HasRows) modelo = BancoParaModelo(registro);
            }
            finally
            {
                bd.FecharReader(registro);
            }
            return modelo;
        }

        /// <Carrega todos registros>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public DataTable CarregaTodosPedidos()
        {
            sql = "SELECT pedidos.id, clientes.nome, data_abertura FROM pedidos JOIN clientes ON pedidos.cliente_id = clientes.id ORDER BY id DESC;" ;
            return bd.exePesquisa(sql, null);
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

            if (valor.Contains("|"))
            {
                mValor = valor.Split('|');
                sWhere = "WHERE (clientes.nome LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%' OR obs LIKE '%" + s + "%' OR clientes.nome LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 15);  //retura o último o´perador
            }
            else if (valor.Contains("&"))
            {
                mValor = valor.Split('&');
                sWhere = "WHERE (clientes.nome LIKE '%";
                foreach (string s in mValor)
                {
                    sWhere += s + "%' OR obs LIKE '%" + s + "%') AND (clientes.nome LIKE '%";
                }
                sWhere = sWhere.Substring(0, sWhere.Length - 17);  //retura o último o´perador
            }
            else
            {
                sWhere = string.Format("WHERE (clientes.nome LIKE '%{0:s}%' OR obs LIKE '%{0:s}%'", valor);
            }

            if (where != "")
                sWhere += ") And " + where;
            else
                sWhere += ")";
            sql = "select pedidos.id AS id, clientes.nome AS cliente, data_abertura AS data, obs from pedidos JOIN clientes ON clientes.id=pedidos.cliente_id  " + sWhere + " ORDER BY pedidos.id DESC"; 
            return bd.exePesquisa(sql, null);
        }

    }
}
