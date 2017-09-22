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
    public class CatalogoBLL
    {
        CatalogoDAL DALobj;

        public CatalogoBLL()
        {
            DALobj = new CatalogoDAL();
        }

        public void Incluir(Catalogo modelo)
        {
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Alterar(Catalogo modelo)
        {
            if (modelo.id <= 0)
            {
                throw new Exception("O id da categoria é obrigatório!");
            }
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Excluir(string nome)
        {
            DALobj.Exclui(nome);
        }

        public DataTable Filtrar(String valor)
        {
            return DALobj.Filtrar(valor);
        }

        public Catalogo CarregaModeloCatalogo(int id)
        {
            return DALobj.CarregaModeloCatalogo(id);
        }

        public DataTable CarregaCatalogosDoBordado(int bordado_id)
        {
            return DALobj.CarregaCatalogosDoBordado(bordado_id);
        }

        public DataTable TodosCatalogos(string item = "")
        {
            return DALobj.TodosCatalogos(item);
        }
    }
}
