using DAL;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace BLL
{
    public class BLLAgendaPedido
    {
        fnRetiraAcento ra = new fnRetiraAcento();
        DALAgendaPedido DALobj;

        public BLLAgendaPedido()
        {
            DALobj = new DALAgendaPedido();
        }

        public void Incluir(AgendaPedido modelo)
        {
            if (modelo.id == 0)
            {
                throw new Exception("O id é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(AgendaPedido modelo)
        {
            if (modelo.id <= 0)
            {
                throw new Exception("O id é obrigatório!");
            }
            if (modelo.pedido_id == 0)
            {
                throw new Exception("O pedido_id é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Exclui(int id)
        {
            DALobj.Exclui(id);
        }

        public AgendaPedido CarregaEntrada(int id)
        {
            return DALobj.CarregaEntrada(id);
        }

        public DataTable Filtrar(String valor, String where)
        {
            return DALobj.Filtrar(ra.RetiraAcento(valor), where);
        }

        public DataTable CarregaEntradas(string where = "")
        {
            return DALobj.CarregaEntradas(where);
        }
        public DataTable CarregaUltimaEntrada(DateTime dia)
        {
            return DALobj.CarregaUltimaEntrada(dia);
        }
        public MySqlDataAdapter FillDataSet(DataSet ds, string where)
        {
            return DALobj.FillDataSet(ds, where);
        }
    }
}
