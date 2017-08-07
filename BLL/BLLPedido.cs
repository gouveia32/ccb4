using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLPedido
    {
        fnRetiraAcento ra = new fnRetiraAcento();
        DALPedido DALobj;

        public BLLPedido()
        {
            DALobj = new DALPedido();
        }

        public void Incluir(Pedido modelo)
        {
            if (modelo.cliente_id == 0)
            {
                throw new Exception("O cliente é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(Pedido modelo)
        {
            if (modelo.id <= 0)
            {
                throw new Exception("O id do pedido é obrigatório!");
            }
            if (modelo.cliente_id == 0)
            {
                throw new Exception("O cliente é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Exclui(int id)
        {
            DALobj.Exclui(id);
        }

        public Pedido CarregaPedido(int id)
        {
            return DALobj.CarregaPedido(id);
        }

        public DataTable Filtrar(String valor, String where)
        {
            return DALobj.Filtrar(ra.RetiraAcento(valor), where);
        }

        public DataTable FiltrarPedido(String valor, String where)
        {
            return DALobj.FiltrarPedido(ra.RetiraAcento(valor), where);
        }

        public DataTable CarregaTodosPedidos()
        {
            return DALobj.CarregaTodosPedidos();
        }
    }
}
