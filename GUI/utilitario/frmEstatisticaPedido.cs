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
    public partial class frmEstatisticaPedido : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dtCalc;

        frmPrincipal fp;

        public frmEstatisticaPedido(frmPrincipal _fp)
        {
            InitializeComponent();
            fp = _fp;
        }

        private void Filtrar()
        {
            string filtro = "";
            // Warning!!! Optional parameters not supported
            fp.MostraAgaurde("Aguarde", "Carregando dados...");

            if ((chkFiltroNaoQuitado.Checked == true))
            {
                if ((chkFiltroQuitado.Checked == false))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Quitado='0' ";
                    }
                    else
                    {
                        filtro += "And Quitado='0' ";
                    }
                }
            }

            if ((chkFiltroNaoQuitado.Checked == false))
            {
                if ((chkFiltroQuitado.Checked == true))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Quitado='1' ";
                    }
                    else
                    {
                        filtro += "And Quitado='1' ";
                    }
                }
            }

            if ((chkFiltroNaoExecutado.Checked == true))
            {
                if ((chkFiltroExecutado.Checked == false))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Executado='0' ";
                    }
                    else
                    {
                        filtro += "And Executado='0' ";
                    }
                }
            }

            if ((chkFiltroNaoExecutado.Checked == false))
            {
                if ((chkFiltroExecutado.Checked == true))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Executado='1' ";
                    }
                    else
                    {
                        filtro += "And Executado='1' ";
                    }
                }
            }

            if ((chkFiltroDemais.Checked == true))
            {
                if ((chkFiltroMensal.Checked == false))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Mensal='0' ";
                    }
                    else
                    {
                        filtro += "And Mensal='0' ";
                    }
                }
            }

            if ((chkFiltroDemais.Checked == false))
            {
                if ((chkFiltroMensal.Checked == true))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Mensal='1' ";
                    }
                    else
                    {
                        filtro += "And Mensal='1' ";
                    }
                }
            }

            BLLPedido bll = new BLLPedido();
            if (filtro == "")
                gcPedidos.DataSource = bll.Filtrar(txtFiltrar.Text, "");
            else
                gcPedidos.DataSource = bll.Filtrar(txtFiltrar.Text, filtro);

            chartLinhaHistorico.DataSource = gcPedidos.DataSource;
            //ccHistorico.Series[0].DataSource = dgLog.DataSource;
            chartLinhaHistorico.Series[0].ArgumentDataMember = "data";
            chartLinhaHistorico.Series[0].ValueDataMembers[0] = "valor";

            if (txtFiltrar.Text == "")
            {
                fp.sbRegistros.Caption = String.Format("{0} registros", gvPedidos.RowCount);
                btnX.Visible = false;
            }
            else
            {
                fp.sbRegistros.Caption = String.Format("{0} registros (filtrado)", gvPedidos.RowCount);
                btnX.Visible = true;
            }

            fp.OcultaAguarde();
        }



        private void frmCalculaTotalPedido_Load(object sender, EventArgs e)
        {
            dtCalc = new DataTable();

            dtCalc.Columns.Add("pedido");
            dtCalc.Columns.Add("cliente");
            dtCalc.Columns.Add("data");
            dtCalc.Columns.Add("valor");
            gcPedidos.DataSource = dtCalc;
            gvPedidos.Columns[0].Width = 55;
            gvPedidos.Columns[1].Width = 200;
            gvPedidos.Columns[2].Width = 100;
            gvPedidos.Columns[3].Width = 100;

            Filtrar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void chkFiltroMensal_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void chkFiltroDemais_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void chkFiltroExecutado_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void chkFiltroNaoExecutado_ChangeUICues(object sender, UICuesEventArgs e)
        {
            Filtrar();
        }

        private void chkFiltroQuitado_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void chkFiltroNaoQuitado_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void txtFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Filtrar();
            if (e.KeyChar == 27) btnX_Click(sender, e);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
            Filtrar();
        }
    }
}