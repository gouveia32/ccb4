using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BLL;

namespace GUI
{
    public partial class frmImprimeClientes : DevExpress.XtraReports.UI.XtraReport
    {
        public frmImprimeClientes()
        {
            InitializeComponent();
        }

        private void frmImprimeClientes_DataSourceDemanded(object sender, EventArgs e)
        {
            BLLCliente bll = new BLLCliente();
            this.DataSource = bll.Filtrar("");
        }
    }
}
