using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Modelo;
using BLL;

namespace GUI
{
    public partial class dlgSelecionaCliente : DevExpress.XtraEditors.XtraForm
    {
        public Cliente modeloCliente;

        public dlgSelecionaCliente()
        {
            InitializeComponent();
        }


        public void FiltrarClientes(string filtro)
        {
            ClienteBLL bll = new ClienteBLL();

            dgClientes.DataSource = bll.Filtrar(filtro);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (gvClientes.SelectedRowsCount < 1) return;

            ClienteBLL bll = new ClienteBLL();

            modeloCliente = bll.CarregaCliente(Convert.ToInt32(gvClientes.GetDataRow(gvClientes.FocusedRowHandle).ItemArray[0]));
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}