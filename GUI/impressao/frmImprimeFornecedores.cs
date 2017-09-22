using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BLL;

namespace GUI
{
    public partial class frmImprimeFornecedores : DevExpress.XtraReports.UI.XtraReport
    {
        public frmImprimeFornecedores()
        {
            InitializeComponent();
        }

        private void frmImprimeFornecedores_DataSourceDemanded(object sender, EventArgs e)
        {
            FornecedorBLL bll = new FornecedorBLL();
            this.DataSource = bll.Filtrar("");
        }
    }
}
