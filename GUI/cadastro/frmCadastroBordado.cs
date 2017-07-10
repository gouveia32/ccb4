using BLL;
using DevExpress.XtraEditors;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroBordado : GUI.frmModeloCadastro
    {
        frmPrincipal fp;
        private fnLocalizar loc = new fnLocalizar();
        bool flagNotasespecialNova = false;

        public frmCadastroBordado(frmPrincipal _fp)
        {
            InitializeComponent();
            fp = _fp;
        }

        private void LimpaTela()
        {
            txtId.Text = "";
            txtArquivo.Text = "";
            cbGrupo.Text = "";
            txtDescricao.Text = "";
            txtCaminho.Text = "";
            txtBastidor.Text = "";
            txtDisquete.Text = "";
            txtPreco.Text = "";
            txtObs_Publica.Text = "";
            txtObs_Restrita.Text = "";
            txtLargura.Text = "";
            txtAltura.Text = "";
            txtCores.Text = "";
            txtPontos.Text = "";
            picBordado.Image = null;
            picBordadoAmpliado.Image = null;
        }

        private void ModeloParaTela(Bordado modelo)
        {
            try
            {
                gvNotas.Columns[2].Visible = false;
                txtPreco.Visible = false;
                txtObs_Restrita.Visible = false;
                txtId.Text = modelo.id.ToString();
                txtArquivo.Text = modelo.arquivo;

                cbGrupo.SelectedValue = modelo.grupo_id;

                txtDescricao.Text = modelo.descricao;
                txtCaminho.Text = modelo.caminho;
                txtLargura.Text = modelo.largura.ToString();
                txtAltura.Text = modelo.altura.ToString();
                txtCores.Text = modelo.cores.ToString();
                txtPontos.Text = modelo.pontos.ToString();
                txtDisquete.Text = modelo.disquete;
                txtBastidor.Text = modelo.bastidor;
                txtObs_Publica.Text = modelo.obs_publica;
                txtObs_Restrita.Text = modelo.obs_restrita;
                txtPreco.Text = modelo.preco.ToString("N2", CultureInfo.CreateSpecificCulture("pt-BR"));
            }
            catch { }

            //Carrega a Imagem
            byte[] img = (byte[])modelo.imagem;

            if (img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                picBordado.Image = Image.FromStream(ms);
                picBordadoAmpliado.Image = Image.FromStream(ms);
                ms.Dispose();
            }

            //carrega Linhas do bordado
            BLLLinha bll = new BLLLinha();
            DataTable tabela = new DataTable();
            tabela = bll.LinhasDoBordado(modelo.id);
            //dgLinhas_Utilizadas.Rows.Clear();
            dgLinhas_Utilizadas.DataSource = tabela;

            //carrega Notas Específicas, se tiver
            BLLNotaEspecifica bllNota = new BLLNotaEspecifica();
            //DataTable tabelaNota = new DataTable();
            dgNotas.DataSource = bllNota.NotasDoBordado(modelo.id);

            //Carrega catalogos
            BLLCatalogo bllCat = new BLLCatalogo();
            dgCatalogos.DataSource = bllCat.CarregaCatalogosDoBordado(modelo.id);
        }

        private void TelaParaModelo(Bordado modelo)
        {
            modelo.id = Convert.ToInt32(txtId.Text);
            modelo.arquivo = txtArquivo.Text;
            modelo.grupo_id = Convert.ToInt32(cbGrupo.SelectedValue); 
            modelo.descricao = txtDescricao.Text;
            modelo.caminho = txtCaminho.Text;
            modelo.largura = Convert.ToInt32(txtLargura.Text);
            modelo.altura = Convert.ToInt32(txtAltura.Text);
            modelo.cores = Convert.ToInt32(txtCores.Text);
            modelo.pontos = Convert.ToInt32(txtPontos.Text);
            modelo.disquete = txtDisquete.Text;
            modelo.bastidor = txtBastidor.Text;
            modelo.obs_publica = txtObs_Publica.Text;
            modelo.obs_restrita = txtObs_Restrita.Text;
            modelo.preco = txtPreco.Value;
        }

        private void Filtrar(int Posicionar_id = 0)
        {
            fp.MostraAgaurde("Aguarde", "Carregando dados...");
            LimpaTela(); 
            BLLBordado bll = new BLLBordado();
            string where = "";
            if (cbFiltroCatalogo.Text != "Todos")
            {
                where = " catalogos.nome='" + cbFiltroCatalogo.Text + "'"; 
            }
            if (cbFiltroGrupo.Text != "Todos")
            {
                if (where == "")
                   where = " grupo_id=" + cbFiltroGrupo.SelectedValue;
                else
                    where += " AND grupo_id=" + cbFiltroGrupo.SelectedValue;
            }
            dgRegistros.DataSource = bll.Filtrar(txtFiltrar.Text, where);

            if (Posicionar_id > 0)
                loc.Localizar(gdRegistros, "id="+Posicionar_id.ToString(), 0, true);
            if (txtFiltrar.Text == "" && where == "")
            {
                fp.sbRegistros.Caption = String.Format("{0} registros", gdRegistros.RowCount);
                //btnX.Visible = false;
            }
            else
            {
                fp.sbRegistros.Caption = String.Format("{0} registros (filtrado)", gdRegistros.RowCount);
                //btnX.Visible = true;
            }
            fp.OcultaAguarde();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
            cbFiltroCatalogo.SelectedIndex = 0;
            cbFiltroGrupo.SelectedIndex = 0;
            Filtrar();
            //btnX.Visible = false;
        }

        private void txtFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Filtrar();
            if (e.KeyChar == 27) btnX_Click(sender, e);
        }

        private void frmCadastroBordado_Load(object sender, EventArgs e)
        {
            //Filtro Catalogo
            BLLCatalogo c = new BLLCatalogo();
            cbFiltroCatalogo.DataSource = c.TodosCatalogos("Todos");
            cbFiltroCatalogo.DisplayMember = "nome";
            cbFiltroCatalogo.ValueMember = "id";
            //cbFiltroCatalogo.SelectedIndex = 0;

            //CarregaCombo Grupo_id
            BLLGrupo g = new BLLGrupo();
            cbGrupo.DataSource = g.TodosGrupos("");
            cbGrupo.DisplayMember = "grupo";
            cbGrupo.ValueMember = "id";

            //Filtro Grupo
            cbFiltroGrupo.DataSource = g.TodosGrupos("Todos");
            cbFiltroGrupo.DisplayMember = "grupo";
            cbFiltroGrupo.ValueMember = "id";
            cbFiltroGrupo.SelectedIndex = 0;

            Filtrar();

            gdRegistros.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gdRegistros.Columns[0].Width = 60;
            gdRegistros.Columns[1].Width = 150;
            gdRegistros.Columns[2].Width = 200;
            gdRegistros.Columns[3].Visible = false;
            gdRegistros.Columns[4].Visible = false;
        }

        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loc.Localizar(gdRegistros, (sender as TextEdit).Text, 0, true);
        }

        private void CarregaBordado(int bordado_id)
        {
            BLLBordado bll = new BLLBordado();
            Bordado modelo = bll.CarregaModeloBordado(bordado_id);
            ModeloParaTela(modelo);
        }

        private void gdRegistros_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                CarregaBordado(Convert.ToInt32(gdRegistros.GetDataRow(e.FocusedRowHandle).ItemArray[0]));
            }
        }

        private void gdRegistros_DoubleClick(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
            btnAlterar.Down = !btnAlterar.Down;
        }

        private void btnAnterior_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string txtProcurar = Convert.ToString(txtLocalizar.EditValue);

            if (txtProcurar == "")
            {
                //txtLocalizar.Focus();
                return;
            }
            loc.Localizar(gdRegistros, txtProcurar, gdRegistros.FocusedRowHandle - 1, false);
        }

        private void btnProxima_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string txtProcurar = Convert.ToString(txtLocalizar.EditValue);

            if (txtProcurar == "")
            {
                //txtLocalizar.Focus();
                return;
            }
            loc.Localizar(gdRegistros, txtProcurar, gdRegistros.FocusedRowHandle + 1, true);
        }

        private void btnLocalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loc.Localizar(gdRegistros, Convert.ToString(txtLocalizar.EditValue), 0, true);
        }

        private void btnInserir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.operacao = "inserir";
            LimpaTela();
            this.alterabotoes(2);
            txtArquivo.Focus();
        }

        private void btnGravar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idAtual;

            try
            {
                //leitura dos dados
                Bordado modelo = new Bordado();
                TelaParaModelo(modelo);

                //objeto para gravar os dados no bd
                BLLBordado bll = new BLLBordado();

                if (this.operacao == "inserir")
                {
                    //cadastrar novo grupo
                    bll.Incluir(modelo);
                    idAtual = modelo.id;
                    MessageBox.Show("Bordado Inserido. Id=" + modelo.id.ToString());
                    Filtrar(idAtual);
                }
                else
                {
                    //alerar um Bordado
                    idAtual = Convert.ToInt32(txtId.Text);
                    modelo.id = Convert.ToInt32(txtId.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Bordado alterado!");
                    Filtrar(idAtual);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            alterabotoes(2);
        }

        private void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (d.ToString() == "Yes")
                {
                    BLLBordado bll = new BLLBordado();
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

        private void privilegioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvNotas.Columns[2].Visible = !gvNotas.Columns[2].Visible;  //preço
            txtPreco.Visible = gvNotas.Columns[2].Visible;
            txtObs_Restrita.Visible = gvNotas.Columns[2].Visible;
        }

        private void btnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Filtrar();
        }

        private void picBordadoAmpliado_DoubleClick(object sender, EventArgs e)
        {
            picBordadoAmpliado.Visible = !picBordadoAmpliado.Visible;
        }

        private void picBordado_DoubleClick(object sender, EventArgs e)
        {
            picBordadoAmpliado.Visible = !picBordadoAmpliado.Visible;
        }

        private void picBordadoAmpliado_Click(object sender, EventArgs e)
        {
            picBordadoAmpliado.Visible = !picBordadoAmpliado.Visible;
        }

        private void cbFiltroGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltroGrupo.ContainsFocus)
                Filtrar();
        }

        private void cbFiltroCatalogo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFiltroCatalogo.ContainsFocus)
                Filtrar();
        }

        private void GravaNota(dlgNota f)
        {
            BLLNotaEspecifica bll = new BLLNotaEspecifica();
            NotaEspecifica modelo = new NotaEspecifica();
            modelo.bordado_id = Convert.ToInt32(txtId.Text);
            modelo.cliente_id = Convert.ToInt32(f.cbCliente.SelectedValue);
            modelo.data_atualizacao = DateTime.Now;
            modelo.valor = Convert.ToDecimal(f.diValor.Text);
            modelo.obs = f.txtObsEspecifica.Text;

            if (flagNotasespecialNova)
                bll.Insere(modelo);
            else
                bll.Altera(modelo);

            CarregaBordado(Convert.ToInt32(txtId.Text)); //atualiza tela com informaçoes dos bordado selecionado
        }
 
        private void btnEditarNota_Click(object sender, EventArgs e)
        {
            int id;

            flagNotasespecialNova = false;
            if (gvNotas.SelectedRowsCount < 1) return;

            id = Convert.ToInt32(gvNotas.GetDataRow(gvNotas.FocusedRowHandle).ItemArray[0]);
            dlgNota f = new dlgNota();
            f.diValor.Value = Convert.ToDouble(gvNotas.GetDataRow(gvNotas.FocusedRowHandle).ItemArray[2]);
            f.txtObsEspecifica.Text = gvNotas.GetDataRow(gvNotas.FocusedRowHandle).ItemArray[3].ToString();
            f.CarregaComboClientes();
            f.SelecionaClienteNoCombo(id);
            f.cbCliente.Enabled = false;
            if (f.ShowDialog() == DialogResult.OK)
            {
                GravaNota(f);
            }
        }

        private void btnAdicionarNota_Click(object sender, EventArgs e)
        {
            flagNotasespecialNova = true;
            dlgNota f = new dlgNota();
            f.CarregaComboClientes();
            f.cbCliente.Text = "";
            f.diValor.Value = Convert.ToDouble(txtPreco.Text);
            f.txtObsEspecifica.Text = "";

            f.cbCliente.Enabled = true;
            f.cbCliente.Focus();
            if (f.ShowDialog() == DialogResult.OK)
            {
                GravaNota(f);
            }
        }

        private void btnApagarNota_Click(object sender, EventArgs e)
        {
            if (gvNotas.SelectedRowsCount < 1) return;
            BLLNotaEspecifica bll = new BLLNotaEspecifica();
            if (MessageBox.Show("Confirma exclusão? ",
                "NOTA: " + gvNotas.GetDataRow(gvNotas.FocusedRowHandle).ItemArray[1].ToString(), 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.Exclui(Convert.ToInt32(txtId.Text),
                       Convert.ToInt32(gvNotas.GetDataRow(gvNotas.FocusedRowHandle).ItemArray[0]));

                CarregaBordado(Convert.ToInt32(txtId.Text)); //atualiza tela com informaçoes dos bordado selecionado
            }
        }
    }
}
