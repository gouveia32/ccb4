using Modelo;
using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLLocal
    {
        DALLocal DALobj;

        public BLLLocal()
        {
            DALobj = new DALLocal();
        }

        public void Incluir(Local modelo)
        {
            if (modelo.local.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Alterar(Local modelo)
        {
            if (modelo.id <= 0)
            {
                throw new Exception("O id da categoria é obrigatório!");
            }
            if (modelo.local.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Excluir(int id)
        {
            DALobj.Exclui(id);
        }

        public DataTable Filtrar(String valor)
        {
            return DALobj.Filtrar(valor);
        }

        public Local CarregaModeloLocal(int id)
        {
            return DALobj.CarregaModeloLocal(id);
        }
    }
}
