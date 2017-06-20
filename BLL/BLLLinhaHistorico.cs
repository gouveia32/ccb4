using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLLinhaHistorico
    {
        fnRetiraAcento ra = new fnRetiraAcento();
        DALLinhaHistorico DALobj;

        public BLLLinhaHistorico()
        {
            DALobj = new DALLinhaHistorico();
        }

        public void Incluir(LinhaHistorico modelo)
        {
            if (modelo.linha_id <= 0)
            {
                throw new Exception("O linha_id é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(LinhaHistorico modelo)
        {
            if (modelo.linha_id <= 0)
            {
                throw new Exception("O linha_id do log é obrigatório!");
            }
            if (modelo.acao.Trim().Length == 0)
            {
                throw new Exception("O acao é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Exclui(int linha_id)
        {
            DALobj.Exclui(linha_id);
        }

        public DataTable Filtrar(String valor, String where)
        {
            return DALobj.Filtrar(ra.RetiraAcento(valor), where);
        }

        public LinhaHistorico CarregaLinhaHistorico(int linha_id)
        {
            return DALobj.CarregaLinhaHistorico(linha_id);
        }
    }
}
