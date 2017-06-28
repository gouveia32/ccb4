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
    public class BLLNotaEspecifica
    {
        DALNotaEspecifica DALobj;

        public BLLNotaEspecifica()
        {
            DALobj = new DALNotaEspecifica();
        }

        public void Insere(NotaEspecifica modelo)
        {
            if (modelo.bordado_id == 0)
            {
                throw new Exception("O bordado_id é obrigatório!");
            }
            if (modelo.cliente_id == 0)
            {
                throw new Exception("O cliente_id é obrigatório!");
            }
            DALobj.Insere(modelo);
        }

        public void Altera(NotaEspecifica modelo)
        {
            if (modelo.bordado_id == 0)
            {
                throw new Exception("O bordado_id é obrigatório!");
            }
            if (modelo.cliente_id == 0)
            {
                throw new Exception("O cliente_id é obrigatório!");
            }
            DALobj.Altera(modelo);
        }

        /// <Excluir o registro>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        public void Exclui(int bordado_id, int cliente_id)
        {
            DALobj.Exclui(bordado_id, cliente_id);
        }

        public DataTable NotasDoBordado(int bordado_id)
        {
            return DALobj.NotasDoBordado(bordado_id);
        }
    }
}
