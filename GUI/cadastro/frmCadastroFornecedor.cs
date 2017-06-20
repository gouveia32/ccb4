using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
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
    public partial class frmCadastroFornecedor : GUI.frmModeloCadastro
    {
        frmPrincipal fp;
        private fnLocalizar loc = new fnLocalizar();

        public frmCadastroFornecedor(frmPrincipal _fp)
        {
            InitializeComponent();
            fp = _fp;
        }

        private void LimpaTela()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtContato_Funcao.Text = "";
            txtContato_Nome.Text = "";
            txtTelefone1.Text = "";
            txtTelefone2.Text = "";
            txtTelefone3.Text = "";
            txtEmail.Text = "";
            txtCgc_Cpf.Text = "";
            txtInscr_Estadual.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCEP.Text = "";
            txtObs.Text = "";
        }

        private void TelaParaModelo(Fornecedor modelo)
        {
            modelo.nome = txtNome.Text;
            modelo.contato_funcao = txtContato_Funcao.Text;
            modelo.contato_nome = txtContato_Nome.Text;
            modelo.cgc_cpf = txtCgc_Cpf.Text;
            modelo.inscr_estadual = txtInscr_Estadual.Text;
            modelo.endereco = txtEndereco.Text;
            modelo.cidade = txtCidade.Text;
            modelo.estado = txtEstado.Text;
            modelo.telefone1 = txtTelefone1.Text;
            modelo.telefone2 = txtTelefone2.Text;
            modelo.telefone3 = txtTelefone3.Text;
            modelo.email = txtEmail.Text;
            modelo.obs = txtObs.Text;
        }

        private void ModeloParaTela(Fornecedor modelo)
        {
            txtId.Text = modelo.id.ToString();
            txtNome.Text = modelo.nome;
            txtContato_Funcao.Text = modelo.contato_funcao;
            txtContato_Nome.Text = modelo.contato_nome;
            txtCgc_Cpf.Text = modelo.cgc_cpf;
            txtInscr_Estadual.Text = modelo.inscr_estadual;
            txtEndereco.Text = modelo.endereco;
            txtCidade.Text = modelo.cidade;
            txtEstado.Text = modelo.estado;
            txtCEP.Text = modelo.cep;
            txtTelefone1.Text = modelo.telefone1;
            txtTelefone2.Text = modelo.telefone2;
            txtTelefone3.Text = modelo.telefone3;
            txtEmail.Text = modelo.email;
            txtObs.Text = modelo.obs;
        }

        private void Filtrar(int Posicionar_id = 0)
        {
            BLLFornecedor bll = new BLLFornecedor();
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

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            Filtrar();

            gdRegistros.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gdRegistros.Columns[0].Width = 80;
            gdRegistros.Columns[1].Width = 350;
            gdRegistros.Columns[1].Width = 300;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
            Filtrar();
            btnX.Visible = false;
        }

        private void gdRegistros_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                BLLFornecedor bll = new BLLFornecedor();
                Fornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(gdRegistros.GetDataRow(e.FocusedRowHandle).ItemArray[0]));
                ModeloParaTela(modelo);
                //alterabotoes(1);
            }
        }

        private void gdRegistros_DoubleClick(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
        }

        private void btnInserir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.operacao = "inserir";
            LimpaTela();
            this.alterabotoes(2);
            txtNome.Focus();
        }

        private void btnGravar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idAtual;

            try
            {
                //leitura dos dados
                Fornecedor modelo = new Fornecedor();
                TelaParaModelo(modelo);

                //objeto para gravar os dados no bd
                BLLFornecedor bll = new BLLFornecedor();

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
                    bll.Altera(modelo);
                    MessageBox.Show("Fornecedor alterado!");
                    Filtrar(idAtual);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            alterabotoes(1);
        }

        private void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (d.ToString() == "Yes")
                {
                    BLLFornecedor bll = new BLLFornecedor();
                    bll.Exclui(Convert.ToInt32(txtId.Text));
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

        private void txtFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Filtrar();
            if (e.KeyChar == 27) btnX_Click(sender, e);
        }

        private void frmCadastroFornecedor_Activated(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Aguarde", "Carregando...");

            frmImprimeFornecedores report = new frmImprimeFornecedores();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print Preview form modally, 
                // and load the report document into it.
                printTool.ShowPreviewDialog();
            }
        }

        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loc.LocalizarX(gdRegistros, (sender as TextEdit).Text, 0, true);
        }

        private void btnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Filtrar();
        }
    }
}
