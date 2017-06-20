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
using Modelo;
using System.Globalization;

namespace GUI
{
    public partial class frmCalculaTotalPedido : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dtCalc;

        public frmCalculaTotalPedido()
        {
            InitializeComponent();
        }

        private void frmCalculaTotalPedido_Load(object sender, EventArgs e)
        {
            dtCalc = new DataTable();

            dtCalc.Columns.Add("seq");
            dtCalc.Columns.Add("pedido");
            dtCalc.Columns.Add("cliente");
            dtCalc.Columns.Add("data");
            dtCalc.Columns.Add("executado");
            dtCalc.Columns.Add("valor");
            gcPedidos.DataSource = dtCalc;
            gvPedidos.Columns[0].Width = 35;
            gvPedidos.Columns[1].Width = 55;
            gvPedidos.Columns[2].Width = 130;
            gvPedidos.Columns[3].Width = 80;
            gvPedidos.Columns[4].Width = 60;
            gvPedidos.Columns[5].Width = 90;
        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                foreach (DataRow r in dtCalc.Rows)
                {
                    if (txtPedido.Text == r.ItemArray[1].ToString())
                        return;  //já havia digitado este pedido
                }

                BLLPedido bll = new BLLPedido();
                Pedido modelo = new Pedido();

                modelo = bll.CarregaPedido(Convert.ToInt32(txtPedido.Text));

                if (modelo.id == 0) return;

                DataRow dr = dtCalc.NewRow();

                dr[0] = gvPedidos.RowCount + 1;
                dr[1] = modelo.id;
                dr[2] = modelo.Cliente.nome;
                dr[3] = String.Format("{0:dd-MM-yyyy}", modelo.data_abertura);
                dr[4] = (modelo.quitado) ? "Sim" : "Não";
                dr[5] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", modelo.valor); 
                dtCalc.Rows.Add(dr);
                txtPedido.Text = "";
                txtPedido.Focus();
            }
        }

        private void btnRemoverTodos_Click_1(object sender, EventArgs e)
        {
            dtCalc.Rows.Clear();
            txtPedido.Focus();
        }

        private void btnRemoverSelecionado_Click_1(object sender, EventArgs e)
        {
            if (this.gvPedidos.SelectedRowsCount < 1) return;
            int i;

            DataRow[] rows = new DataRow[gvPedidos.SelectedRowsCount];

            for (i = 0; i < gvPedidos.SelectedRowsCount; i++)
                rows[i] = gvPedidos.GetDataRow(gvPedidos.GetSelectedRows()[i]);

            gvPedidos.BeginSort();
            try
            {
                foreach (DataRow row in rows)
                    row.Delete();
            }
            finally
            {
                for (i = 0; i < dtCalc.Rows.Count; i++)
                {
                    dtCalc.Rows[i].SetField(0, i + 1);
                }
                gvPedidos.EndSort();

                txtPedido.Focus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalculaTotalPedido_Activated(object sender, EventArgs e)
        {
            txtPedido.Focus();
        }
    }
}