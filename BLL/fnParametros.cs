using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class fnParametros
    {
        public void CarregaParametros(int id)
        {
            //Recupera dados do servidor no registro
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\ccb4");
            if ((key != null))
            {
                try
                {
                    BLLParametros bllParametros = new BLLParametros();

                    Parametros prm = bllParametros.CarregaModeloParametros(id);

                    Properties.Settings.Default.SeesaoTimeOut = prm.SessaoTimeOut;
                    Properties.Settings.Default.TempoAtualizaPedidos = prm.TempoAtualizaPedidos;
                    Properties.Settings.Default.corTarefaSelecionada = prm.corTarefaSelecionada;
                    Properties.Settings.Default.corCriacaoNormal = prm.corCriacaoNormal;
                    Properties.Settings.Default.corCriacaoUrgente = prm.corCriacaoUrgente;
                    Properties.Settings.Default.corPedidoNormal = prm.corPedidoNormal;
                    Properties.Settings.Default.corPedidoMensal = prm.corPedidoMensal;
                }
                finally
                {
                    key.Close();
                }
            }
        }

        public void GravaParametros(int id)
        {
            //Grava dados do servidor no registro
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\ccb4");

            try
            {                
                Parametros modelo = new Parametros();
                
                modelo.id = id;    //Considera 1 como sendo o perfil válido
                modelo.SessaoTimeOut = Properties.Settings.Default.SeesaoTimeOut;
                modelo.TempoAtualizaPedidos = Properties.Settings.Default.TempoAtualizaPedidos;
                modelo.corTarefaSelecionada = Properties.Settings.Default.corTarefaSelecionada;
                modelo.corCriacaoNormal = Properties.Settings.Default.corCriacaoNormal;
                modelo.corCriacaoUrgente = Properties.Settings.Default.corCriacaoUrgente;
                modelo.corPedidoNormal = Properties.Settings.Default.corPedidoNormal;
                modelo.corPedidoMensal = Properties.Settings.Default.corPedidoMensal;

                BLLParametros bllParametros = new BLLParametros();
                bllParametros.GravaModeloParametros(modelo);

            }
            finally
            {
                key.Close();
            }
        }
    }
}
