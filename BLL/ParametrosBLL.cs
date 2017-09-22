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
    public class ParametroBLLs
    {
        ParametroDALs DALobj;

        public ParametroBLLs()
        {
            DALobj = new ParametroDALs();
        }

        public Parametros CarregaModeloParametros(int id)
        {
            return DALobj.CarregaModeloParametros(id);
        }

        public void GravaModeloParametros(Parametros modelo)
        {
            DALobj.GravaModeloParametros(modelo);
        }

    }
}
