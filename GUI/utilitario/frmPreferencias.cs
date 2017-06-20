using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using BLL;
using Modelo;

namespace GUI
{
    public partial class frmPreferencias : DevExpress.XtraEditors.XtraForm
    {
        private fnParametros parametros = new fnParametros();

        public frmPreferencias()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaPreferencias()
        {
            //Recupera dados do servidor no registro
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\ccb4");
            if ((key != null))
            {
                try
                {
                    intTimeOut.Text = Convert.ToString (key.GetValue("SessaoTimeOut", 15000));
                    cbNotificarEmail.Checked = Convert.ToBoolean (key.GetValue("NotificarEmail", true));
                    txtEmailNotificacao.Text = Convert.ToString(key.GetValue("EmailNotificacao", "gouveia32@gmail.com"));
                    txtEmailOrigem.Text = Convert.ToString(key.GetValue("EmailOrigem", "pontofinobordados@gmail.com"));
                    txtSenha.Text = Convert.ToString(key.GetValue("Senha", "POQW0101"));

                    parametros.CarregaParametros(1); //Carrega o perfil 1 para Setting
                    intTimeOut.Text = Convert.ToString(BLL.Properties.Settings.Default.SeesaoTimeOut);
                    intTempoAtualizaPedidos.Text = Convert.ToString(BLL.Properties.Settings.Default.TempoAtualizaPedidos);
                    corPedidoNormal.EditValue = BLL.Properties.Settings.Default.corPedidoNormal;
                    corPedidoMensal.EditValue = BLL.Properties.Settings.Default.corPedidoMensal;
                    corCriacaoNormal.EditValue = BLL.Properties.Settings.Default.corCriacaoNormal;
                    corCriacaoUrgente.EditValue = BLL.Properties.Settings.Default.corCriacaoUrgente;
                    corTarefaSelecionada.EditValue = BLL.Properties.Settings.Default.corTarefaSelecionada;
                }
                finally
                {
                    key.Close();
                }
            }
        }

        private void TelaParaModelo(Parametros modelo)
        {
            modelo.SessaoTimeOut = Convert.ToInt32 (intTimeOut.Text);
            modelo.TempoAtualizaPedidos = Convert.ToInt32(intTempoAtualizaPedidos.Text);
            modelo.NomeEmpresa = txtNomeEmpresa.Text;
            modelo.endereco = txtEndereco.Text;
            modelo.telefone = txtTelefone.Text;

            modelo.corPedidoNormal = Convert.ToInt32(corPedidoNormal.Color.ToArgb());
            modelo.corPedidoMensal = Convert.ToInt32(corPedidoMensal.Color.ToArgb());
            modelo.corCriacaoNormal = Convert.ToInt32(corCriacaoNormal.Color.ToArgb());
            modelo.corCriacaoUrgente = Convert.ToInt32(corCriacaoUrgente.Color.ToArgb());
            modelo.corTarefaSelecionada = Convert.ToInt32(corTarefaSelecionada.Color.ToArgb());

            BLL.Properties.Settings.Default.corTarefaSelecionada = modelo.corTarefaSelecionada;
        }


        public void GravaPreferencias()
        {
            //Grava dados do servidor no registro
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\ccb4");

            try
            {
                key.SetValue("SessaoTimeOut", intTimeOut.Text);
                key.SetValue("NotificarEmail", cbNotificarEmail.Checked);
                key.SetValue("EmailNotificacao", txtEmailNotificacao.Text);
                key.SetValue("EmailOrigem", txtEmailOrigem.Text);
                key.SetValue("Senha", txtSenha.Text);

                Parametros modelo = new Parametros();
                TelaParaModelo(modelo);
                modelo.id = 1;    //Considera 1 como sendo o perfil válido

                BLLParametros bllParametros = new BLLParametros();
                bllParametros.GravaModeloParametros(modelo);

                MessageBox.Show ("Gravado!");
            }
            finally
            {
                key.Close();
            }
        }

        private void frmPreferencias_Load(object sender, EventArgs e)
        {
            CarregaPreferencias();
        }

        private void btnGravarPreferencias_Click(object sender, EventArgs e)
        {
            GravaPreferencias();
        }
    }
}