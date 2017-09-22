using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ClienteBLL
    {
        fnRetiraAcento ra = new fnRetiraAcento();
        ClienteDAL DALobj;

        public ClienteBLL()
        {
            DALobj = new ClienteDAL();
        }

        public void Incluir(Cliente modelo)
        {
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(Cliente modelo)
        {
            if (modelo.id <= 0)
            {
                throw new Exception("O id da cliente é obrigatório!");
            }
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        public void Exclui(int id)
        {
            DALobj.Exclui(id);
        }

        public DataTable Filtrar(String valor)
        {
            return DALobj.Filtrar(ra.RetiraAcento (valor));
        }

        public Cliente CarregaCliente(int id)
        {
            return DALobj.CarregaCliente(id);
        }
    }
}
