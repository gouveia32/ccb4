using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLFornecedor
    {
        DALFornecedor DALobj;

        public BLLFornecedor()
        {
            DALobj = new DALFornecedor();
        }

        public void Incluir(Fornecedor modelo)
        {
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(Fornecedor modelo)
        {
            if (modelo.id <= 0)
            {
                throw new Exception("O id da fornecedor é obrigatório!");
            }
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório!");
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

        public Fornecedor CarregaModeloFornecedor(int id)
        {
            return DALobj.CarregaModeloFornecedor(id);
        }
    }
}
