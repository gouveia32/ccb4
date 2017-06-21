using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class frmModeloCadastro : DevExpress.XtraEditors.XtraForm
    {
        public String operacao;

        public frmModeloCadastro()
        {
            InitializeComponent();
        }
        public void alterabotoes(int op)
        {
            // op = operaçoes que serão feitas com os botes
            // 1 = Prepara botoes para Inserir e Localizar
            // 2 = Preparar para Inserir/Alterar um registro
            // 3 = Prepara para Excluir ou Alterar
            //split1.Expanded  = false;
            scc1.Panel2.Enabled = false;
            scc1.Panel2.Visible = false;
            btnInserir.Enabled = false;
            //btnAlterar.Enabled = false;
            //btnAlterar.Down = true;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnGravar.Enabled = false;
            btnImprimir.Enabled = false;
            btnProxima.Enabled = false;
            btnAnterior.Enabled = false;
            txtLocalizar.Enabled = false;

            if (op == 1)
            {
                scc1.Collapsed = false;
                //scc1.SplitterPosition = 480;
                scc1.Panel2.Visible = true;
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                //btnAlterar.Down = true;
                btnLocalizar.Enabled = true;
                btnImprimir.Enabled = true;
                btnProxima.Enabled = true;
                btnAnterior.Enabled = true;
                txtLocalizar.Enabled = true;
                ///txtLocalizar.Focus();
            }
            if (op == 2)
            {
                scc1.Collapsed = true;
                scc1.Panel2.Enabled = true;
                scc1.Panel2.Visible = true;
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 3)
            {
                scc1.Collapsed = true;
                scc1.Panel2.Enabled = false;
                scc1.Panel2.Visible = true;
                //btnAlterar.Enabled = true;
                btnAlterar.Down = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
        private void btnInserir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.operacao = "inserir";
            this.alterabotoes(2);
        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.alterabotoes(1);
        }

        private void frmModeloCadastro_Load(object sender, EventArgs e)
        {
            this.alterabotoes(1);
        }

        private void btnAlterar_DownChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnAlterar.Down)
            {
                this.operacao = "alterar";
                this.alterabotoes(2);
            }
            else
            {
                this.operacao = "inserir";
                this.alterabotoes(1);
            }
        }
    }
}