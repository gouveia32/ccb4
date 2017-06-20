using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLLinha
    {
        private DALConexao conexao;

        public BLLLinha(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloLinha modelo)
        {
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório!");
            }
            DALLinha DAobj = new DALLinha(conexao);
            DAobj.Incluir(modelo);
        }

        public void Alterar(ModeloLinha modelo)
        {
            if (modelo.codigo == "")
            {
                throw new Exception("O codigo da Linha é obrigatório!");
            }
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome da Linha é obrigatório!");
            }
            DALLinha DAobj = new DALLinha(conexao);
            DAobj.Alterar(modelo);
        }

        public void Excluir(string codigo)
        {
            DALLinha DAobj = new DALLinha(conexao);
            DAobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALLinha DAobj = new DALLinha(conexao);
            return DAobj.Localizar(valor);
        }

        public ModeloLinha CarregaModeloLinha(string codigo)
        {
            DALLinha DAobj = new DALLinha(conexao);
            return DAobj.CarregaModeloLinha(codigo);
        }
    }
}
