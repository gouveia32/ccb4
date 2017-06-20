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
