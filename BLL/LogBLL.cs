using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class LogBLL
    {
        fnRetiraAcento ra = new fnRetiraAcento();
        LogDAL DALobj;

        public LogBLL()
        {
            DALobj = new LogDAL();
        }

        public void Incluir(Log modelo)
        {
            if (modelo.grupo.Trim().Length == 0)
            {
                throw new Exception("O grupo é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(Log modelo)
        {
            if (modelo.id <= 0)
            {
                throw new Exception("O id do log é obrigatório!");
            }
            if (modelo.grupo.Trim().Length == 0)
            {
                throw new Exception("O grupo é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Exclui(int id)
        {
            DALobj.Exclui(id);
        }

        public DataTable Filtrar(String valor, String where)
        {
            return DALobj.Filtrar(ra.RetiraAcento(valor), where);
        }

        public Log CarregaLog(int id)
        {
            return DALobj.CarregaLog(id);
        }
    }
}
