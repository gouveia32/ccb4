using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroGrupos : frmModeloCadastro {
        frmPrincipal fp;
        private fnLocalizar loc = new fnLocalizar();

        public frmCadastroGrupos(frmPrincipal _fp)
        {
            InitializeComponent();
            fp = _fp;
        }

        private void LimpaTela()
        {
            txtId.Text = "";
            txtGrupo.Text = "";
        }

        private void ModeloParaTela(Grupo modelo)
        {
            txtId.Text = modelo.id.ToString();
            txtGrupo.Text = modelo.local;
        }

        private void TelaParaModelo(Grupo modelo)
        {
            if (txtId.Text == "")
                modelo.id = 0;
            else
                modelo.id = Convert.ToInt32(txtId.Text);
            modelo.local = txtGrupo.Text;
        }

        private void Filtrar(int Posicionar_id = 0)
        {
            BLLGrupo bll = new BLLGrupo();
            dgRegistros.DataSource = bll.Filtrar(txtFiltrar.Text);
            dgRegistros.DataSource = bll.Filtrar(txtFiltrar.Text);
            if (Posicionar_id > 0)
                loc.LocalizarX(gdRegistros, Posicionar_id.ToString(), 0, true);
            if (txtFiltrar.Text == "")
            {
                fp.sbRegistros.Caption = String.Format("{0} registros", gdRegistros.RowCount);
                btnX.Visible = false;
            }
            else
            {
                fp.sbRegistros.Caption = String.Format("{0} registros (filtrado)", gdRegistros.RowCount);
                btnX.Visible = true;
            }
        }

        private void frmCadastroGrupos_Load(object sender, EventArgs e)
        {
            scc1.SplitterPosition = 150;
            Filtrar();

            gdRegistros.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gdRegistros.Columns[0].Width = 40;
            gdRegistros.Columns[1].Width = 200;
        }

        private void gdRegistros_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                BLLGrupo bll = new BLLGrupo();
                Grupo modelo = bll.CarregaModeloGrupo(Convert.ToInt32(gdRegistros.GetDataRow(e.FocusedRowHandle).ItemArray[0]));
                ModeloParaTela(modelo);
                //alterabotoes(1);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
            Filtrar();
            btnX.Visible = false;
        }

        private void txtFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Filtrar();
            if (e.KeyChar == 27) btnX_Click(sender, e);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar(); 
        }

        private void btnLocalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            loc.LocalizarX(gdRegistros, Convert.ToString(txtLocalizar.EditValue), 0, true);
        }

        private void btnAnterior_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string txtProcurar = Convert.ToString(txtLocalizar.EditValue);

            if (txtProcurar == "")
            {
                //txtLocalizar.Focus();
                return;
            }
            loc.LocalizarX(gdRegistros, txtProcurar, gdRegistros.FocusedRowHandle - 1, false);
        }

        private void btnProxima_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string txtProcurar = Convert.ToString(txtLocalizar.EditValue);

            if (txtProcurar == "")
            {
                //txtLocalizar.Focus();
                return;
            }
            loc.LocalizarX(gdRegistros, txtProcurar, gdRegistros.FocusedRowHandle + 1, true);

        }

        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loc.LocalizarX(gdRegistros, (sender as TextEdit).Text, 0, true);
        }

        private void btnGravar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idAtual;

            try
            {
                //leitura dos dados
                Grupo modelo = new Grupo();
                TelaParaModelo(modelo);

                //objeto para gravar os dados no bd
                BLLGrupo bll = new BLLGrupo();

                if (this.operacao == "inserir")
                {
                    //cadastrar novo grupo
                    bll.Incluir(modelo);
                    idAtual = modelo.id;
                    MessageBox.Show("Cliente Inserido. Id=" + modelo.id.ToString());
                    Filtrar(idAtual);
                }
                else
                {
                    //alerar um cliente
                    idAtual = Convert.ToInt32(txtId.Text);
                    modelo.id = Convert.ToInt32(txtId.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Grupo alterado!");
                    Filtrar(idAtual);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            alterabotoes(1);
        }

        private void frmCadastroGrupos_Activated(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void gdRegistros_DoubleClick(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
        }

        private void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (d.ToString() == "Yes")
                {
                    BLLGrupo bll = new BLLGrupo();
                    bll.Excluir(Convert.ToInt32(txtId.Text));
                    LimpaTela();
                    Filtrar();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.alterabotoes(3);
            }
        }

        private void btnInserir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.operacao = "inserir";
            LimpaTela();
            this.alterabotoes(2);
            txtGrupo.Focus();
        }

        private void btnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Filtrar();
        }
    }
}
