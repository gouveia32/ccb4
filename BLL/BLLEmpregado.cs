using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLEmpregado
    {
        DALEmpregado DALobj;

        public BLLEmpregado()
        {
            DALobj = new DALEmpregado();
        }

        public void Incluir(Empregado modelo)
        {
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do empregado é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(Empregado modelo)
        {
            if (modelo.id <= 0)
            {
                throw new Exception("O id da empregado é obrigatório!");
            }
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do empregado é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Exclui(int id)
        {
            DALobj.Exclui(id);
        }

        public DataTable Filtrar(String valor)
        {
            return DALobj.Filtrar(valor);
        }

        public Empregado CarregaModeloEmpregado(int id)
        {
            return DALobj.CarregaModeloEmpregado(id);
        }
    }
}
