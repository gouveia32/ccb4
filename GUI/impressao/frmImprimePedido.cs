using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BLL;
using System.Data;
using Modelo;

namespace GUI
{
    public partial class frmImprimePedido : DevExpress.XtraReports.UI.XtraReport
    {
        int Pedido;

        public frmImprimePedido(int _Pedido)
        {
            InitializeComponent();
            Pedido = _Pedido;
        }

        private void frmImprimePedido_DataSourceDemanded(object sender, EventArgs e)
        {
            //Carrega parametros
            ParametroBLLs p = new ParametroBLLs();
            Parametros modelo = p.CarregaModeloParametros(1);
            xlblEndereco.Text = modelo.endereco;
            xlblTelefones.Text = modelo.telefone;

            ItemBLL bll = new ItemBLL();
            DataTable tabela = new DataTable();
            tabela = bll.ItensDoPedido(Pedido);

            this.DataSource  = tabela;
        }
    }
}
