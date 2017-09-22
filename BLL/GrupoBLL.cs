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
    public class GrupoBLL
    {
        GrupoDAL DALobj;

        public GrupoBLL()
        {
            DALobj = new GrupoDAL();
        }

        public void Incluir(Grupo modelo)
        {
            if (modelo.local.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Alterar(Grupo modelo)
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

        public Grupo CarregaModeloGrupo(int id)
        {
            return DALobj.CarregaModeloGrupo(id);
        }

        public DataTable TodosGrupos(string item = "")
        {
            return DALobj.TodosGrupos(item);
        }
    }
}

