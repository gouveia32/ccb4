using DAL;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLLinha
    {
        LinhaDAL DALobj;

        public BLLLinha()
        {
            DALobj = new LinhaDAL();
        }

        public void Incluir(Linha modelo)
        {
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(Linha modelo)
        {
            if (modelo.codigo == "")
            {
                throw new Exception("O codigo da Linha é obrigatório!");
            }
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome da Linha é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Excluir(string codigo)
        {
            DALobj.Exclui(codigo);
        }

        public DataTable LinhasDoBordado(int bordado_id)
        {
            return DALobj.LinhasDoBordado(bordado_id);
        }

        public DataTable Filtrar(String valor)
        {
            return DALobj.Filtrar(valor);
        }

        public Linha CarregaModeloLinha(string codigo)
        {
            return DALobj.CarregaModeloLinha(codigo);
        }
    }
}
