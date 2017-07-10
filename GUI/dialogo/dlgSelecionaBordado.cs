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
using System.IO;

namespace GUI
{
    public partial class dlgSelecionaBordado : DevExpress.XtraEditors.XtraForm
    {
        public Bordado modeloBordado;

        public dlgSelecionaBordado()
        {
            InitializeComponent();
        }

        private void atalhoDadosDoBordado_Click(object sender, EventArgs e)
        {
            txtObs_Restrita.Visible = !txtObs_Restrita.Visible;
            gvBordados.Columns[3].Visible = txtObs_Restrita.Visible;
            gvNotas.Columns[2].Visible = txtObs_Restrita.Visible;
        }

        public void FiltrarBordados (string filtro)
        {
            BLLBordado bll = new BLLBordado();

            dgBordados.DataSource = bll.Filtrar(filtro);
        }

        private void CarregaDetalhes()
        {
            int bordado_id;

            if (gvBordados.SelectedRowsCount < 1) return;
            bordado_id = Convert.ToInt32(gvBordados.GetDataRow(gvBordados.FocusedRowHandle).ItemArray[0]);

            BLLBordado bll = new BLLBordado();
            
            modeloBordado = bll.CarregaModeloBordado(bordado_id);

            if (modeloBordado.id != null)
            {
                txtObs_publica.Text = modeloBordado.obs_publica;
                txtObs_Restrita.Text = modeloBordado.obs_restrita;
                //Carrega a Imagem
                byte[] img = (byte[])modeloBordado.imagem;

                if (img != null)
                {
                    MemoryStream ms = new MemoryStream(img);
                    pbBordado.Image = Image.FromStream(ms);
                    ms.Dispose();
                }
            }

            //carrega Notas Específicas, se tiver
            BLLNotaEspecifica bllNota = new BLLNotaEspecifica();
            //DataTable tabelaNota = new DataTable();
            dgNotas.DataSource = bllNota.NotasDoBordado(modeloBordado.id);

        }

        private void gvBordados_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    break;
                case Keys.Escape:
                    break;

            }
        }

        private void gvBordados_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //CarregaBordado(Convert.ToInt32(gvBordados.GetDataRow(gvBordados.FocusedRowHandle).ItemArray[0]));
            CarregaDetalhes();
        }

        private void dlgSelecionaBordado_Load(object sender, EventArgs e)
        {
            gvBordados.Columns[3].Visible = gvNotas.Columns[2].Visible = txtObs_Restrita.Visible = false;
            dgBordados.Focus();
            CarregaDetalhes();
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
    }
 }