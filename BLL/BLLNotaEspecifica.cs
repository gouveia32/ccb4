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

        public DataTable NotasDoBordado(int bordado_id)
        {
            return DALobj.NotasDoBordado(bordado_id);
        }
    }
}
