using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace GUI
{
    public partial class dlgNota : DevExpress.XtraEditors.XtraForm
    {
        public bool flagComboClienteCarregado = false;
        public dlgNota()
        {
            InitializeComponent();
        }

        private void dlgNota_Load(object sender, EventArgs e)
        {
            this.Left = 200;
            this.Top = 100;
            if (diValor.Enabled)
                diValor.Focus();
            else
                txtObsEspecifica.Focus();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        public void CarregaComboClientes()
        {
            //Carrega combo Cliente
            BLLCliente bll = new BLLCliente();

            cbCliente.DataSource = bll.Filtrar("");
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";

            flagComboClienteCarregado = true;
       }

        public void SelecionaClienteNoCombo(int id)
        {
            //string obj;

            foreach (var item in cbCliente.Items)
            {
                if (item.GetHashCode() == id)
                {
                    cbCliente.Text = item.ToString(); 
                    return;
                }
            }
        }

        private void dlgNota_Activated(object sender, EventArgs e)
        {
            if (!flagComboClienteCarregado)
                CarregaComboClientes();
            if (cbCliente.Enabled)
                cbCliente.Focus();
            else if (diValor.Visible)
                diValor.Focus();
            else
                txtObsEspecifica.Focus();
        }

        private void RestritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GUI.Properties.Settings.Default.Nivel < -1) return;  //Só pode habilitar usuário nível 5

            diValor.Visible = !diValor.Visible;
        }
    }
}