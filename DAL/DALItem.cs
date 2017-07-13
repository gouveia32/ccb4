using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALItem
    {
        private ClassBD bd;
        private string sql;
        private List<MySqlParametro> p;

        public DALItem()
        {
            bd = ClassBD.create();
        }

        private Item BancoParaModelo(MySqlDataReader registro)
        {
            Bordado bordado = new Bordado();
            Item item = new Item(bordado);
            item.Pedido = new Pedido();
            item.Pedido.id = Convert.ToInt32(registro["pedido_id"]);
            item.Bordado = new Bordado();
            if (!DBNull.Value.Equals(registro["id"]))  // Existe bordado associado
            {
                item.Bordado.id = Convert.ToInt32(registro["bordado_id"]);
                item.Bordado.pontos = Convert.ToInt32(registro["pontos"]);
                item.Bordado.preco = Convert.ToInt32(registro["preco"]);
                item.Bordado.arquivo = Convert.ToString(registro["arquivo"]);
                item.Bordado.descricao = Convert.ToString(registro["bordado_descricao"]);
            }
            item.descricao = Convert.ToString(registro["descricao"]);
            int i;
            if (int.TryParse(registro["local_id"].ToString(), out i))
                item.local_id = i;
            else
                item.local_id = -1;

            if (int.TryParse(registro["lado"].ToString(), out i))
                item.lado = i == 2
                    ? 1 
                    : 0;   // altera dir=2 para dir=1
            else
                item.lado = -1;

            try
            {
                item.Bordado.imagem = (byte[])registro["imagem"];
            }
            catch { }

            item.data_entrega = (registro["data_entrega"] == DBNull.Value) ? (DateTime?)null : ((DateTime)registro["data_entrega"]);
            item.item = Convert.ToInt32(registro["item"]);
            item.pc_solicitadas = Convert.ToInt32(registro["pc_solicitadas"]);
            item.pc_entregues = Convert.ToInt32(registro["pc_entregues"]);
            item.preco_por_peca = Convert.ToDouble(registro["preco_por_peca"]);

            item.descricao = Convert.ToString(registro["descricao"]);
            item.obs = Convert.ToString(registro["obs"]);

            return item;
        }

        public void Insere(Item modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", modelo.pedido_id));
                p.Add(new MySqlParametro("@item", modelo.item));
                p.Add(new MySqlParametro("@bordado_id", modelo.bordado_id));
                p.Add(new MySqlParametro("@descricao", modelo.descricao));
                p.Add(new MySqlParametro("@data_entrega", modelo.data_entrega));
                p.Add(new MySqlParametro("@pc_solicitadas", modelo.pc_solicitadas));
                p.Add(new MySqlParametro("@pc_entregues", modelo.pc_entregues));
                p.Add(new MySqlParametro("@pc_defeito", modelo.pc_defeito));
                p.Add(new MySqlParametro("@pc_nao_bordadas", modelo.pc_nao_bordadas));
                p.Add(new MySqlParametro("@pontos_extras", modelo.pontos_extras));
                p.Add(new MySqlParametro("@preco_por_peca", modelo.preco_por_peca));
                p.Add(new MySqlParametro("@material_id", modelo.material_id));
                p.Add(new MySqlParametro("@local_id", modelo.local_id));
                p.Add(new MySqlParametro("@lado", modelo.lado));
                p.Add(new MySqlParametro("@arte", modelo.arte ? '1' : '0'));
                p.Add(new MySqlParametro("@aplicacao", modelo.aplicacao ? '1' : '0'));
                p.Add(new MySqlParametro("@bordado", modelo.bordado ? '1' : '0'));
                p.Add(new MySqlParametro("@cores", modelo.cores ? '1' : '0'));
                p.Add(new MySqlParametro("@troca_rapida", modelo.troca_rapida ? '1' : '0'));

                p.Add(new MySqlParametro("@obs", modelo.obs));

                sql = "INSERT INTO itens(pedido_id,item,bordado_id,descricao,data_entrega,pc_solicitadas,pc_entregues,pc_defeito,pc_nao_bordadas,pontos_extras,preco_por_peca,material_id,local_id,lado,arte,aplicacao,bordado,cores,troca_rapida,obs) " +
                      " VALUES(@pedido_id,@item,@bordado_id,@descricao,@data_entrega,@pc_solicitadas,@pc_entregues,@pc_defeito,@pc_nao_bordadas,@pontos_extras,@preco_por_peca,@material_id,@local_id,@lado,@arte,@aplicacao,@bordado,@cores,@troca_rapida,@obs)";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Altera(Item modelo)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", modelo.pedido_id));
                p.Add(new MySqlParametro("@item", modelo.item));
                p.Add(new MySqlParametro("@bordado_id", modelo.bordado_id));
                p.Add(new MySqlParametro("@descricao", modelo.descricao));
                p.Add(new MySqlParametro("@data_entrega", modelo.data_entrega));
                p.Add(new MySqlParametro("@pc_solicitadas", modelo.pc_solicitadas));
                p.Add(new MySqlParametro("@pc_entregues", modelo.pc_entregues));
                p.Add(new MySqlParametro("@pc_defeito", modelo.pc_defeito));
                p.Add(new MySqlParametro("@pc_nao_bordadas", modelo.pc_nao_bordadas));
                p.Add(new MySqlParametro("@pontos_extras", modelo.pontos_extras));
                p.Add(new MySqlParametro("@preco_por_peca", modelo.preco_por_peca));
                p.Add(new MySqlParametro("@material_id", modelo.material_id));
                p.Add(new MySqlParametro("@local_id", modelo.local_id));
                p.Add(new MySqlParametro("@lado", modelo.lado));
                p.Add(new MySqlParametro("@arte", modelo.arte ? '1' : '0'));
                p.Add(new MySqlParametro("@aplicacao", modelo.aplicacao ? '1' : '0'));
                p.Add(new MySqlParametro("@bordado", modelo.bordado ? '1' : '0'));
                p.Add(new MySqlParametro("@cores", modelo.cores ? '1' : '0'));
                p.Add(new MySqlParametro("@troca_rapida", modelo.troca_rapida ? '1' : '0'));

                p.Add(new MySqlParametro("@obs", modelo.obs));

                sql = "UPDATE itens SET bordado_id=@bordado_id, descricao=@descricao,data_entrega=@data_entrega," +
                       "pc_solicitadas=@pc_solicitadas,pc_entregues=@pc_entregues,pc_defeito=@pc_defeito,pc_nao_bordadas=@pc_nao_bordadas,pontos_extras=@pontos_extras,preco_por_peca=@preco_por_peca," +
                       "material_id=@material_id,lado=@lado,local_id=@local_id,aplicacao=@aplicacao,bordado=@bordado,cores=@cores,troca_rapida=@troca_rapida,obs=@obs " +
                       "WHERE pedido_id = @pedido_id AND item=@item";
                modelo.id = bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void AlteraItens(List<Item> itens)
        {
            try
            {
               foreach (Item item in itens)
                {
                    Altera(item);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void ExcluiItem(int pedido_id, int item)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", pedido_id));
                p.Add(new MySqlParametro("@item", item));

                sql = "DELETE FROM itens WHERE pedido_id = @pedido_id AND item = @item ";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void ExcluiItensDoPedido (int pedido_id)
        {
            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", pedido_id));

                sql = "DELETE FROM itens WHERE pedido_id = @pedido_id";
                bd.exeNonQuery(sql, p);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        /// <Carrega dados de um único ítem>
        /// 
        /// </summary>
        /// <param name="pedido_id"></param>
        /// <returns></returns>
        public Item CarregaItemDoPedido(int pedido_id, int seq)
        {
            MySqlDataReader registro = null;
            try
            {
                Bordado bordado = new Bordado();
                Item item = new Item(bordado);
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", pedido_id));
                p.Add(new MySqlParametro("@seq", seq));
                sql = "SELECT *, bordados.descricao AS bordado_descricao FROM itens LEFT JOIN bordados ON bordados.id = itens.bordado_id WHERE pedido_id = @pedido_id AND item = @seq;";
                registro = bd.Reader(sql, p);
                if (registro.HasRows)
                {
                    registro.Read(); //Le o primeiro registro, como é chave única só existe este
                    item = BancoParaModelo(registro);
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar item do pedido! Detalhes: " + ex.Message);
            }
            finally
            {
                bd.FecharReader(registro);
            }
        }

        /// <Seleciona as linhas de um bordado>
        /// 
        /// </summary>
        /// <param name="pedido_id"></param>
        /// <returns></returns>
        public DataTable ItensDoPedido(int pedido_id)
        {
            DataTable tabela = new DataTable();
            p = new List<MySqlParametro>();
            p.Add(new MySqlParametro("@pedido_id", pedido_id));
            sql = "SELECT pedido_id, clientes.nome, clientes.endereco,item, itens.descricao, data_entrega, pc_solicitadas, preco_por_peca,  pc_solicitadas * preco_por_peca AS total, local_id,lado,itens.obs FROM itens LEFT JOIN pedidos ON pedidos.id=itens.pedido_id JOIN clientes ON pedidos.cliente_id=clientes.id WHERE pedido_id = @pedido_id;";
            return bd.exePesquisa(sql, p);
        }

        /// <Carrega os itens para um Pedido>
        /// 
        /// </summary>
        /// <param name="pedido_id"></param>
        /// <returns></returns>
        public ItemCollection CarregaItensDoPedido(int pedido_id)
        {
            MySqlDataReader registro = null;
            Bordado bordado = new Bordado();
            Item item = new Item(bordado);
            ItemCollection ItemCollection = new ItemCollection();

            try
            {
                p = new List<MySqlParametro>();
                p.Add(new MySqlParametro("@pedido_id", pedido_id));
                sql = "SELECT *, bordados.descricao AS bordado_descricao FROM itens LEFT JOIN bordados ON itens.bordado_id=bordados.id WHERE pedido_id = @pedido_id;";
                registro = bd.Reader(sql, p);
                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ItemCollection.Add(BancoParaModelo(registro)); 
                    }
                }
                return ItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar item do pedido! Detalhes: " + ex.Message);
            }
        }
    }
}
