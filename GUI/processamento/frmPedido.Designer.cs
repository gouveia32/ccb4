﻿using System.IO;

namespace GUI
{
    partial class frmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.deFechamento = new DevExpress.XtraEditors.DateEdit();
            this.deAbertura = new DevExpress.XtraEditors.DateEdit();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btncadastroCliente = new System.Windows.Forms.Button();
            this.btnPesquisar = new DevComponents.DotNetBar.ButtonX();
            this.chkMensal = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkExecutado = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbEmpregado = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtObs_Pedido = new System.Windows.Forms.TextBox();
            this.dgItens = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tot_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_execucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_solicitadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_entregues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_defeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_nao_bordadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontos_extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arte = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aplicacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bordado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cores = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.troca_rapida = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bordado_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotais = new System.Windows.Forms.Panel();
            this.txtTot_Pecas = new DevComponents.Editors.IntegerInput();
            this.txtAmortizacao = new DevComponents.Editors.DoubleInput();
            this.txtTotal_Pedido = new DevComponents.Editors.DoubleInput();
            this.txtDesconto = new DevComponents.Editors.DoubleInput();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtQtde_Itens = new System.Windows.Forms.TextBox();
            this.TabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.txtPC_Entregues = new DevComponents.Editors.IntegerInput();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtTotal_Pontos = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtPontos_Extras = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtPC_Defeito = new System.Windows.Forms.TextBox();
            this.txtPC_Nao_Bordadas = new System.Windows.Forms.TextBox();
            this.btnRestaura = new DevComponents.DotNetBar.ButtonX();
            this.btnGravaLinhas = new DevComponents.DotNetBar.ButtonX();
            this.btnInsereLinha = new DevComponents.DotNetBar.ButtonX();
            this.btnApagaLinha = new DevComponents.DotNetBar.ButtonX();
            this.btnExecutarItem = new DevComponents.DotNetBar.ButtonX();
            this.dtpData_Execucao = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label27 = new System.Windows.Forms.Label();
            this.dgLinhas_Item = new System.Windows.Forms.DataGridView();
            this.seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dePagamento = new DevExpress.XtraEditors.DateEdit();
            this.Saldo = new DevComponents.Editors.DoubleInput();
            this.Total_Pagamento2 = new DevComponents.Editors.DoubleInput();
            this.Pago = new DevComponents.Editors.DoubleInput();
            this.Adicional = new DevComponents.Editors.DoubleInput();
            this.Label30 = new System.Windows.Forms.Label();
            this.ValorAmortizar = new DevComponents.Editors.DoubleInput();
            this.btnAmortizar = new DevComponents.DotNetBar.ButtonX();
            this.cbQuitado = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtObs_Pagamento = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.LinhaIdLabel = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnFiltrar = new DevExpress.XtraEditors.DropDownButton();
            this.btnX = new DevExpress.XtraEditors.DropDownButton();
            this.txtFiltrar = new DevExpress.XtraEditors.TextEdit();
            this.xtabItenPagamentoExecucao = new DevExpress.XtraTab.XtraTabControl();
            this.xtbpItem = new DevExpress.XtraTab.XtraTabPage();
            this.txtBordado_Descricao = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal_Item = new DevComponents.Editors.DoubleInput();
            this.txtPC_Bordadas = new DevComponents.Editors.IntegerInput();
            this.nudBordado_Id = new DevComponents.Editors.IntegerInput();
            this.txtTot_a_pagar = new DevComponents.Editors.DoubleInput();
            this.txtPreco_Por_Peca = new DevComponents.Editors.DoubleInput();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAdicionar = new DevComponents.DotNetBar.ButtonX();
            this.Label20 = new System.Windows.Forms.Label();
            this.txtPC_Solicitadas = new DevComponents.Editors.IntegerInput();
            this.lblPeca_solicitadas = new System.Windows.Forms.Label();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.dtpData_Entrega = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnBaixo = new DevComponents.DotNetBar.ButtonX();
            this.txtBordado_Arquivo = new System.Windows.Forms.TextBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.picBordado = new System.Windows.Forms.PictureBox();
            this.txtBordado_Pontos = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.rg_lado = new DevExpress.XtraEditors.RadioGroup();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.btnApagar = new DevComponents.DotNetBar.ButtonX();
            this.btnCima = new DevComponents.DotNetBar.ButtonX();
            this.Label25 = new System.Windows.Forms.Label();
            this.txtObs_Item = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.lblObs_item = new System.Windows.Forms.Label();
            this.btnInserirItem = new DevComponents.DotNetBar.ButtonX();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtBordado_Preco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.rg_local = new DevExpress.XtraEditors.RadioGroup();
            this.pnlItens = new DevExpress.XtraEditors.PanelControl();
            this.Label19 = new System.Windows.Forms.Label();
            this.xtbpPagamento = new DevExpress.XtraTab.XtraTabPage();
            this.xtbpExecucao = new DevExpress.XtraTab.XtraTabPage();
            this.dgRegistros = new DevExpress.XtraGrid.GridControl();
            this.gdRegistros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chkFiltroDemais = new System.Windows.Forms.CheckBox();
            this.chkFiltroMensal = new System.Windows.Forms.CheckBox();
            this.chkFiltroNaoExecutado = new System.Windows.Forms.CheckBox();
            this.chkFiltroNaoQuitado = new System.Windows.Forms.CheckBox();
            this.chkFiltroExecutado = new System.Windows.Forms.CheckBox();
            this.chkFiltroQuitado = new System.Windows.Forms.CheckBox();
            this.cbFiltroCliente = new System.Windows.Forms.ComboBox();
            this.chkFiltroCliente = new System.Windows.Forms.CheckBox();
            this.ckbPAGO = new DevExpress.XtraEditors.CheckButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tnImprimirCupom = new DevExpress.XtraBars.BarButtonItem();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnProtocolo = new DevExpress.XtraBars.BarButtonItem();
            this.pnlFitro = new DevExpress.XtraEditors.PanelControl();
            this.btnQuitar = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).BeginInit();
            this.scc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechamento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAbertura.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAbertura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).BeginInit();
            this.pnTotais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTot_Pecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmortizacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal_Pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC_Entregues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpData_Execucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLinhas_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePagamento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePagamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Pagamento2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorAmortizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtabItenPagamentoExecucao)).BeginInit();
            this.xtabItenPagamentoExecucao.SuspendLayout();
            this.xtbpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBordado_Descricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC_Bordadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBordado_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTot_a_pagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco_Por_Peca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC_Solicitadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpData_Entrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_lado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_local.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlItens)).BeginInit();
            this.pnlItens.SuspendLayout();
            this.xtbpPagamento.SuspendLayout();
            this.xtbpExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFitro)).BeginInit();
            this.pnlFitro.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tnImprimirCupom,
            this.btnProtocolo});
            this.barManager1.MaxItemId = 17;
            // 
            // btnInserir
            // 
            this.btnInserir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInserir_ItemClick);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGravar_ItemClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAlterar_ItemClick_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLocalizar_ItemClick);
            // 
            // btnAnterior
            // 
            this.btnAnterior.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnterior_ItemClick);
            // 
            // btnProxima
            // 
            this.btnProxima.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProxima_ItemClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImprimir_ItemClick);
            // 
            // scc1
            // 
            this.scc1.Location = new System.Drawing.Point(0, 40);
            this.scc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scc1.Panel1.Controls.Add(this.pnlFitro);
            this.scc1.Panel2.Controls.Add(this.btnQuitar);
            this.scc1.Panel2.Controls.Add(this.ckbPAGO);
            this.scc1.Panel2.Controls.Add(this.deFechamento);
            this.scc1.Panel2.Controls.Add(this.deAbertura);
            this.scc1.Panel2.Controls.Add(this.btnAlterarCliente);
            this.scc1.Panel2.Controls.Add(this.btncadastroCliente);
            this.scc1.Panel2.Controls.Add(this.btnPesquisar);
            this.scc1.Panel2.Controls.Add(this.chkMensal);
            this.scc1.Panel2.Controls.Add(this.chkExecutado);
            this.scc1.Panel2.Controls.Add(this.cbEmpregado);
            this.scc1.Panel2.Controls.Add(this.Label4);
            this.scc1.Panel2.Controls.Add(this.txtObs_Pedido);
            this.scc1.Panel2.Controls.Add(this.LinhaIdLabel);
            this.scc1.Panel2.Controls.Add(this.Label10);
            this.scc1.Panel2.Controls.Add(this.cbCliente);
            this.scc1.Panel2.Controls.Add(this.Label2);
            this.scc1.Panel2.Controls.Add(this.txtId);
            this.scc1.Panel2.Controls.Add(this.Label7);
            this.scc1.Panel2.Controls.Add(this.lblTelefone);
            this.scc1.Panel2.Controls.Add(this.lblCliente);
            this.scc1.Panel2.Controls.Add(this.xtabItenPagamentoExecucao);
            this.scc1.Size = new System.Drawing.Size(1190, 528);
            this.scc1.SplitterPosition = 257;
            this.scc1.SplitterPositionChanged += new System.EventHandler(this.scc1_SplitterPositionChanged);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemTextEdit1_KeyDown);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAtualizar_ItemClick);
            // 
            // bar1
            // 
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.tnImprimirCupom),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProtocolo)});
            this.bar1.OptionsBar.UseWholeRow = true;
            // 
            // deFechamento
            // 
            this.deFechamento.EditValue = null;
            this.deFechamento.Location = new System.Drawing.Point(87, 55);
            this.deFechamento.Name = "deFechamento";
            this.deFechamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechamento.Size = new System.Drawing.Size(100, 20);
            this.deFechamento.TabIndex = 214;
            // 
            // deAbertura
            // 
            this.deAbertura.EditValue = null;
            this.deAbertura.Location = new System.Drawing.Point(87, 32);
            this.deAbertura.Name = "deAbertura";
            this.deAbertura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAbertura.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAbertura.Size = new System.Drawing.Size(100, 20);
            this.deAbertura.TabIndex = 213;
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarCliente.Location = new System.Drawing.Point(651, 3);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(32, 23);
            this.btnAlterarCliente.TabIndex = 212;
            this.btnAlterarCliente.Text = "M";
            // 
            // btncadastroCliente
            // 
            this.btncadastroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncadastroCliente.Location = new System.Drawing.Point(687, 3);
            this.btncadastroCliente.Name = "btncadastroCliente";
            this.btncadastroCliente.Size = new System.Drawing.Size(32, 23);
            this.btncadastroCliente.TabIndex = 210;
            this.btncadastroCliente.Text = "+";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPesquisar.Location = new System.Drawing.Point(627, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(26, 23);
            this.btnPesquisar.TabIndex = 208;
            this.btnPesquisar.Text = "??";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // chkMensal
            // 
            // 
            // 
            // 
            this.chkMensal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkMensal.Location = new System.Drawing.Point(355, 30);
            this.chkMensal.Name = "chkMensal";
            this.chkMensal.Size = new System.Drawing.Size(58, 23);
            this.chkMensal.TabIndex = 207;
            this.chkMensal.Text = "Mensal";
            // 
            // chkExecutado
            // 
            this.chkExecutado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.chkExecutado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkExecutado.Location = new System.Drawing.Point(843, 39);
            this.chkExecutado.Name = "chkExecutado";
            this.chkExecutado.Size = new System.Drawing.Size(75, 23);
            this.chkExecutado.TabIndex = 206;
            this.chkExecutado.Text = "Executado";
            // 
            // cbEmpregado
            // 
            this.cbEmpregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmpregado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmpregado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmpregado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpregado.FormattingEnabled = true;
            this.cbEmpregado.Location = new System.Drawing.Point(813, 5);
            this.cbEmpregado.Name = "cbEmpregado";
            this.cbEmpregado.Size = new System.Drawing.Size(105, 21);
            this.cbEmpregado.TabIndex = 196;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(741, 8);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 13);
            this.Label4.TabIndex = 205;
            this.Label4.Text = "Empregado:";
            // 
            // txtObs_Pedido
            // 
            this.txtObs_Pedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs_Pedido.Location = new System.Drawing.Point(487, 30);
            this.txtObs_Pedido.Multiline = true;
            this.txtObs_Pedido.Name = "txtObs_Pedido";
            this.txtObs_Pedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs_Pedido.Size = new System.Drawing.Size(349, 59);
            this.txtObs_Pedido.TabIndex = 197;
            // 
            // dgItens
            // 
            this.dgItens.AllowUserToAddRows = false;
            this.dgItens.AllowUserToDeleteRows = false;
            this.dgItens.AllowUserToResizeColumns = false;
            this.dgItens.AllowUserToResizeRows = false;
            this.dgItens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.descricao,
            this.data_entrega,
            this.Qtde,
            this.preco,
            this.Tot_Item,
            this.data_execucao,
            this.pc_solicitadas,
            this.pc_entregues,
            this.pc_defeito,
            this.pc_nao_bordadas,
            this.pontos_extras,
            this.material_id,
            this.local_id,
            this.lado,
            this.arte,
            this.aplicacao,
            this.bordado,
            this.cores,
            this.troca_rapida,
            this.obs,
            this.Bordado_Id});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItens.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItens.EnableHeadersVisualStyles = false;
            this.dgItens.Location = new System.Drawing.Point(2, 2);
            this.dgItens.MultiSelect = false;
            this.dgItens.Name = "dgItens";
            this.dgItens.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgItens.RowHeadersVisible = false;
            this.dgItens.RowHeadersWidth = 25;
            this.dgItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgItens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItens.ShowCellErrors = false;
            this.dgItens.ShowCellToolTips = false;
            this.dgItens.ShowEditingIcon = false;
            this.dgItens.ShowRowErrors = false;
            this.dgItens.Size = new System.Drawing.Size(531, 181);
            this.dgItens.TabIndex = 0;
            this.dgItens.TabStop = false;
            this.dgItens.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItens_RowEnter);
            // 
            // item
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.item.DefaultCellStyle = dataGridViewCellStyle1;
            this.item.HeaderText = "Ítem";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.item.Width = 32;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            this.descricao.DefaultCellStyle = dataGridViewCellStyle2;
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // data_entrega
            // 
            dataGridViewCellStyle3.Format = "dd/MM/yy hh:mm";
            this.data_entrega.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_entrega.HeaderText = "data_entrega";
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.ReadOnly = true;
            this.data_entrega.Width = 80;
            // 
            // Qtde
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            this.Qtde.DefaultCellStyle = dataGridViewCellStyle4;
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            this.Qtde.Width = 40;
            // 
            // preco
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.preco.DefaultCellStyle = dataGridViewCellStyle5;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.preco.Width = 40;
            // 
            // Tot_Item
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Tot_Item.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tot_Item.HeaderText = "Tot.Ítem";
            this.Tot_Item.Name = "Tot_Item";
            this.Tot_Item.ReadOnly = true;
            this.Tot_Item.Width = 60;
            // 
            // data_execucao
            // 
            this.data_execucao.HeaderText = "data";
            this.data_execucao.Name = "data_execucao";
            this.data_execucao.ReadOnly = true;
            this.data_execucao.Visible = false;
            // 
            // pc_solicitadas
            // 
            this.pc_solicitadas.HeaderText = "Pc_Solicitadas";
            this.pc_solicitadas.Name = "pc_solicitadas";
            this.pc_solicitadas.ReadOnly = true;
            this.pc_solicitadas.Visible = false;
            // 
            // pc_entregues
            // 
            this.pc_entregues.HeaderText = "Pc_Entregues";
            this.pc_entregues.Name = "pc_entregues";
            this.pc_entregues.ReadOnly = true;
            this.pc_entregues.Visible = false;
            // 
            // pc_defeito
            // 
            this.pc_defeito.HeaderText = "Pc_Defeito";
            this.pc_defeito.Name = "pc_defeito";
            this.pc_defeito.ReadOnly = true;
            this.pc_defeito.Visible = false;
            // 
            // pc_nao_bordadas
            // 
            this.pc_nao_bordadas.HeaderText = "Pc_Nao_Bordadas";
            this.pc_nao_bordadas.Name = "pc_nao_bordadas";
            this.pc_nao_bordadas.ReadOnly = true;
            this.pc_nao_bordadas.Visible = false;
            // 
            // pontos_extras
            // 
            this.pontos_extras.HeaderText = "pontos_extras";
            this.pontos_extras.Name = "pontos_extras";
            this.pontos_extras.ReadOnly = true;
            this.pontos_extras.Visible = false;
            // 
            // material_id
            // 
            this.material_id.HeaderText = "material_id";
            this.material_id.Name = "material_id";
            this.material_id.ReadOnly = true;
            this.material_id.Visible = false;
            // 
            // local_id
            // 
            this.local_id.HeaderText = "local_id";
            this.local_id.Name = "local_id";
            this.local_id.ReadOnly = true;
            this.local_id.Visible = false;
            // 
            // lado
            // 
            this.lado.HeaderText = "lado";
            this.lado.Name = "lado";
            this.lado.ReadOnly = true;
            this.lado.Visible = false;
            // 
            // arte
            // 
            this.arte.HeaderText = "arte";
            this.arte.Name = "arte";
            this.arte.ReadOnly = true;
            this.arte.Visible = false;
            // 
            // aplicacao
            // 
            this.aplicacao.HeaderText = "aplicacao";
            this.aplicacao.Name = "aplicacao";
            this.aplicacao.ReadOnly = true;
            this.aplicacao.Visible = false;
            // 
            // bordado
            // 
            this.bordado.HeaderText = "bordado";
            this.bordado.Name = "bordado";
            this.bordado.ReadOnly = true;
            this.bordado.Visible = false;
            // 
            // cores
            // 
            this.cores.HeaderText = "cores";
            this.cores.Name = "cores";
            this.cores.ReadOnly = true;
            this.cores.Visible = false;
            // 
            // troca_rapida
            // 
            this.troca_rapida.HeaderText = "troca_rapida";
            this.troca_rapida.Name = "troca_rapida";
            this.troca_rapida.ReadOnly = true;
            this.troca_rapida.Visible = false;
            // 
            // obs
            // 
            this.obs.HeaderText = "obs";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Visible = false;
            // 
            // Bordado_Id
            // 
            this.Bordado_Id.HeaderText = "Bordado_Id";
            this.Bordado_Id.Name = "Bordado_Id";
            this.Bordado_Id.ReadOnly = true;
            this.Bordado_Id.Visible = false;
            // 
            // pnTotais
            // 
            this.pnTotais.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnTotais.Controls.Add(this.txtTot_Pecas);
            this.pnTotais.Controls.Add(this.txtAmortizacao);
            this.pnTotais.Controls.Add(this.txtTotal_Pedido);
            this.pnTotais.Controls.Add(this.txtDesconto);
            this.pnTotais.Controls.Add(this.label6);
            this.pnTotais.Controls.Add(this.lblDesconto);
            this.pnTotais.Controls.Add(this.txtQtde_Itens);
            this.pnTotais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTotais.Location = new System.Drawing.Point(2, 183);
            this.pnTotais.Name = "pnTotais";
            this.pnTotais.Size = new System.Drawing.Size(531, 23);
            this.pnTotais.TabIndex = 100;
            // 
            // txtTot_Pecas
            // 
            this.txtTot_Pecas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTot_Pecas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTot_Pecas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTot_Pecas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTot_Pecas.FocusHighlightEnabled = true;
            this.txtTot_Pecas.IsInputReadOnly = true;
            this.txtTot_Pecas.Location = new System.Drawing.Point(381, 1);
            this.txtTot_Pecas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTot_Pecas.Name = "txtTot_Pecas";
            this.txtTot_Pecas.Size = new System.Drawing.Size(48, 21);
            this.txtTot_Pecas.TabIndex = 103;
            // 
            // txtAmortizacao
            // 
            this.txtAmortizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAmortizacao.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtAmortizacao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmortizacao.FocusHighlightEnabled = true;
            this.txtAmortizacao.Increment = 1D;
            this.txtAmortizacao.Location = new System.Drawing.Point(127, 1);
            this.txtAmortizacao.Name = "txtAmortizacao";
            this.txtAmortizacao.Size = new System.Drawing.Size(70, 21);
            this.txtAmortizacao.TabIndex = 101;
            this.txtAmortizacao.ValueChanged += new System.EventHandler(this.txtAmortizacao_ValueChanged);
            // 
            // txtTotal_Pedido
            // 
            this.txtTotal_Pedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTotal_Pedido.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTotal_Pedido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotal_Pedido.FocusHighlightEnabled = true;
            this.txtTotal_Pedido.Increment = 1D;
            this.txtTotal_Pedido.IsInputReadOnly = true;
            this.txtTotal_Pedido.Location = new System.Drawing.Point(460, 1);
            this.txtTotal_Pedido.Name = "txtTotal_Pedido";
            this.txtTotal_Pedido.Size = new System.Drawing.Size(70, 21);
            this.txtTotal_Pedido.TabIndex = 101;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDesconto.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDesconto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDesconto.FocusHighlightEnabled = true;
            this.txtDesconto.Increment = 1D;
            this.txtDesconto.Location = new System.Drawing.Point(274, 1);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(70, 21);
            this.txtDesconto.TabIndex = 101;
            this.txtDesconto.ValueChanged += new System.EventHandler(this.Desconto_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(55, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Amortização:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Location = new System.Drawing.Point(200, 5);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(70, 13);
            this.lblDesconto.TabIndex = 102;
            this.lblDesconto.Text = "Desconto:";
            this.lblDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQtde_Itens
            // 
            this.txtQtde_Itens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtde_Itens.BackColor = System.Drawing.SystemColors.Info;
            this.txtQtde_Itens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtde_Itens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde_Itens.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQtde_Itens.Location = new System.Drawing.Point(4, 5);
            this.txtQtde_Itens.Name = "txtQtde_Itens";
            this.txtQtde_Itens.ReadOnly = true;
            this.txtQtde_Itens.Size = new System.Drawing.Size(40, 13);
            this.txtQtde_Itens.TabIndex = 93;
            this.txtQtde_Itens.TabStop = false;
            this.txtQtde_Itens.Text = "0";
            this.txtQtde_Itens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TabControlPanel3
            // 
            this.TabControlPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.TabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPanel3.Location = new System.Drawing.Point(0, 0);
            this.TabControlPanel3.Name = "TabControlPanel3";
            this.TabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.TabControlPanel3.Size = new System.Drawing.Size(676, 176);
            this.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(145)))), ((int)(((byte)(162)))));
            this.TabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Top)));
            this.TabControlPanel3.Style.GradientAngle = -90;
            this.TabControlPanel3.TabIndex = 0;
            // 
            // txtPC_Entregues
            // 
            // 
            // 
            // 
            this.txtPC_Entregues.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPC_Entregues.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPC_Entregues.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtPC_Entregues.Location = new System.Drawing.Point(602, 84);
            this.txtPC_Entregues.Name = "txtPC_Entregues";
            this.txtPC_Entregues.Size = new System.Drawing.Size(49, 21);
            this.txtPC_Entregues.TabIndex = 113;
            this.txtPC_Entregues.TabStop = false;
            this.txtPC_Entregues.Visible = false;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Location = new System.Drawing.Point(500, 84);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(100, 13);
            this.Label14.TabIndex = 114;
            this.Label14.Text = "Peças Entregues:";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label14.Visible = false;
            // 
            // txtTotal_Pontos
            // 
            this.txtTotal_Pontos.Enabled = false;
            this.txtTotal_Pontos.Location = new System.Drawing.Point(598, 143);
            this.txtTotal_Pontos.Name = "txtTotal_Pontos";
            this.txtTotal_Pontos.Size = new System.Drawing.Size(39, 21);
            this.txtTotal_Pontos.TabIndex = 112;
            this.txtTotal_Pontos.TabStop = false;
            this.txtTotal_Pontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(507, 146);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(87, 13);
            this.Label3.TabIndex = 111;
            this.Label3.Text = "Total de Pontos:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPontos_Extras
            // 
            this.txtPontos_Extras.Location = new System.Drawing.Point(450, 140);
            this.txtPontos_Extras.Name = "txtPontos_Extras";
            this.txtPontos_Extras.Size = new System.Drawing.Size(39, 21);
            this.txtPontos_Extras.TabIndex = 110;
            this.txtPontos_Extras.TabStop = false;
            this.txtPontos_Extras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(359, 143);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 13);
            this.Label1.TabIndex = 109;
            this.Label1.Text = "Pontos Extras:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(350, 84);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(100, 13);
            this.Label12.TabIndex = 105;
            this.Label12.Text = "Defeito ao Bordar:";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(350, 110);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(100, 13);
            this.Label11.TabIndex = 107;
            this.Label11.Text = "Não Bordadas:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPC_Defeito
            // 
            this.txtPC_Defeito.Location = new System.Drawing.Point(452, 81);
            this.txtPC_Defeito.Name = "txtPC_Defeito";
            this.txtPC_Defeito.Size = new System.Drawing.Size(37, 21);
            this.txtPC_Defeito.TabIndex = 106;
            this.txtPC_Defeito.TabStop = false;
            this.txtPC_Defeito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPC_Nao_Bordadas
            // 
            this.txtPC_Nao_Bordadas.Location = new System.Drawing.Point(452, 107);
            this.txtPC_Nao_Bordadas.Name = "txtPC_Nao_Bordadas";
            this.txtPC_Nao_Bordadas.Size = new System.Drawing.Size(37, 21);
            this.txtPC_Nao_Bordadas.TabIndex = 108;
            this.txtPC_Nao_Bordadas.TabStop = false;
            this.txtPC_Nao_Bordadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRestaura
            // 
            this.btnRestaura.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestaura.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRestaura.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaura.Image")));
            this.btnRestaura.Location = new System.Drawing.Point(118, 28);
            this.btnRestaura.Name = "btnRestaura";
            this.btnRestaura.Size = new System.Drawing.Size(34, 34);
            this.btnRestaura.TabIndex = 104;
            // 
            // btnGravaLinhas
            // 
            this.btnGravaLinhas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGravaLinhas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGravaLinhas.Enabled = false;
            this.btnGravaLinhas.Location = new System.Drawing.Point(16, 28);
            this.btnGravaLinhas.Name = "btnGravaLinhas";
            this.btnGravaLinhas.Size = new System.Drawing.Size(34, 34);
            this.btnGravaLinhas.TabIndex = 101;
            // 
            // btnInsereLinha
            // 
            this.btnInsereLinha.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsereLinha.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInsereLinha.Location = new System.Drawing.Point(50, 28);
            this.btnInsereLinha.Name = "btnInsereLinha";
            this.btnInsereLinha.Size = new System.Drawing.Size(34, 34);
            this.btnInsereLinha.TabIndex = 103;
            // 
            // btnApagaLinha
            // 
            this.btnApagaLinha.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnApagaLinha.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnApagaLinha.Location = new System.Drawing.Point(84, 28);
            this.btnApagaLinha.Name = "btnApagaLinha";
            this.btnApagaLinha.Size = new System.Drawing.Size(34, 34);
            this.btnApagaLinha.TabIndex = 102;
            // 
            // btnExecutarItem
            // 
            this.btnExecutarItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExecutarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutarItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExecutarItem.Location = new System.Drawing.Point(19032, 25);
            this.btnExecutarItem.Name = "btnExecutarItem";
            this.btnExecutarItem.Size = new System.Drawing.Size(92, 32);
            this.btnExecutarItem.TabIndex = 100;
            this.btnExecutarItem.Text = "Executar o Ítem";
            // 
            // dtpData_Execucao
            // 
            this.dtpData_Execucao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.dtpData_Execucao.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpData_Execucao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpData_Execucao.ButtonClear.Visible = true;
            this.dtpData_Execucao.ButtonDropDown.Visible = true;
            this.dtpData_Execucao.CustomFormat = "dd/MM/yyyy";
            this.dtpData_Execucao.FocusHighlightEnabled = true;
            this.dtpData_Execucao.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpData_Execucao.IsPopupCalendarOpen = false;
            this.dtpData_Execucao.Location = new System.Drawing.Point(18922, 36);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpData_Execucao.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpData_Execucao.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpData_Execucao.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpData_Execucao.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpData_Execucao.MonthCalendar.DisplayMonth = new System.DateTime(2007, 10, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpData_Execucao.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpData_Execucao.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpData_Execucao.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpData_Execucao.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpData_Execucao.MonthCalendar.TodayButtonVisible = true;
            this.dtpData_Execucao.Name = "dtpData_Execucao";
            this.dtpData_Execucao.Size = new System.Drawing.Size(97, 21);
            this.dtpData_Execucao.TabIndex = 90;
            // 
            // Label27
            // 
            this.Label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label27.BackColor = System.Drawing.Color.Transparent;
            this.Label27.Location = new System.Drawing.Point(18834, 41);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(79, 13);
            this.Label27.TabIndex = 89;
            this.Label27.Text = "Execução:";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgLinhas_Item
            // 
            this.dgLinhas_Item.AllowUserToAddRows = false;
            this.dgLinhas_Item.AllowUserToResizeColumns = false;
            this.dgLinhas_Item.AllowUserToResizeRows = false;
            this.dgLinhas_Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgLinhas_Item.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgLinhas_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgLinhas_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seq,
            this.codigo,
            this.nome,
            this.Cor});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLinhas_Item.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgLinhas_Item.EnableHeadersVisualStyles = false;
            this.dgLinhas_Item.Location = new System.Drawing.Point(16, 63);
            this.dgLinhas_Item.MultiSelect = false;
            this.dgLinhas_Item.Name = "dgLinhas_Item";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLinhas_Item.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgLinhas_Item.RowHeadersVisible = false;
            this.dgLinhas_Item.RowHeadersWidth = 25;
            this.dgLinhas_Item.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgLinhas_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgLinhas_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgLinhas_Item.ShowCellErrors = false;
            this.dgLinhas_Item.ShowCellToolTips = false;
            this.dgLinhas_Item.ShowRowErrors = false;
            this.dgLinhas_Item.Size = new System.Drawing.Size(254, 0);
            this.dgLinhas_Item.TabIndex = 8;
            this.dgLinhas_Item.TabStop = false;
            // 
            // seq
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Info;
            this.seq.DefaultCellStyle = dataGridViewCellStyle9;
            this.seq.HeaderText = "Seq";
            this.seq.Name = "seq";
            this.seq.ReadOnly = true;
            this.seq.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.seq.Width = 35;
            // 
            // codigo
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle10;
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigo.Width = 50;
            // 
            // nome
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Info;
            this.nome.DefaultCellStyle = dataGridViewCellStyle11;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cor
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cor.DefaultCellStyle = dataGridViewCellStyle12;
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cor.Width = 80;
            // 
            // dePagamento
            // 
            this.dePagamento.EditValue = null;
            this.dePagamento.Location = new System.Drawing.Point(150, 26);
            this.dePagamento.Name = "dePagamento";
            this.dePagamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePagamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePagamento.Size = new System.Drawing.Size(100, 20);
            this.dePagamento.TabIndex = 194;
            // 
            // Saldo
            // 
            // 
            // 
            // 
            this.Saldo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Saldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Saldo.Enabled = false;
            this.Saldo.Increment = 1D;
            this.Saldo.Location = new System.Drawing.Point(150, 205);
            this.Saldo.Name = "Saldo";
            this.Saldo.ShowUpDown = true;
            this.Saldo.Size = new System.Drawing.Size(100, 21);
            this.Saldo.TabIndex = 0;
            this.Saldo.TabStop = false;
            // 
            // Total_Pagamento2
            // 
            // 
            // 
            // 
            this.Total_Pagamento2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Total_Pagamento2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Total_Pagamento2.Enabled = false;
            this.Total_Pagamento2.Increment = 1D;
            this.Total_Pagamento2.Location = new System.Drawing.Point(150, 57);
            this.Total_Pagamento2.Name = "Total_Pagamento2";
            this.Total_Pagamento2.ShowUpDown = true;
            this.Total_Pagamento2.Size = new System.Drawing.Size(100, 21);
            this.Total_Pagamento2.TabIndex = 0;
            this.Total_Pagamento2.TabStop = false;
            // 
            // Pago
            // 
            // 
            // 
            // 
            this.Pago.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Pago.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Pago.Enabled = false;
            this.Pago.Increment = 1D;
            this.Pago.Location = new System.Drawing.Point(150, 169);
            this.Pago.Name = "Pago";
            this.Pago.ShowUpDown = true;
            this.Pago.Size = new System.Drawing.Size(100, 21);
            this.Pago.TabIndex = 0;
            this.Pago.TabStop = false;
            // 
            // Adicional
            // 
            // 
            // 
            // 
            this.Adicional.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Adicional.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Adicional.Increment = 1D;
            this.Adicional.Location = new System.Drawing.Point(150, 92);
            this.Adicional.Name = "Adicional";
            this.Adicional.ShowUpDown = true;
            this.Adicional.Size = new System.Drawing.Size(100, 21);
            this.Adicional.TabIndex = 1;
            // 
            // Label30
            // 
            this.Label30.BackColor = System.Drawing.Color.Transparent;
            this.Label30.Location = new System.Drawing.Point(386, 119);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(94, 13);
            this.Label30.TabIndex = 103;
            this.Label30.Text = "Valor à amortizar";
            this.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValorAmortizar
            // 
            // 
            // 
            // 
            this.ValorAmortizar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ValorAmortizar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ValorAmortizar.Increment = 1D;
            this.ValorAmortizar.Location = new System.Drawing.Point(389, 135);
            this.ValorAmortizar.MinValue = 0D;
            this.ValorAmortizar.Name = "ValorAmortizar";
            this.ValorAmortizar.ShowUpDown = true;
            this.ValorAmortizar.Size = new System.Drawing.Size(92, 21);
            this.ValorAmortizar.TabIndex = 0;
            // 
            // btnAmortizar
            // 
            this.btnAmortizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAmortizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAmortizar.Location = new System.Drawing.Point(268, 132);
            this.btnAmortizar.Name = "btnAmortizar";
            this.btnAmortizar.Size = new System.Drawing.Size(92, 23);
            this.btnAmortizar.TabIndex = 101;
            this.btnAmortizar.Text = "Amortizar";
            // 
            // cbQuitado
            // 
            // 
            // 
            // 
            this.cbQuitado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbQuitado.Enabled = false;
            this.cbQuitado.Location = new System.Drawing.Point(285, 22);
            this.cbQuitado.Name = "cbQuitado";
            this.cbQuitado.Size = new System.Drawing.Size(75, 23);
            this.cbQuitado.TabIndex = 100;
            this.cbQuitado.Text = "Quitado";
            // 
            // Label29
            // 
            this.Label29.BackColor = System.Drawing.Color.Transparent;
            this.Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.Location = new System.Drawing.Point(8, 207);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(136, 18);
            this.Label29.TabIndex = 97;
            this.Label29.Text = "Saldo a Pagar:";
            this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.Transparent;
            this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.Location = new System.Drawing.Point(8, 59);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(136, 18);
            this.Label28.TabIndex = 95;
            this.Label28.Text = "Total do Pedido:";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.Color.Transparent;
            this.Label23.Location = new System.Drawing.Point(74, 250);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(70, 13);
            this.Label23.TabIndex = 93;
            this.Label23.Text = "Obsevação:";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label26
            // 
            this.Label26.BackColor = System.Drawing.Color.Transparent;
            this.Label26.Location = new System.Drawing.Point(71, 176);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(73, 13);
            this.Label26.TabIndex = 89;
            this.Label26.Text = "Valor já pago:";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Location = new System.Drawing.Point(32, 29);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(112, 13);
            this.Label18.TabIndex = 83;
            this.Label18.Text = "Data do Pagamento:";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObs_Pagamento
            // 
            this.txtObs_Pagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs_Pagamento.Location = new System.Drawing.Point(150, 247);
            this.txtObs_Pagamento.Multiline = true;
            this.txtObs_Pagamento.Name = "txtObs_Pagamento";
            this.txtObs_Pagamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs_Pagamento.Size = new System.Drawing.Size(19094, 0);
            this.txtObs_Pagamento.TabIndex = 3;
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Location = new System.Drawing.Point(77, 99);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(67, 13);
            this.Label24.TabIndex = 85;
            this.Label24.Text = "Adicional:";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LinhaIdLabel
            // 
            this.LinhaIdLabel.Location = new System.Drawing.Point(37, 8);
            this.LinhaIdLabel.Name = "LinhaIdLabel";
            this.LinhaIdLabel.Size = new System.Drawing.Size(46, 13);
            this.LinhaIdLabel.TabIndex = 199;
            this.LinhaIdLabel.Text = "Pedido:";
            this.LinhaIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(37, 38);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(52, 13);
            this.Label10.TabIndex = 203;
            this.Label10.Text = "Abertura:";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(221, 4);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(397, 21);
            this.cbCliente.Sorted = true;
            this.cbCliente.TabIndex = 198;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(18, 62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 13);
            this.Label2.TabIndex = 204;
            this.Label2.Text = "Fechamento:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Navy;
            this.txtId.Location = new System.Drawing.Point(90, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(65, 29);
            this.txtId.TabIndex = 200;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(456, 39);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(30, 13);
            this.Label7.TabIndex = 202;
            this.Label7.Text = "Obs:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(174, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 13);
            this.lblCliente.TabIndex = 201;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnFiltrar.Location = new System.Drawing.Point(220, 2);
            this.btnFiltrar.MenuManager = this.barManager1;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(36, 21);
            this.btnFiltrar.TabIndex = 58;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnX
            // 
            this.btnX.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnX.Location = new System.Drawing.Point(197, 3);
            this.btnX.MenuManager = this.barManager1;
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(18, 18);
            this.btnX.TabIndex = 57;
            this.btnX.Text = "X";
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(1, 3);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(214, 20);
            this.txtFiltrar.TabIndex = 56;
            this.txtFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltrar_KeyPress);
            // 
            // xtabItenPagamentoExecucao
            // 
            this.xtabItenPagamentoExecucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtabItenPagamentoExecucao.Location = new System.Drawing.Point(0, 81);
            this.xtabItenPagamentoExecucao.Name = "xtabItenPagamentoExecucao";
            this.xtabItenPagamentoExecucao.SelectedTabPage = this.xtbpItem;
            this.xtabItenPagamentoExecucao.Size = new System.Drawing.Size(924, 443);
            this.xtabItenPagamentoExecucao.TabIndex = 106;
            this.xtabItenPagamentoExecucao.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbpItem,
            this.xtbpPagamento,
            this.xtbpExecucao});
            // 
            // xtbpItem
            // 
            this.xtbpItem.Controls.Add(this.txtBordado_Descricao);
            this.xtbpItem.Controls.Add(this.txtTotal_Item);
            this.xtbpItem.Controls.Add(this.txtPC_Bordadas);
            this.xtbpItem.Controls.Add(this.nudBordado_Id);
            this.xtbpItem.Controls.Add(this.txtTot_a_pagar);
            this.xtbpItem.Controls.Add(this.txtPreco_Por_Peca);
            this.xtbpItem.Controls.Add(this.btnImportar);
            this.xtbpItem.Controls.Add(this.btnAdicionar);
            this.xtbpItem.Controls.Add(this.Label20);
            this.xtbpItem.Controls.Add(this.txtPC_Solicitadas);
            this.xtbpItem.Controls.Add(this.lblPeca_solicitadas);
            this.xtbpItem.Controls.Add(this.lblArquivo);
            this.xtbpItem.Controls.Add(this.label8);
            this.xtbpItem.Controls.Add(this.lblLado);
            this.xtbpItem.Controls.Add(this.dtpData_Entrega);
            this.xtbpItem.Controls.Add(this.btnBaixo);
            this.xtbpItem.Controls.Add(this.txtBordado_Arquivo);
            this.xtbpItem.Controls.Add(this.lblDiaSemana);
            this.xtbpItem.Controls.Add(this.Label16);
            this.xtbpItem.Controls.Add(this.picBordado);
            this.xtbpItem.Controls.Add(this.txtBordado_Pontos);
            this.xtbpItem.Controls.Add(this.Label5);
            this.xtbpItem.Controls.Add(this.rg_lado);
            this.xtbpItem.Controls.Add(this.lblDataEntrega);
            this.xtbpItem.Controls.Add(this.btnApagar);
            this.xtbpItem.Controls.Add(this.btnCima);
            this.xtbpItem.Controls.Add(this.Label25);
            this.xtbpItem.Controls.Add(this.txtObs_Item);
            this.xtbpItem.Controls.Add(this.Label21);
            this.xtbpItem.Controls.Add(this.lblObs_item);
            this.xtbpItem.Controls.Add(this.btnInserirItem);
            this.xtbpItem.Controls.Add(this.lblDescricao);
            this.xtbpItem.Controls.Add(this.txtBordado_Preco);
            this.xtbpItem.Controls.Add(this.txtDescricao);
            this.xtbpItem.Controls.Add(this.Label9);
            this.xtbpItem.Controls.Add(this.lblLocal);
            this.xtbpItem.Controls.Add(this.rg_local);
            this.xtbpItem.Controls.Add(this.pnlItens);
            this.xtbpItem.Controls.Add(this.Label19);
            this.xtbpItem.Name = "xtbpItem";
            this.xtbpItem.Size = new System.Drawing.Size(918, 415);
            this.xtbpItem.Text = "Ítem";
            // 
            // txtBordado_Descricao
            // 
            this.txtBordado_Descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Descricao.Location = new System.Drawing.Point(542, 210);
            this.txtBordado_Descricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBordado_Descricao.MenuManager = this.barManager1;
            this.txtBordado_Descricao.Name = "txtBordado_Descricao";
            this.txtBordado_Descricao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtBordado_Descricao.Size = new System.Drawing.Size(372, 20);
            this.txtBordado_Descricao.TabIndex = 153;
            this.txtBordado_Descricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBordado_Descricao_KeyPress);
            // 
            // txtTotal_Item
            // 
            this.txtTotal_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTotal_Item.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTotal_Item.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotal_Item.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal_Item.Increment = 1D;
            this.txtTotal_Item.Location = new System.Drawing.Point(846, 334);
            this.txtTotal_Item.Name = "txtTotal_Item";
            this.txtTotal_Item.Size = new System.Drawing.Size(68, 22);
            this.txtTotal_Item.TabIndex = 152;
            // 
            // txtPC_Bordadas
            // 
            this.txtPC_Bordadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPC_Bordadas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPC_Bordadas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPC_Bordadas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtPC_Bordadas.Enabled = false;
            this.txtPC_Bordadas.Location = new System.Drawing.Point(846, 254);
            this.txtPC_Bordadas.Name = "txtPC_Bordadas";
            this.txtPC_Bordadas.Size = new System.Drawing.Size(68, 21);
            this.txtPC_Bordadas.TabIndex = 116;
            this.txtPC_Bordadas.TabStop = false;
            // 
            // nudBordado_Id
            // 
            this.nudBordado_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.nudBordado_Id.BackgroundStyle.Class = "DateTimeInputBackground";
            this.nudBordado_Id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nudBordado_Id.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.nudBordado_Id.IsInputReadOnly = true;
            this.nudBordado_Id.Location = new System.Drawing.Point(653, 29);
            this.nudBordado_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudBordado_Id.Name = "nudBordado_Id";
            this.nudBordado_Id.Size = new System.Drawing.Size(56, 21);
            this.nudBordado_Id.TabIndex = 103;
            // 
            // txtTot_a_pagar
            // 
            this.txtTot_a_pagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTot_a_pagar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTot_a_pagar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTot_a_pagar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot_a_pagar.Increment = 1D;
            this.txtTot_a_pagar.IsInputReadOnly = true;
            this.txtTot_a_pagar.Location = new System.Drawing.Point(463, 213);
            this.txtTot_a_pagar.Name = "txtTot_a_pagar";
            this.txtTot_a_pagar.Size = new System.Drawing.Size(70, 23);
            this.txtTot_a_pagar.TabIndex = 101;
            // 
            // txtPreco_Por_Peca
            // 
            this.txtPreco_Por_Peca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPreco_Por_Peca.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPreco_Por_Peca.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPreco_Por_Peca.FocusHighlightEnabled = true;
            this.txtPreco_Por_Peca.Increment = 1D;
            this.txtPreco_Por_Peca.Location = new System.Drawing.Point(846, 293);
            this.txtPreco_Por_Peca.Name = "txtPreco_Por_Peca";
            this.txtPreco_Por_Peca.Size = new System.Drawing.Size(68, 21);
            this.txtPreco_Por_Peca.TabIndex = 117;
            this.txtPreco_Por_Peca.ValueChanged += new System.EventHandler(this.txtPreco_Por_Peca_ValueChanged);
            this.txtPreco_Por_Peca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPreco_Por_Peca_KeyDown);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Location = new System.Drawing.Point(552, 285);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(136, 45);
            this.btnImportar.TabIndex = 116;
            this.btnImportar.Text = "Carregar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(541, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btnAdicionar.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdicionar.TabIndex = 143;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Label20
            // 
            this.Label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(894, 314);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(18, 25);
            this.Label20.TabIndex = 139;
            this.Label20.Text = "=";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPC_Solicitadas
            // 
            this.txtPC_Solicitadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPC_Solicitadas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPC_Solicitadas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPC_Solicitadas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtPC_Solicitadas.FocusHighlightEnabled = true;
            this.txtPC_Solicitadas.Location = new System.Drawing.Point(640, 254);
            this.txtPC_Solicitadas.Name = "txtPC_Solicitadas";
            this.txtPC_Solicitadas.Size = new System.Drawing.Size(49, 21);
            this.txtPC_Solicitadas.TabIndex = 115;
            this.txtPC_Solicitadas.ValueChanged += new System.EventHandler(this.txtPC_Solicitadas_ValueChanged);
            this.txtPC_Solicitadas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPC_Solicitadas_KeyDown);
            // 
            // lblPeca_solicitadas
            // 
            this.lblPeca_solicitadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeca_solicitadas.BackColor = System.Drawing.Color.Transparent;
            this.lblPeca_solicitadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeca_solicitadas.Location = new System.Drawing.Point(529, 258);
            this.lblPeca_solicitadas.Name = "lblPeca_solicitadas";
            this.lblPeca_solicitadas.Size = new System.Drawing.Size(100, 13);
            this.lblPeca_solicitadas.TabIndex = 126;
            this.lblPeca_solicitadas.Text = "Peças Solicitadas:";
            this.lblPeca_solicitadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArquivo
            // 
            this.lblArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArquivo.BackColor = System.Drawing.Color.Transparent;
            this.lblArquivo.Location = new System.Drawing.Point(541, 152);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(48, 13);
            this.lblArquivo.TabIndex = 141;
            this.lblArquivo.Text = "Arquivo:";
            this.lblArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 14);
            this.label8.TabIndex = 127;
            this.label8.Text = "Valor a Pagar:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLado
            // 
            this.lblLado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLado.BackColor = System.Drawing.Color.Transparent;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(344, 278);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(49, 14);
            this.lblLado.TabIndex = 127;
            this.lblLado.Text = "Lado:";
            this.lblLado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpData_Entrega
            // 
            this.dtpData_Entrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.dtpData_Entrega.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpData_Entrega.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpData_Entrega.ButtonClear.Visible = true;
            this.dtpData_Entrega.ButtonDropDown.Visible = true;
            this.dtpData_Entrega.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpData_Entrega.FocusHighlightEnabled = true;
            this.dtpData_Entrega.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpData_Entrega.IsPopupCalendarOpen = false;
            this.dtpData_Entrega.Location = new System.Drawing.Point(763, 388);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpData_Entrega.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpData_Entrega.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpData_Entrega.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpData_Entrega.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpData_Entrega.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpData_Entrega.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpData_Entrega.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpData_Entrega.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpData_Entrega.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpData_Entrega.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpData_Entrega.MonthCalendar.DisplayMonth = new System.DateTime(2008, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpData_Entrega.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpData_Entrega.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpData_Entrega.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpData_Entrega.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpData_Entrega.MonthCalendar.TodayButtonVisible = true;
            this.dtpData_Entrega.Name = "dtpData_Entrega";
            this.dtpData_Entrega.Size = new System.Drawing.Size(149, 21);
            this.dtpData_Entrega.TabIndex = 122;
            this.dtpData_Entrega.TextChanged += new System.EventHandler(this.dtpData_Entrega_TextChanged);
            // 
            // btnBaixo
            // 
            this.btnBaixo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaixo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBaixo.Image = ((System.Drawing.Image)(resources.GetObject("btnBaixo.Image")));
            this.btnBaixo.Location = new System.Drawing.Point(542, 116);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDown);
            this.btnBaixo.Size = new System.Drawing.Size(23, 23);
            this.btnBaixo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBaixo.TabIndex = 147;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // txtBordado_Arquivo
            // 
            this.txtBordado_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Arquivo.Location = new System.Drawing.Point(541, 168);
            this.txtBordado_Arquivo.Name = "txtBordado_Arquivo";
            this.txtBordado_Arquivo.Size = new System.Drawing.Size(168, 21);
            this.txtBordado_Arquivo.TabIndex = 117;
            this.txtBordado_Arquivo.TabStop = false;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiaSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.Location = new System.Drawing.Point(760, 368);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(120, 17);
            this.lblDiaSemana.TabIndex = 134;
            this.lblDiaSemana.Text = "...";
            this.lblDiaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label16
            // 
            this.Label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(742, 256);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(105, 16);
            this.Label16.TabIndex = 135;
            this.Label16.Text = "Peças Bordadas:";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picBordado
            // 
            this.picBordado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBordado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.picBordado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBordado.Location = new System.Drawing.Point(715, 2);
            this.picBordado.Name = "picBordado";
            this.picBordado.Size = new System.Drawing.Size(200, 200);
            this.picBordado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBordado.TabIndex = 123;
            this.picBordado.TabStop = false;
            // 
            // txtBordado_Pontos
            // 
            this.txtBordado_Pontos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Pontos.Enabled = false;
            this.txtBordado_Pontos.Location = new System.Drawing.Point(653, 73);
            this.txtBordado_Pontos.Name = "txtBordado_Pontos";
            this.txtBordado_Pontos.Size = new System.Drawing.Size(56, 21);
            this.txtBordado_Pontos.TabIndex = 125;
            this.txtBordado_Pontos.TabStop = false;
            this.txtBordado_Pontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(565, 117);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 13);
            this.Label5.TabIndex = 130;
            this.Label5.Text = "Preço Sugerido:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rg_lado
            // 
            this.rg_lado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rg_lado.Location = new System.Drawing.Point(399, 269);
            this.rg_lado.Name = "rg_lado";
            this.rg_lado.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Esquerdo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Direito")});
            this.rg_lado.Size = new System.Drawing.Size(119, 61);
            this.rg_lado.TabIndex = 149;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDataEntrega.Location = new System.Drawing.Point(663, 396);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(94, 13);
            this.lblDataEntrega.TabIndex = 136;
            this.lblDataEntrega.Text = "Data Entrega:";
            this.lblDataEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnApagar
            // 
            this.btnApagar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.Location = new System.Drawing.Point(541, 32);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDel);
            this.btnApagar.Size = new System.Drawing.Size(23, 23);
            this.btnApagar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnApagar.TabIndex = 144;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnCima
            // 
            this.btnCima.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCima.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCima.Image = ((System.Drawing.Image)(resources.GetObject("btnCima.Image")));
            this.btnCima.Location = new System.Drawing.Point(541, 61);
            this.btnCima.Name = "btnCima";
            this.btnCima.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlUp);
            this.btnCima.Size = new System.Drawing.Size(23, 23);
            this.btnCima.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCima.TabIndex = 145;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // Label25
            // 
            this.Label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label25.BackColor = System.Drawing.Color.Transparent;
            this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location = new System.Drawing.Point(539, 192);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(75, 19);
            this.Label25.TabIndex = 142;
            this.Label25.Text = "Descrição:";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtObs_Item
            // 
            this.txtObs_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObs_Item.Location = new System.Drawing.Point(72, 345);
            this.txtObs_Item.Multiline = true;
            this.txtObs_Item.Name = "txtObs_Item";
            this.txtObs_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs_Item.Size = new System.Drawing.Size(265, 69);
            this.txtObs_Item.TabIndex = 121;
            this.txtObs_Item.TabStop = false;
            // 
            // Label21
            // 
            this.Label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label21.BackColor = System.Drawing.Color.Transparent;
            this.Label21.Location = new System.Drawing.Point(577, 30);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(71, 13);
            this.Label21.TabIndex = 140;
            this.Label21.Text = "Bordado_Id:";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObs_item
            // 
            this.lblObs_item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblObs_item.BackColor = System.Drawing.Color.Transparent;
            this.lblObs_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblObs_item.Location = new System.Drawing.Point(26, 348);
            this.lblObs_item.Name = "lblObs_item";
            this.lblObs_item.Size = new System.Drawing.Size(41, 16);
            this.lblObs_item.TabIndex = 133;
            this.lblObs_item.Text = "Obs.:";
            this.lblObs_item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInserirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInserirItem.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirItem.Image")));
            this.btnInserirItem.Location = new System.Drawing.Point(542, 90);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlIns);
            this.btnInserirItem.Size = new System.Drawing.Size(23, 23);
            this.btnInserirItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInserirItem.TabIndex = 146;
            this.btnInserirItem.Tooltip = "Insere novo ítem abaixo do ítem selecionado.";
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(-9, 242);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 18);
            this.lblDescricao.TabIndex = 132;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBordado_Preco
            // 
            this.txtBordado_Preco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Preco.Enabled = false;
            this.txtBordado_Preco.Location = new System.Drawing.Point(653, 113);
            this.txtBordado_Preco.Name = "txtBordado_Preco";
            this.txtBordado_Preco.Size = new System.Drawing.Size(56, 21);
            this.txtBordado_Preco.TabIndex = 131;
            this.txtBordado_Preco.TabStop = false;
            this.txtBordado_Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescricao.Location = new System.Drawing.Point(72, 242);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(446, 21);
            this.txtDescricao.TabIndex = 120;
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(586, 73);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(59, 20);
            this.Label9.TabIndex = 124;
            this.Label9.Text = "Pontos:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(17, 276);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(49, 14);
            this.lblLocal.TabIndex = 128;
            this.lblLocal.Text = "Local:";
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rg_local
            // 
            this.rg_local.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rg_local.Location = new System.Drawing.Point(72, 271);
            this.rg_local.Name = "rg_local";
            this.rg_local.Size = new System.Drawing.Size(265, 59);
            this.rg_local.TabIndex = 148;
            // 
            // pnlItens
            // 
            this.pnlItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItens.Controls.Add(this.dgItens);
            this.pnlItens.Controls.Add(this.pnTotais);
            this.pnlItens.Location = new System.Drawing.Point(0, 0);
            this.pnlItens.Name = "pnlItens";
            this.pnlItens.Size = new System.Drawing.Size(535, 208);
            this.pnlItens.TabIndex = 0;
            // 
            // Label19
            // 
            this.Label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(883, 271);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(29, 25);
            this.Label19.TabIndex = 138;
            this.Label19.Text = "x";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xtbpPagamento
            // 
            this.xtbpPagamento.Controls.Add(this.dePagamento);
            this.xtbpPagamento.Controls.Add(this.Label18);
            this.xtbpPagamento.Controls.Add(this.Saldo);
            this.xtbpPagamento.Controls.Add(this.Label24);
            this.xtbpPagamento.Controls.Add(this.Total_Pagamento2);
            this.xtbpPagamento.Controls.Add(this.txtObs_Pagamento);
            this.xtbpPagamento.Controls.Add(this.Pago);
            this.xtbpPagamento.Controls.Add(this.Label26);
            this.xtbpPagamento.Controls.Add(this.Adicional);
            this.xtbpPagamento.Controls.Add(this.Label23);
            this.xtbpPagamento.Controls.Add(this.Label30);
            this.xtbpPagamento.Controls.Add(this.Label28);
            this.xtbpPagamento.Controls.Add(this.ValorAmortizar);
            this.xtbpPagamento.Controls.Add(this.Label29);
            this.xtbpPagamento.Controls.Add(this.btnAmortizar);
            this.xtbpPagamento.Controls.Add(this.cbQuitado);
            this.xtbpPagamento.Name = "xtbpPagamento";
            this.xtbpPagamento.Size = new System.Drawing.Size(712, 480);
            this.xtbpPagamento.Text = "Pagamento";
            // 
            // xtbpExecucao
            // 
            this.xtbpExecucao.Controls.Add(this.txtPC_Entregues);
            this.xtbpExecucao.Controls.Add(this.dgLinhas_Item);
            this.xtbpExecucao.Controls.Add(this.Label14);
            this.xtbpExecucao.Controls.Add(this.Label27);
            this.xtbpExecucao.Controls.Add(this.txtTotal_Pontos);
            this.xtbpExecucao.Controls.Add(this.dtpData_Execucao);
            this.xtbpExecucao.Controls.Add(this.Label3);
            this.xtbpExecucao.Controls.Add(this.btnExecutarItem);
            this.xtbpExecucao.Controls.Add(this.txtPontos_Extras);
            this.xtbpExecucao.Controls.Add(this.btnApagaLinha);
            this.xtbpExecucao.Controls.Add(this.Label1);
            this.xtbpExecucao.Controls.Add(this.btnInsereLinha);
            this.xtbpExecucao.Controls.Add(this.Label12);
            this.xtbpExecucao.Controls.Add(this.btnGravaLinhas);
            this.xtbpExecucao.Controls.Add(this.Label11);
            this.xtbpExecucao.Controls.Add(this.btnRestaura);
            this.xtbpExecucao.Controls.Add(this.txtPC_Defeito);
            this.xtbpExecucao.Controls.Add(this.txtPC_Nao_Bordadas);
            this.xtbpExecucao.Name = "xtbpExecucao";
            this.xtbpExecucao.Size = new System.Drawing.Size(712, 480);
            this.xtbpExecucao.Text = "Execução";
            // 
            // dgRegistros
            // 
            this.dgRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Level1";
            this.dgRegistros.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgRegistros.Location = new System.Drawing.Point(-2, 94);
            this.dgRegistros.MainView = this.gdRegistros;
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.Size = new System.Drawing.Size(258, 427);
            this.dgRegistros.TabIndex = 59;
            this.dgRegistros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdRegistros});
            // 
            // gdRegistros
            // 
            this.gdRegistros.DetailHeight = 100;
            this.gdRegistros.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gdRegistros.GridControl = this.dgRegistros;
            this.gdRegistros.Name = "gdRegistros";
            this.gdRegistros.OptionsBehavior.Editable = false;
            this.gdRegistros.OptionsBehavior.SmartVertScrollBar = false;
            this.gdRegistros.OptionsCustomization.AllowColumnMoving = false;
            this.gdRegistros.OptionsCustomization.AllowColumnResizing = false;
            this.gdRegistros.OptionsCustomization.AllowFilter = false;
            this.gdRegistros.OptionsCustomization.AllowGroup = false;
            this.gdRegistros.OptionsCustomization.AllowQuickHideColumns = false;
            this.gdRegistros.OptionsCustomization.AllowSort = false;
            this.gdRegistros.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gdRegistros.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gdRegistros.OptionsFilter.AllowFilterEditor = false;
            this.gdRegistros.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gdRegistros.OptionsFilter.AllowMRUFilterList = false;
            this.gdRegistros.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gdRegistros.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.gdRegistros.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdRegistros.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gdRegistros.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gdRegistros.OptionsView.AllowHtmlDrawGroups = false;
            this.gdRegistros.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gdRegistros.OptionsView.ShowGroupPanel = false;
            this.gdRegistros.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdRegistros_FocusedRowChanged_1);
            this.gdRegistros.DoubleClick += new System.EventHandler(this.gdRegistros_DoubleClick);
            // 
            // chkFiltroDemais
            // 
            this.chkFiltroDemais.AutoSize = true;
            this.chkFiltroDemais.Checked = true;
            this.chkFiltroDemais.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroDemais.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroDemais.Location = new System.Drawing.Point(202, 73);
            this.chkFiltroDemais.Name = "chkFiltroDemais";
            this.chkFiltroDemais.Size = new System.Drawing.Size(55, 16);
            this.chkFiltroDemais.TabIndex = 104;
            this.chkFiltroDemais.Text = "Demais";
            this.chkFiltroDemais.UseVisualStyleBackColor = true;
            this.chkFiltroDemais.CheckedChanged += new System.EventHandler(this.chkFiltroDemais_CheckedChanged);
            // 
            // chkFiltroMensal
            // 
            this.chkFiltroMensal.AutoSize = true;
            this.chkFiltroMensal.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroMensal.Location = new System.Drawing.Point(202, 57);
            this.chkFiltroMensal.Name = "chkFiltroMensal";
            this.chkFiltroMensal.Size = new System.Drawing.Size(54, 16);
            this.chkFiltroMensal.TabIndex = 103;
            this.chkFiltroMensal.Text = "Mensal";
            this.chkFiltroMensal.UseVisualStyleBackColor = true;
            this.chkFiltroMensal.CheckedChanged += new System.EventHandler(this.chkFiltroMensal_CheckedChanged);
            // 
            // chkFiltroNaoExecutado
            // 
            this.chkFiltroNaoExecutado.AutoSize = true;
            this.chkFiltroNaoExecutado.Checked = true;
            this.chkFiltroNaoExecutado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroNaoExecutado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroNaoExecutado.Location = new System.Drawing.Point(89, 75);
            this.chkFiltroNaoExecutado.Name = "chkFiltroNaoExecutado";
            this.chkFiltroNaoExecutado.Size = new System.Drawing.Size(92, 16);
            this.chkFiltroNaoExecutado.TabIndex = 102;
            this.chkFiltroNaoExecutado.Text = "Não Executado";
            this.chkFiltroNaoExecutado.UseVisualStyleBackColor = true;
            this.chkFiltroNaoExecutado.CheckedChanged += new System.EventHandler(this.chkFiltroNaoExecutado_CheckedChanged);
            // 
            // chkFiltroNaoQuitado
            // 
            this.chkFiltroNaoQuitado.AutoSize = true;
            this.chkFiltroNaoQuitado.Checked = true;
            this.chkFiltroNaoQuitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroNaoQuitado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroNaoQuitado.Location = new System.Drawing.Point(6, 73);
            this.chkFiltroNaoQuitado.Name = "chkFiltroNaoQuitado";
            this.chkFiltroNaoQuitado.Size = new System.Drawing.Size(68, 16);
            this.chkFiltroNaoQuitado.TabIndex = 101;
            this.chkFiltroNaoQuitado.Text = "Não Pago";
            this.chkFiltroNaoQuitado.UseVisualStyleBackColor = true;
            this.chkFiltroNaoQuitado.CheckedChanged += new System.EventHandler(this.chkFiltroNaoQuitado_CheckedChanged);
            // 
            // chkFiltroExecutado
            // 
            this.chkFiltroExecutado.AutoSize = true;
            this.chkFiltroExecutado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroExecutado.Location = new System.Drawing.Point(89, 59);
            this.chkFiltroExecutado.Name = "chkFiltroExecutado";
            this.chkFiltroExecutado.Size = new System.Drawing.Size(71, 16);
            this.chkFiltroExecutado.TabIndex = 100;
            this.chkFiltroExecutado.Text = "Executado";
            this.chkFiltroExecutado.UseVisualStyleBackColor = true;
            this.chkFiltroExecutado.CheckedChanged += new System.EventHandler(this.chkFiltroExecutado_CheckedChanged);
            // 
            // chkFiltroQuitado
            // 
            this.chkFiltroQuitado.AutoSize = true;
            this.chkFiltroQuitado.Checked = true;
            this.chkFiltroQuitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroQuitado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroQuitado.Location = new System.Drawing.Point(6, 57);
            this.chkFiltroQuitado.Name = "chkFiltroQuitado";
            this.chkFiltroQuitado.Size = new System.Drawing.Size(47, 16);
            this.chkFiltroQuitado.TabIndex = 99;
            this.chkFiltroQuitado.Text = "Pago";
            this.chkFiltroQuitado.UseVisualStyleBackColor = true;
            this.chkFiltroQuitado.CheckedChanged += new System.EventHandler(this.chkFiltroQuitado_CheckedChanged);
            // 
            // cbFiltroCliente
            // 
            this.cbFiltroCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFiltroCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFiltroCliente.FormattingEnabled = true;
            this.cbFiltroCliente.Location = new System.Drawing.Point(53, 30);
            this.cbFiltroCliente.Name = "cbFiltroCliente";
            this.cbFiltroCliente.Size = new System.Drawing.Size(204, 21);
            this.cbFiltroCliente.TabIndex = 98;
            this.cbFiltroCliente.SelectedIndexChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkFiltroCliente
            // 
            this.chkFiltroCliente.AutoSize = true;
            this.chkFiltroCliente.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroCliente.Location = new System.Drawing.Point(2, 33);
            this.chkFiltroCliente.Name = "chkFiltroCliente";
            this.chkFiltroCliente.Size = new System.Drawing.Size(54, 16);
            this.chkFiltroCliente.TabIndex = 105;
            this.chkFiltroCliente.Text = "Cliente";
            this.chkFiltroCliente.UseVisualStyleBackColor = true;
            this.chkFiltroCliente.CheckedChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // ckbPAGO
            // 
            this.ckbPAGO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ckbPAGO.Location = new System.Drawing.Point(355, 52);
            this.ckbPAGO.Name = "ckbPAGO";
            this.ckbPAGO.Size = new System.Drawing.Size(95, 33);
            this.ckbPAGO.TabIndex = 216;
            this.ckbPAGO.Text = "PAGO";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tnImprimirCupom
            // 
            this.tnImprimirCupom.Caption = "Cupom";
            this.tnImprimirCupom.Glyph = ((System.Drawing.Image)(resources.GetObject("tnImprimirCupom.Glyph")));
            this.tnImprimirCupom.Id = 15;
            this.tnImprimirCupom.Name = "tnImprimirCupom";
            this.tnImprimirCupom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tnImprimirCupom_ItemClick);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(225, 28);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(20, 16);
            this.lblTelefone.TabIndex = 201;
            this.lblTelefone.Text = "...";
            // 
            // btnProtocolo
            // 
            this.btnProtocolo.Caption = "Protocolo";
            this.btnProtocolo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProtocolo.Glyph")));
            this.btnProtocolo.Id = 16;
            this.btnProtocolo.Name = "btnProtocolo";
            this.btnProtocolo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProtocolo_ItemClick);
            // 
            // pnlFitro
            // 
            this.pnlFitro.Controls.Add(this.dgRegistros);
            this.pnlFitro.Controls.Add(this.btnFiltrar);
            this.pnlFitro.Controls.Add(this.chkFiltroDemais);
            this.pnlFitro.Controls.Add(this.cbFiltroCliente);
            this.pnlFitro.Controls.Add(this.chkFiltroMensal);
            this.pnlFitro.Controls.Add(this.chkFiltroNaoExecutado);
            this.pnlFitro.Controls.Add(this.chkFiltroCliente);
            this.pnlFitro.Controls.Add(this.chkFiltroNaoQuitado);
            this.pnlFitro.Controls.Add(this.btnX);
            this.pnlFitro.Controls.Add(this.chkFiltroExecutado);
            this.pnlFitro.Controls.Add(this.txtFiltrar);
            this.pnlFitro.Controls.Add(this.chkFiltroQuitado);
            this.pnlFitro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFitro.Location = new System.Drawing.Point(0, 0);
            this.pnlFitro.Name = "pnlFitro";
            this.pnlFitro.Size = new System.Drawing.Size(257, 524);
            this.pnlFitro.TabIndex = 106;
            // 
            // btnQuitar
            // 
            this.btnQuitar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnQuitar.Location = new System.Drawing.Point(221, 50);
            this.btnQuitar.MenuManager = this.barManager1;
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(124, 37);
            this.btnQuitar.TabIndex = 217;
            this.btnQuitar.Text = "Baixar o Pedido";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1190, 568);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).EndInit();
            this.scc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechamento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAbertura.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAbertura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).EndInit();
            this.pnTotais.ResumeLayout(false);
            this.pnTotais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTot_Pecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmortizacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal_Pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC_Entregues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpData_Execucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLinhas_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePagamento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePagamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Pagamento2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorAmortizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtabItenPagamentoExecucao)).EndInit();
            this.xtabItenPagamentoExecucao.ResumeLayout(false);
            this.xtbpItem.ResumeLayout(false);
            this.xtbpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBordado_Descricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC_Bordadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBordado_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTot_a_pagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco_Por_Peca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC_Solicitadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpData_Entrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_lado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_local.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlItens)).EndInit();
            this.pnlItens.ResumeLayout(false);
            this.xtbpPagamento.ResumeLayout(false);
            this.xtbpPagamento.PerformLayout();
            this.xtbpExecucao.ResumeLayout(false);
            this.xtbpExecucao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFitro)).EndInit();
            this.pnlFitro.ResumeLayout(false);
            this.pnlFitro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deFechamento;
        private DevExpress.XtraEditors.DateEdit deAbertura;
        internal System.Windows.Forms.Button btnAlterarCliente;
        internal System.Windows.Forms.Button btncadastroCliente;
        private DevComponents.DotNetBar.ButtonX btnPesquisar;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkMensal;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkExecutado;
        internal System.Windows.Forms.ComboBox cbEmpregado;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtObs_Pedido;
        internal System.Windows.Forms.DataGridView dgItens;
        internal System.Windows.Forms.DataGridViewTextBoxColumn item;
        internal System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        internal System.Windows.Forms.DataGridViewTextBoxColumn data_entrega;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        internal System.Windows.Forms.DataGridViewTextBoxColumn preco;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Tot_Item;
        internal System.Windows.Forms.DataGridViewTextBoxColumn data_execucao;
        internal System.Windows.Forms.DataGridViewTextBoxColumn pc_solicitadas;
        internal System.Windows.Forms.DataGridViewTextBoxColumn pc_entregues;
        internal System.Windows.Forms.DataGridViewTextBoxColumn pc_defeito;
        internal System.Windows.Forms.DataGridViewTextBoxColumn pc_nao_bordadas;
        internal System.Windows.Forms.DataGridViewTextBoxColumn pontos_extras;
        internal System.Windows.Forms.DataGridViewTextBoxColumn material_id;
        internal System.Windows.Forms.DataGridViewTextBoxColumn local_id;
        internal System.Windows.Forms.DataGridViewTextBoxColumn lado;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn arte;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn aplicacao;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn bordado;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn cores;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn troca_rapida;
        internal System.Windows.Forms.DataGridViewTextBoxColumn obs;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Bordado_Id;
        internal System.Windows.Forms.Panel pnTotais;
        private DevComponents.Editors.DoubleInput txtDesconto;
        internal System.Windows.Forms.Label lblDesconto;
        internal System.Windows.Forms.TextBox txtQtde_Itens;
        private DevComponents.DotNetBar.TabControlPanel TabControlPanel3;
        internal DevComponents.Editors.IntegerInput txtPC_Entregues;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox txtTotal_Pontos;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtPontos_Extras;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtPC_Defeito;
        internal System.Windows.Forms.TextBox txtPC_Nao_Bordadas;
        private DevComponents.DotNetBar.ButtonX btnRestaura;
        private DevComponents.DotNetBar.ButtonX btnGravaLinhas;
        private DevComponents.DotNetBar.ButtonX btnInsereLinha;
        private DevComponents.DotNetBar.ButtonX btnApagaLinha;
        private DevComponents.DotNetBar.ButtonX btnExecutarItem;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpData_Execucao;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.DataGridView dgLinhas_Item;
        internal System.Windows.Forms.DataGridViewTextBoxColumn seq;
        internal System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn nome;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private DevExpress.XtraEditors.DateEdit dePagamento;
        private DevComponents.Editors.DoubleInput Saldo;
        private DevComponents.Editors.DoubleInput Total_Pagamento2;
        private DevComponents.Editors.DoubleInput Pago;
        private DevComponents.Editors.DoubleInput Adicional;
        internal System.Windows.Forms.Label Label30;
        private DevComponents.Editors.DoubleInput ValorAmortizar;
        private DevComponents.DotNetBar.ButtonX btnAmortizar;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbQuitado;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox txtObs_Pagamento;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label LinhaIdLabel;
        internal System.Windows.Forms.Label Label10;
        public System.Windows.Forms.ComboBox cbCliente;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lblCliente;
        private DevExpress.XtraEditors.DropDownButton btnFiltrar;
        private DevExpress.XtraEditors.DropDownButton btnX;
        private DevExpress.XtraEditors.TextEdit txtFiltrar;
        private DevExpress.XtraTab.XtraTabControl xtabItenPagamentoExecucao;
        private DevExpress.XtraTab.XtraTabPage xtbpItem;
        private DevExpress.XtraEditors.PanelControl pnlItens;
        private DevExpress.XtraTab.XtraTabPage xtbpPagamento;
        private DevExpress.XtraTab.XtraTabPage xtbpExecucao;
        private DevExpress.XtraGrid.GridControl dgRegistros;
        private DevExpress.XtraGrid.Views.Grid.GridView gdRegistros;
        private DevComponents.Editors.DoubleInput txtPreco_Por_Peca;
        internal System.Windows.Forms.Button btnImportar;
        internal DevComponents.DotNetBar.ButtonX btnAdicionar;
        internal System.Windows.Forms.Label Label20;
        internal DevComponents.Editors.IntegerInput txtPC_Solicitadas;
        internal System.Windows.Forms.Label lblPeca_solicitadas;
        internal System.Windows.Forms.Label lblArquivo;
        internal System.Windows.Forms.Label lblLado;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpData_Entrega;
        internal DevComponents.DotNetBar.ButtonX btnBaixo;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtBordado_Arquivo;
        internal System.Windows.Forms.Label lblDiaSemana;
        internal System.Windows.Forms.Label Label16;
        public System.Windows.Forms.PictureBox picBordado;
        internal System.Windows.Forms.TextBox txtBordado_Pontos;
        internal System.Windows.Forms.Label Label5;
        internal DevExpress.XtraEditors.RadioGroup rg_lado;
        internal System.Windows.Forms.Label lblDataEntrega;
        internal DevComponents.DotNetBar.ButtonX btnApagar;
        internal DevComponents.DotNetBar.ButtonX btnCima;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.TextBox txtObs_Item;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label lblObs_item;
        internal DevComponents.DotNetBar.ButtonX btnInserirItem;
        internal System.Windows.Forms.Label lblDescricao;
        internal System.Windows.Forms.TextBox txtBordado_Preco;
        internal System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label lblLocal;
        internal DevExpress.XtraEditors.RadioGroup rg_local;
        internal System.Windows.Forms.CheckBox chkFiltroDemais;
        internal System.Windows.Forms.CheckBox chkFiltroMensal;
        internal System.Windows.Forms.CheckBox chkFiltroNaoExecutado;
        internal System.Windows.Forms.CheckBox chkFiltroNaoQuitado;
        internal System.Windows.Forms.CheckBox chkFiltroExecutado;
        internal System.Windows.Forms.CheckBox chkFiltroQuitado;
        internal System.Windows.Forms.ComboBox cbFiltroCliente;
        internal System.Windows.Forms.CheckBox chkFiltroCliente;
        internal DevExpress.XtraEditors.CheckButton ckbPAGO;
        private DevComponents.Editors.DoubleInput txtAmortizacao;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private StringReader leitor;
        private DevExpress.XtraBars.BarButtonItem tnImprimirCupom;
        internal System.Windows.Forms.Label lblTelefone;
        private DevExpress.XtraBars.BarButtonItem btnProtocolo;
        private DevComponents.Editors.DoubleInput txtTot_a_pagar;
        internal System.Windows.Forms.Label label8;
        private DevComponents.Editors.DoubleInput txtTotal_Pedido;
        private DevComponents.Editors.IntegerInput txtTot_Pecas;
        private DevComponents.Editors.IntegerInput nudBordado_Id;
        private DevExpress.XtraEditors.PanelControl pnlFitro;
        private DevExpress.XtraEditors.DropDownButton btnQuitar;
        internal DevComponents.Editors.IntegerInput txtPC_Bordadas;
        private DevComponents.Editors.DoubleInput txtTotal_Item;
        private DevExpress.XtraEditors.TextEdit txtBordado_Descricao;
    }
}
