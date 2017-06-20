using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLBordado
    {
        fnRetiraAcento ra = new fnRetiraAcento();
        DALBordado DALobj;

        public BLLBordado()
        {
            DALobj = new DALBordado();
        }

        public void Incluir(Bordado modelo)
        {
            if (modelo.arquivo.Trim().Length == 0)
            {
                throw new Exception("O nome do Bordado é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Alterar(Bordado modelo)
        {
            if (modelo.id == 0)
            {
                throw new Exception("O codigo do Bordado é obrigatório!");
            }
            if (modelo.arquivo.Trim().Length == 0)
            {
                throw new Exception("O nome do Bordado é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Excluir(int id)
        {
            DALobj.Exclui(id);
        }

        public DataTable Filtrar(String valor)
        {
            return DALobj.Filtrar(ra.RetiraAcento(valor));
        }

        public Bordado CarregaModeloBordado(int id)
        {
            return DALobj.CarregaModeloBordado(id);
        }
    }
}
