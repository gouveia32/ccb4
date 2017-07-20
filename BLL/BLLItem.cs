using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLItem
    {
        DALItem DALobj;

        public BLLItem()
        {
            DALobj = new DALItem();
        }

        public void Incluir(Item modelo)
        {
            if (modelo.pedido_id == 0)
            {
                throw new Exception("O pedido é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(Item modelo)
        {
            if (modelo.pedido_id <= 0)
            {
                throw new Exception("O id do pedido é obrigatório!");
            }

            DALobj.Altera(modelo);
        }

        public void ExcluiItensDoPedido(int pedido_id)
        {
            if (pedido_id == 0)
            {
                throw new Exception("O pedido_id  é obrigatório!");
            }
            DALobj.ExcluiItensDoPedido(pedido_id);
        }

        public void ExcluiItem(int pedido_id, int item)
        {
            if (pedido_id == 0)
            {
                throw new Exception("O pedido_id  é obrigatório!");
            }
            if (item == 0)
            {
                throw new Exception("O item  é obrigatório!");
            }
            DALobj.ExcluiItem(pedido_id, item);
        }

        public bool ItemExiste(Item item)
        {
            return DALobj.ItemExiste(item);
        }

        public Item CarregaItemDoPedido(int pedido_id, int item)
        {
            return DALobj.CarregaItemDoPedido(pedido_id, item);
        }

        public DataTable ItensDoPedido(int pedido_id)
        {
            return DALobj.ItensDoPedido(pedido_id);
        }

        public ItemCollection CarregaItensDoPedido(int pedido_id)
        {
            return DALobj.CarregaItensDoPedido(pedido_id);
        }
    }
}
