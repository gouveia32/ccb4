﻿using BLL;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmCadastroLinha : GUI.frmModeloCadastro
    {
        frmPrincipal fp;
        private fnLocalizar loc = new fnLocalizar();

        public frmCadastroLinha(frmPrincipal _fp)
        {
            InitializeComponent();
            fp = _fp;
        }

        private void LimpaTela()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtMaterial_Nome.Text = "";
            txtMaterial_Fabricante.Text = "";
            txtMaterial_Tipo.Text = "";
            txtEstoque_1.Text = "";
            txtEstoque_2.Text = "";
            txtMinimo.Text = "";
            txtPedido.Text = "";
        }

        private void ModeloParaTela(Linha modelo)
        {
            txtCodigo.Text =
            tb_Codigo_Linha_e.Text =
            tb_Codigo_Linha_b.Text =
            tb_Codigo_Linha_m.Text =
            tb_Codigo_Linha_g.Text =
                modelo.codigo.ToString();
            txtNome.Text =
            tbNomeCor_e.Text =
            tbNomeCor_b.Text =
            tbNomeCor_m.Text =
                modelo.nome;
            txtMaterial_Nome.Text = modelo.material_nome;
            txtMaterial_Fabricante.Text = modelo.material_fabricante;
            txtMaterial_Tipo.Text = modelo.material_tipo;
            ceCor.EditValue = modelo.cor;
            txtEstoque_1.Text =
            tbEst1_Atual_e.Text =
            tbEst1_Atual_b.Text =
            tbEst1_Atual_m.Text =
                Convert.ToString(modelo.estoque_1);
            txtEstoque_2.Text =
            tbEst2_Atual_e.Text =
            tbEst2_Atual_b.Text =
            tbEst2_Atual_m.Text =
                Convert.ToString(modelo.estoque_2);
            txtMinimo.Text = Convert.ToString(modelo.minimo);
            txtPedido.Text = Convert.ToString(modelo.pedido);
        }

        private void TelaParaModelo(Linha modelo)
        {
            modelo.codigo = txtCodigo.Text;
            modelo.nome = txtNome.Text;
            modelo.material_nome = txtMaterial_Nome.Text;
            modelo.material_fabricante = txtMaterial_Fabricante.Text;
            modelo.material_tipo = txtMaterial_Tipo.Text;
            modelo.cor = ceCor.Color.ToArgb();
            modelo.estoque_1 = Convert.ToInt32(txtEstoque_1.Text);
            modelo.estoque_2 = Convert.ToInt32(txtEstoque_2.Text);
            modelo.minimo = Convert.ToInt32(txtMinimo.Text);
            modelo.pedido = Convert.ToInt32(txtPedido.Text);
        }

        private void Filtrar(string Posicionar_codigo = "")
        {
            BLLLinha bll = new BLLLinha();
            dgRegistros.DataSource = bll.Filtrar(txtFiltrar.Text);
            if (Posicionar_codigo != "")
                loc.LocalizarX(gdRegistros, Posicionar_codigo, 0, true);
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

        private void frmCadastroLinha_Load(object sender, EventArgs e)
        {
            scc1.SplitterPosition = 500;
            Filtrar();
            gdRegistros.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gdRegistros.Columns[0].Width = 50;
            gdRegistros.Columns[1].Width = 120;
            gdRegistros.Columns[2].Width = 70;
            gdRegistros.Columns[2].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gdRegistros.Columns[3].Width = 70;
            gdRegistros.Columns[4].Width = 100;
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

        private void txtFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Filtrar();
            if (e.KeyChar == 27) btnX_Click(sender, e);
        }

        private void gdRegistros_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                BLLLinha bll = new BLLLinha();
                Linha modelo = bll.CarregaModeloLinha(Convert.ToString(gdRegistros.GetDataRow(e.FocusedRowHandle).ItemArray[0]));
                ModeloParaTela(modelo);
                //alterabotoes(1);

                //Carrega Historico
                BLLLinhaHistorico bllLH = new BLLLinhaHistorico();
                dgLog.DataSource = bllLH.Filtrar("","linha_id=" + Convert.ToInt32(gdRegistros.GetDataRow(e.FocusedRowHandle).ItemArray[0]));

                chartLinhaHistorico.DataSource = dgLog.DataSource;
                //ccHistorico.Series[0].DataSource = dgLog.DataSource;
                chartLinhaHistorico.Series[0].ArgumentDataMember = "mes";
                chartLinhaHistorico.Series[0].ValueDataMembers[0] = "compra";

                chartLinhaHistorico.Series[1].ArgumentDataMember = "mes";
                chartLinhaHistorico.Series[1].ValueDataMembers[0] = "uso";
            }
        }

        private void btnLocalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loc.LocalizarX(gdRegistros, Convert.ToString(txtLocalizar.EditValue), 0, true);
        }

        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loc.LocalizarX(gdRegistros, (sender as TextEdit).Text, 0, true);
        }

        private void gdRegistros_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            if (e.RowHandle != view.FocusedRowHandle && e.Column.Name == "colcor")
                {
                    var cor = Convert.ToInt32(gdRegistros.GetRowCellValue(e.RowHandle, "cor"));
                            e.Column.AppearanceCell.BackColor =
                            e.Column.AppearanceCell.ForeColor = Color.FromArgb(cor);
                }
        }

        private void gdRegistros_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //GridView View = sender as GridView;
            if (e.Column.FieldName == "cor" )
            {
                var cor = Convert.ToInt32(gdRegistros.GetRowCellValue(e.RowHandle, "cor"));
                e.Appearance.BackColor = Color.FromArgb(cor);
            }
        }

        private void btnGravar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string codigoAtual;

            try
            {
                //leitura dos dados
                Linha modelo = new Linha();
                TelaParaModelo(modelo);

                //objeto para gravar os dados no bd
                BLLLinha bll = new BLLLinha();

                if (this.operacao == "inserir")
                {
                    //cadastrar novo grupo
                    bll.Incluir(modelo);
                    codigoAtual = modelo.codigo;
                    MessageBox.Show("Linha Inserida. Código=" + modelo.codigo);
                    Filtrar(codigoAtual);
                }
                else
                {
                    //alerar um cliente
                    codigoAtual = Convert.ToString(txtCodigo.Text);
                    modelo.codigo = Convert.ToString(txtCodigo.Text);
                    bll.Altera(modelo);
                    MessageBox.Show("Linha alterado!");
                    Filtrar(codigoAtual);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            alterabotoes(1);
        }

        private void gdRegistros_DoubleClick(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
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

        private void tbEst1_Quantidade_e_TextChanged(object sender, EventArgs e)
        {
            double num;
            bool isNumber = double.TryParse(tbEst1_Quantidade_e.Text, out num);

            if (isNumber)
               tbEst1_Final_e.Text = Convert.ToString(Convert.ToInt32(tbEst1_Atual_e.Text) +
                                                      Convert.ToInt32(tbEst1_Quantidade_e.Text));
        }

        private void tbEst2_Quantidade_e_TextChanged(object sender, EventArgs e)
        {
            double num;
            bool isNumber = double.TryParse(tbEst2_Quantidade_e.Text, out num);

            if (isNumber)
                tbEst2_Final_e.Text = Convert.ToString(Convert.ToInt32(tbEst2_Atual_e.Text) +
                                                       Convert.ToInt32(tbEst2_Quantidade_e.Text));
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loc.LocalizarX(gdRegistros, Convert.ToString(txtCodigo.Text), 0, true);
            }
        }

        private void tb_Codigo_Linha_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loc.LocalizarX(gdRegistros, Convert.ToString(tb_Codigo_Linha_e.Text), 0, true);
            }
        }

        private void tb_Codigo_Linha_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loc.LocalizarX(gdRegistros, Convert.ToString(tb_Codigo_Linha_b.Text), 0, true);
            }
        }

        private void tb_Codigo_Linha_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loc.LocalizarX(gdRegistros, Convert.ToString(tb_Codigo_Linha_m.Text), 0, true);
            }
        }

        private void tb_Codigo_Linha_g_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loc.LocalizarX(gdRegistros, Convert.ToString(tb_Codigo_Linha_g.Text), 0, true);
                tb_Codigo_Linha_g.Focus();
                tb_Codigo_Linha_g.SelectAll(); 
            }
        }
    }
}
