using System.IO;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
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
            this.lblEmpregado = new System.Windows.Forms.Label();
            this.txtObs_Pedido = new System.Windows.Forms.TextBox();
            this.pnTotais = new System.Windows.Forms.Panel();
            this.txtTot_Pecas = new DevComponents.Editors.IntegerInput();
            this.txtAmortizacao = new DevComponents.Editors.DoubleInput();
            this.txtTotal_Pedido = new DevComponents.Editors.DoubleInput();
            this.txtDesconto = new DevComponents.Editors.DoubleInput();
            this.lblAmortizacao = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtQtde_Itens = new System.Windows.Forms.TextBox();
            this.TabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.txtPC_Entregues = new DevComponents.Editors.IntegerInput();
            this.lblPc_Entregues = new System.Windows.Forms.Label();
            this.txtTotal_Pontos = new System.Windows.Forms.TextBox();
            this.lblTotalPontos = new System.Windows.Forms.Label();
            this.txtPontos_Extras = new System.Windows.Forms.TextBox();
            this.lblPontosExtras = new System.Windows.Forms.Label();
            this.lblDefeito = new System.Windows.Forms.Label();
            this.lblNaoBordadas = new System.Windows.Forms.Label();
            this.txtPC_Defeito = new System.Windows.Forms.TextBox();
            this.txtPC_Nao_Bordadas = new System.Windows.Forms.TextBox();
            this.btnRestaura = new DevComponents.DotNetBar.ButtonX();
            this.btnGravaLinhas = new DevComponents.DotNetBar.ButtonX();
            this.btnInsereLinha = new DevComponents.DotNetBar.ButtonX();
            this.btnApagaLinha = new DevComponents.DotNetBar.ButtonX();
            this.btnExecutarItem = new DevComponents.DotNetBar.ButtonX();
            this.dtpData_Execucao = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblExecucao = new System.Windows.Forms.Label();
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
            this.lblValoraAmortizar = new System.Windows.Forms.Label();
            this.ValorAmortizar = new DevComponents.Editors.DoubleInput();
            this.btnAmortizar = new DevComponents.DotNetBar.ButtonX();
            this.cbQuitado = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblSaldoaPagar = new System.Windows.Forms.Label();
            this.lblTotalDoPedido = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblValorAPagar = new System.Windows.Forms.Label();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.txtObs_Pagamento = new System.Windows.Forms.TextBox();
            this.lblAdicional = new System.Windows.Forms.Label();
            this.LinhaIdLabel = new System.Windows.Forms.Label();
            this.lblAbertura = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblFechamento = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblObs1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnFiltrar = new DevExpress.XtraEditors.DropDownButton();
            this.btnX = new DevExpress.XtraEditors.DropDownButton();
            this.txtFiltrar = new DevExpress.XtraEditors.TextEdit();
            this.xtabItenPagamentoExecucao = new DevExpress.XtraTab.XtraTabControl();
            this.xtbpItem = new DevExpress.XtraTab.XtraTabPage();
            this.txtBordado_Preco = new DevComponents.Editors.DoubleInput();
            this.txtBordado_Pontos = new DevComponents.Editors.IntegerInput();
            this.txtBordado_Descricao = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal_Item = new DevComponents.Editors.DoubleInput();
            this.txtPC_Bordadas = new DevComponents.Editors.IntegerInput();
            this.nudBordado_Id = new DevComponents.Editors.IntegerInput();
            this.txtTot_a_pagar = new DevComponents.Editors.DoubleInput();
            this.txtPreco_Por_Peca = new DevComponents.Editors.DoubleInput();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAdicionar = new DevComponents.DotNetBar.ButtonX();
            this.lblIgual = new System.Windows.Forms.Label();
            this.txtPC_Solicitadas = new DevComponents.Editors.IntegerInput();
            this.lblPeca_solicitadas = new System.Windows.Forms.Label();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.lblValorApagar1 = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.dtpData_Entrega = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnBaixo = new DevComponents.DotNetBar.ButtonX();
            this.txtBordado_Arquivo = new System.Windows.Forms.TextBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblPecasBordadas = new System.Windows.Forms.Label();
            this.picBordado = new System.Windows.Forms.PictureBox();
            this.lblPrecoSugerido = new System.Windows.Forms.Label();
            this.rg_lado = new DevExpress.XtraEditors.RadioGroup();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.btnApagar = new DevComponents.DotNetBar.ButtonX();
            this.btnCima = new DevComponents.DotNetBar.ButtonX();
            this.lblDescricao1 = new System.Windows.Forms.Label();
            this.txtObs_Item = new System.Windows.Forms.TextBox();
            this.lblBoradado_id = new System.Windows.Forms.Label();
            this.lblObs_item = new System.Windows.Forms.Label();
            this.btnInserirItem = new DevComponents.DotNetBar.ButtonX();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.rg_local = new DevExpress.XtraEditors.RadioGroup();
            this.pnlItens = new DevExpress.XtraEditors.PanelControl();
            this.dgItens = new DevExpress.XtraGrid.GridControl();
            this.gvItens = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPc_solicitadas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData_execucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPc_entregues = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPc_defeito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPc_nao_bordadas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPonto_extras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLolal_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAplicacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBordado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTroca_rapida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBordado_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemColorPickEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.lblX = new System.Windows.Forms.Label();
            this.xtbpPagamento = new DevExpress.XtraTab.XtraTabPage();
            this.xtbpExecucao = new DevExpress.XtraTab.XtraTabPage();
            this.dgRegistros = new DevExpress.XtraGrid.GridControl();
            this.gvRegistros = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaisNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaisFuncaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaisNomeFuncaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaisNomeMesmaTelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).BeginInit();
            this.scc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechamento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAbertura.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAbertura.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtBordado_Preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBordado_Pontos)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit3)).BeginInit();
            this.xtbpPagamento.SuspendLayout();
            this.xtbpExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFitro)).BeginInit();
            this.pnlFitro.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
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
            this.scc1.Location = new System.Drawing.Point(0, 50);
            this.scc1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.scc1.Panel2.Controls.Add(this.lblEmpregado);
            this.scc1.Panel2.Controls.Add(this.txtObs_Pedido);
            this.scc1.Panel2.Controls.Add(this.LinhaIdLabel);
            this.scc1.Panel2.Controls.Add(this.lblAbertura);
            this.scc1.Panel2.Controls.Add(this.cbCliente);
            this.scc1.Panel2.Controls.Add(this.lblFechamento);
            this.scc1.Panel2.Controls.Add(this.txtId);
            this.scc1.Panel2.Controls.Add(this.lblObs1);
            this.scc1.Panel2.Controls.Add(this.lblTelefone);
            this.scc1.Panel2.Controls.Add(this.lblCliente);
            this.scc1.Panel2.Controls.Add(this.xtabItenPagamentoExecucao);
            this.scc1.Size = new System.Drawing.Size(1360, 649);
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
            this.deFechamento.Location = new System.Drawing.Point(101, 68);
            this.deFechamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deFechamento.Name = "deFechamento";
            this.deFechamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechamento.Size = new System.Drawing.Size(117, 22);
            this.deFechamento.TabIndex = 214;
            // 
            // deAbertura
            // 
            this.deAbertura.EditValue = null;
            this.deAbertura.Location = new System.Drawing.Point(101, 39);
            this.deAbertura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deAbertura.Name = "deAbertura";
            this.deAbertura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAbertura.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAbertura.Size = new System.Drawing.Size(117, 22);
            this.deAbertura.TabIndex = 213;
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarCliente.Location = new System.Drawing.Point(733, 4);
            this.btnAlterarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(37, 28);
            this.btnAlterarCliente.TabIndex = 212;
            this.btnAlterarCliente.Text = "M";
            // 
            // btncadastroCliente
            // 
            this.btncadastroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncadastroCliente.Location = new System.Drawing.Point(775, 4);
            this.btncadastroCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncadastroCliente.Name = "btncadastroCliente";
            this.btncadastroCliente.Size = new System.Drawing.Size(37, 28);
            this.btncadastroCliente.TabIndex = 210;
            this.btncadastroCliente.Text = "+";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPesquisar.Location = new System.Drawing.Point(705, 2);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 28);
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
            this.chkMensal.Location = new System.Drawing.Point(414, 37);
            this.chkMensal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMensal.Name = "chkMensal";
            this.chkMensal.Size = new System.Drawing.Size(68, 28);
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
            this.chkExecutado.Location = new System.Drawing.Point(957, 48);
            this.chkExecutado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkExecutado.Name = "chkExecutado";
            this.chkExecutado.Size = new System.Drawing.Size(87, 28);
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
            this.cbEmpregado.Location = new System.Drawing.Point(922, 6);
            this.cbEmpregado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpregado.Name = "cbEmpregado";
            this.cbEmpregado.Size = new System.Drawing.Size(122, 24);
            this.cbEmpregado.TabIndex = 196;
            // 
            // lblEmpregado
            // 
            this.lblEmpregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpregado.AutoSize = true;
            this.lblEmpregado.Location = new System.Drawing.Point(838, 10);
            this.lblEmpregado.Name = "lblEmpregado";
            this.lblEmpregado.Size = new System.Drawing.Size(84, 17);
            this.lblEmpregado.TabIndex = 205;
            this.lblEmpregado.Text = "Empregado:";
            // 
            // txtObs_Pedido
            // 
            this.txtObs_Pedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs_Pedido.Location = new System.Drawing.Point(568, 37);
            this.txtObs_Pedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObs_Pedido.Multiline = true;
            this.txtObs_Pedido.Name = "txtObs_Pedido";
            this.txtObs_Pedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs_Pedido.Size = new System.Drawing.Size(380, 72);
            this.txtObs_Pedido.TabIndex = 197;
            // 
            // pnTotais
            // 
            this.pnTotais.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnTotais.Controls.Add(this.txtTot_Pecas);
            this.pnTotais.Controls.Add(this.txtAmortizacao);
            this.pnTotais.Controls.Add(this.txtTotal_Pedido);
            this.pnTotais.Controls.Add(this.txtDesconto);
            this.pnTotais.Controls.Add(this.lblAmortizacao);
            this.pnTotais.Controls.Add(this.lblDesconto);
            this.pnTotais.Controls.Add(this.txtQtde_Itens);
            this.pnTotais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTotais.Location = new System.Drawing.Point(2, 218);
            this.pnTotais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnTotais.Name = "pnTotais";
            this.pnTotais.Size = new System.Drawing.Size(593, 28);
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
            this.txtTot_Pecas.Location = new System.Drawing.Point(370, 2);
            this.txtTot_Pecas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTot_Pecas.Name = "txtTot_Pecas";
            this.txtTot_Pecas.Size = new System.Drawing.Size(56, 23);
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
            this.txtAmortizacao.Location = new System.Drawing.Point(133, 4);
            this.txtAmortizacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmortizacao.Name = "txtAmortizacao";
            this.txtAmortizacao.Size = new System.Drawing.Size(82, 23);
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
            this.txtTotal_Pedido.Location = new System.Drawing.Point(496, 1);
            this.txtTotal_Pedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal_Pedido.Name = "txtTotal_Pedido";
            this.txtTotal_Pedido.Size = new System.Drawing.Size(82, 23);
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
            this.txtDesconto.Location = new System.Drawing.Point(282, 4);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(82, 23);
            this.txtDesconto.TabIndex = 101;
            this.txtDesconto.ValueChanged += new System.EventHandler(this.Desconto_ValueChanged);
            // 
            // lblAmortizacao
            // 
            this.lblAmortizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmortizacao.BackColor = System.Drawing.Color.Transparent;
            this.lblAmortizacao.Location = new System.Drawing.Point(56, 6);
            this.lblAmortizacao.Name = "lblAmortizacao";
            this.lblAmortizacao.Size = new System.Drawing.Size(82, 16);
            this.lblAmortizacao.TabIndex = 102;
            this.lblAmortizacao.Text = "Amortização:";
            this.lblAmortizacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Location = new System.Drawing.Point(202, 6);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(82, 16);
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
            this.txtQtde_Itens.Location = new System.Drawing.Point(3, 4);
            this.txtQtde_Itens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQtde_Itens.Name = "txtQtde_Itens";
            this.txtQtde_Itens.ReadOnly = true;
            this.txtQtde_Itens.Size = new System.Drawing.Size(47, 16);
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
            this.txtPC_Entregues.Location = new System.Drawing.Point(702, 103);
            this.txtPC_Entregues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPC_Entregues.Name = "txtPC_Entregues";
            this.txtPC_Entregues.Size = new System.Drawing.Size(57, 23);
            this.txtPC_Entregues.TabIndex = 113;
            this.txtPC_Entregues.TabStop = false;
            this.txtPC_Entregues.Visible = false;
            // 
            // lblPc_Entregues
            // 
            this.lblPc_Entregues.BackColor = System.Drawing.Color.Transparent;
            this.lblPc_Entregues.Location = new System.Drawing.Point(583, 103);
            this.lblPc_Entregues.Name = "lblPc_Entregues";
            this.lblPc_Entregues.Size = new System.Drawing.Size(117, 16);
            this.lblPc_Entregues.TabIndex = 114;
            this.lblPc_Entregues.Text = "Peças Entregues:";
            this.lblPc_Entregues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPc_Entregues.Visible = false;
            // 
            // txtTotal_Pontos
            // 
            this.txtTotal_Pontos.Enabled = false;
            this.txtTotal_Pontos.Location = new System.Drawing.Point(698, 176);
            this.txtTotal_Pontos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal_Pontos.Name = "txtTotal_Pontos";
            this.txtTotal_Pontos.Size = new System.Drawing.Size(45, 23);
            this.txtTotal_Pontos.TabIndex = 112;
            this.txtTotal_Pontos.TabStop = false;
            this.txtTotal_Pontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPontos
            // 
            this.lblTotalPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPontos.Location = new System.Drawing.Point(591, 180);
            this.lblTotalPontos.Name = "lblTotalPontos";
            this.lblTotalPontos.Size = new System.Drawing.Size(101, 16);
            this.lblTotalPontos.TabIndex = 111;
            this.lblTotalPontos.Text = "Total de Pontos:";
            this.lblTotalPontos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPontos_Extras
            // 
            this.txtPontos_Extras.Location = new System.Drawing.Point(525, 172);
            this.txtPontos_Extras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPontos_Extras.Name = "txtPontos_Extras";
            this.txtPontos_Extras.Size = new System.Drawing.Size(45, 23);
            this.txtPontos_Extras.TabIndex = 110;
            this.txtPontos_Extras.TabStop = false;
            this.txtPontos_Extras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPontosExtras
            // 
            this.lblPontosExtras.BackColor = System.Drawing.Color.Transparent;
            this.lblPontosExtras.Location = new System.Drawing.Point(419, 176);
            this.lblPontosExtras.Name = "lblPontosExtras";
            this.lblPontosExtras.Size = new System.Drawing.Size(101, 16);
            this.lblPontosExtras.TabIndex = 109;
            this.lblPontosExtras.Text = "Pontos Extras:";
            this.lblPontosExtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefeito
            // 
            this.lblDefeito.BackColor = System.Drawing.Color.Transparent;
            this.lblDefeito.Location = new System.Drawing.Point(408, 103);
            this.lblDefeito.Name = "lblDefeito";
            this.lblDefeito.Size = new System.Drawing.Size(117, 16);
            this.lblDefeito.TabIndex = 105;
            this.lblDefeito.Text = "Defeito ao Bordar:";
            this.lblDefeito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNaoBordadas
            // 
            this.lblNaoBordadas.BackColor = System.Drawing.Color.Transparent;
            this.lblNaoBordadas.Location = new System.Drawing.Point(408, 135);
            this.lblNaoBordadas.Name = "lblNaoBordadas";
            this.lblNaoBordadas.Size = new System.Drawing.Size(117, 16);
            this.lblNaoBordadas.TabIndex = 107;
            this.lblNaoBordadas.Text = "Não Bordadas:";
            this.lblNaoBordadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPC_Defeito
            // 
            this.txtPC_Defeito.Location = new System.Drawing.Point(527, 100);
            this.txtPC_Defeito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPC_Defeito.Name = "txtPC_Defeito";
            this.txtPC_Defeito.Size = new System.Drawing.Size(42, 23);
            this.txtPC_Defeito.TabIndex = 106;
            this.txtPC_Defeito.TabStop = false;
            this.txtPC_Defeito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPC_Nao_Bordadas
            // 
            this.txtPC_Nao_Bordadas.Location = new System.Drawing.Point(527, 132);
            this.txtPC_Nao_Bordadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPC_Nao_Bordadas.Name = "txtPC_Nao_Bordadas";
            this.txtPC_Nao_Bordadas.Size = new System.Drawing.Size(42, 23);
            this.txtPC_Nao_Bordadas.TabIndex = 108;
            this.txtPC_Nao_Bordadas.TabStop = false;
            this.txtPC_Nao_Bordadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRestaura
            // 
            this.btnRestaura.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestaura.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRestaura.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaura.Image")));
            this.btnRestaura.Location = new System.Drawing.Point(138, 34);
            this.btnRestaura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestaura.Name = "btnRestaura";
            this.btnRestaura.Size = new System.Drawing.Size(40, 42);
            this.btnRestaura.TabIndex = 104;
            // 
            // btnGravaLinhas
            // 
            this.btnGravaLinhas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGravaLinhas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGravaLinhas.Enabled = false;
            this.btnGravaLinhas.Location = new System.Drawing.Point(19, 34);
            this.btnGravaLinhas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravaLinhas.Name = "btnGravaLinhas";
            this.btnGravaLinhas.Size = new System.Drawing.Size(40, 42);
            this.btnGravaLinhas.TabIndex = 101;
            // 
            // btnInsereLinha
            // 
            this.btnInsereLinha.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsereLinha.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInsereLinha.Location = new System.Drawing.Point(58, 34);
            this.btnInsereLinha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsereLinha.Name = "btnInsereLinha";
            this.btnInsereLinha.Size = new System.Drawing.Size(40, 42);
            this.btnInsereLinha.TabIndex = 103;
            // 
            // btnApagaLinha
            // 
            this.btnApagaLinha.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnApagaLinha.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnApagaLinha.Location = new System.Drawing.Point(98, 34);
            this.btnApagaLinha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApagaLinha.Name = "btnApagaLinha";
            this.btnApagaLinha.Size = new System.Drawing.Size(40, 42);
            this.btnApagaLinha.TabIndex = 102;
            // 
            // btnExecutarItem
            // 
            this.btnExecutarItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExecutarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutarItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExecutarItem.Location = new System.Drawing.Point(27736, 31);
            this.btnExecutarItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExecutarItem.Name = "btnExecutarItem";
            this.btnExecutarItem.Size = new System.Drawing.Size(107, 39);
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
            this.dtpData_Execucao.Location = new System.Drawing.Point(27607, 44);
            this.dtpData_Execucao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.dtpData_Execucao.Size = new System.Drawing.Size(113, 23);
            this.dtpData_Execucao.TabIndex = 90;
            // 
            // lblExecucao
            // 
            this.lblExecucao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExecucao.BackColor = System.Drawing.Color.Transparent;
            this.lblExecucao.Location = new System.Drawing.Point(27505, 50);
            this.lblExecucao.Name = "lblExecucao";
            this.lblExecucao.Size = new System.Drawing.Size(92, 16);
            this.lblExecucao.TabIndex = 89;
            this.lblExecucao.Text = "Execução:";
            this.lblExecucao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLinhas_Item.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgLinhas_Item.EnableHeadersVisualStyles = false;
            this.dgLinhas_Item.Location = new System.Drawing.Point(19, 78);
            this.dgLinhas_Item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgLinhas_Item.MultiSelect = false;
            this.dgLinhas_Item.Name = "dgLinhas_Item";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLinhas_Item.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgLinhas_Item.RowHeadersVisible = false;
            this.dgLinhas_Item.RowHeadersWidth = 25;
            this.dgLinhas_Item.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgLinhas_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgLinhas_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgLinhas_Item.ShowCellErrors = false;
            this.dgLinhas_Item.ShowCellToolTips = false;
            this.dgLinhas_Item.ShowRowErrors = false;
            this.dgLinhas_Item.Size = new System.Drawing.Size(296, 0);
            this.dgLinhas_Item.TabIndex = 8;
            this.dgLinhas_Item.TabStop = false;
            // 
            // seq
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.seq.DefaultCellStyle = dataGridViewCellStyle1;
            this.seq.HeaderText = "Seq";
            this.seq.Name = "seq";
            this.seq.ReadOnly = true;
            this.seq.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.seq.Width = 35;
            // 
            // codigo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigo.Width = 50;
            // 
            // nome
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            this.nome.DefaultCellStyle = dataGridViewCellStyle3;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cor
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cor.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cor.Width = 80;
            // 
            // dePagamento
            // 
            this.dePagamento.EditValue = null;
            this.dePagamento.Location = new System.Drawing.Point(175, 32);
            this.dePagamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dePagamento.Name = "dePagamento";
            this.dePagamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePagamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePagamento.Size = new System.Drawing.Size(117, 22);
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
            this.Saldo.Location = new System.Drawing.Point(175, 252);
            this.Saldo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Saldo.Name = "Saldo";
            this.Saldo.ShowUpDown = true;
            this.Saldo.Size = new System.Drawing.Size(117, 23);
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
            this.Total_Pagamento2.Location = new System.Drawing.Point(175, 70);
            this.Total_Pagamento2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total_Pagamento2.Name = "Total_Pagamento2";
            this.Total_Pagamento2.ShowUpDown = true;
            this.Total_Pagamento2.Size = new System.Drawing.Size(117, 23);
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
            this.Pago.Location = new System.Drawing.Point(175, 208);
            this.Pago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pago.Name = "Pago";
            this.Pago.ShowUpDown = true;
            this.Pago.Size = new System.Drawing.Size(117, 23);
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
            this.Adicional.Location = new System.Drawing.Point(175, 113);
            this.Adicional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Adicional.Name = "Adicional";
            this.Adicional.ShowUpDown = true;
            this.Adicional.Size = new System.Drawing.Size(117, 23);
            this.Adicional.TabIndex = 1;
            // 
            // lblValoraAmortizar
            // 
            this.lblValoraAmortizar.BackColor = System.Drawing.Color.Transparent;
            this.lblValoraAmortizar.Location = new System.Drawing.Point(450, 146);
            this.lblValoraAmortizar.Name = "lblValoraAmortizar";
            this.lblValoraAmortizar.Size = new System.Drawing.Size(110, 16);
            this.lblValoraAmortizar.TabIndex = 103;
            this.lblValoraAmortizar.Text = "Valor à amortizar";
            this.lblValoraAmortizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValorAmortizar
            // 
            // 
            // 
            // 
            this.ValorAmortizar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ValorAmortizar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ValorAmortizar.Increment = 1D;
            this.ValorAmortizar.Location = new System.Drawing.Point(454, 166);
            this.ValorAmortizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValorAmortizar.MinValue = 0D;
            this.ValorAmortizar.Name = "ValorAmortizar";
            this.ValorAmortizar.ShowUpDown = true;
            this.ValorAmortizar.Size = new System.Drawing.Size(107, 23);
            this.ValorAmortizar.TabIndex = 0;
            // 
            // btnAmortizar
            // 
            this.btnAmortizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAmortizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAmortizar.Location = new System.Drawing.Point(313, 162);
            this.btnAmortizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAmortizar.Name = "btnAmortizar";
            this.btnAmortizar.Size = new System.Drawing.Size(107, 28);
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
            this.cbQuitado.Location = new System.Drawing.Point(332, 27);
            this.cbQuitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbQuitado.Name = "cbQuitado";
            this.cbQuitado.Size = new System.Drawing.Size(87, 28);
            this.cbQuitado.TabIndex = 100;
            this.cbQuitado.Text = "Quitado";
            // 
            // lblSaldoaPagar
            // 
            this.lblSaldoaPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoaPagar.Location = new System.Drawing.Point(9, 255);
            this.lblSaldoaPagar.Name = "lblSaldoaPagar";
            this.lblSaldoaPagar.Size = new System.Drawing.Size(159, 22);
            this.lblSaldoaPagar.TabIndex = 97;
            this.lblSaldoaPagar.Text = "Saldo a Pagar:";
            this.lblSaldoaPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDoPedido
            // 
            this.lblTotalDoPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoPedido.Location = new System.Drawing.Point(9, 73);
            this.lblTotalDoPedido.Name = "lblTotalDoPedido";
            this.lblTotalDoPedido.Size = new System.Drawing.Size(159, 22);
            this.lblTotalDoPedido.TabIndex = 95;
            this.lblTotalDoPedido.Text = "Total do Pedido:";
            this.lblTotalDoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObs
            // 
            this.lblObs.BackColor = System.Drawing.Color.Transparent;
            this.lblObs.Location = new System.Drawing.Point(86, 308);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(82, 16);
            this.lblObs.TabIndex = 93;
            this.lblObs.Text = "Obsevação:";
            this.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValorAPagar
            // 
            this.lblValorAPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblValorAPagar.Location = new System.Drawing.Point(83, 217);
            this.lblValorAPagar.Name = "lblValorAPagar";
            this.lblValorAPagar.Size = new System.Drawing.Size(85, 16);
            this.lblValorAPagar.TabIndex = 89;
            this.lblValorAPagar.Text = "Valor já pago:";
            this.lblValorAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataPagamento.Location = new System.Drawing.Point(37, 36);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(131, 16);
            this.lblDataPagamento.TabIndex = 83;
            this.lblDataPagamento.Text = "Data do Pagamento:";
            this.lblDataPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObs_Pagamento
            // 
            this.txtObs_Pagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs_Pagamento.Location = new System.Drawing.Point(175, 304);
            this.txtObs_Pagamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObs_Pagamento.Multiline = true;
            this.txtObs_Pagamento.Name = "txtObs_Pagamento";
            this.txtObs_Pagamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs_Pagamento.Size = new System.Drawing.Size(27807, 0);
            this.txtObs_Pagamento.TabIndex = 3;
            // 
            // lblAdicional
            // 
            this.lblAdicional.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicional.Location = new System.Drawing.Point(90, 122);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(78, 16);
            this.lblAdicional.TabIndex = 85;
            this.lblAdicional.Text = "Adicional:";
            this.lblAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LinhaIdLabel
            // 
            this.LinhaIdLabel.Location = new System.Drawing.Point(43, 10);
            this.LinhaIdLabel.Name = "LinhaIdLabel";
            this.LinhaIdLabel.Size = new System.Drawing.Size(54, 16);
            this.LinhaIdLabel.TabIndex = 199;
            this.LinhaIdLabel.Text = "Pedido:";
            this.LinhaIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAbertura
            // 
            this.lblAbertura.Location = new System.Drawing.Point(43, 47);
            this.lblAbertura.Name = "lblAbertura";
            this.lblAbertura.Size = new System.Drawing.Size(61, 16);
            this.lblAbertura.TabIndex = 203;
            this.lblAbertura.Text = "Abertura:";
            this.lblAbertura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(258, 5);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(436, 24);
            this.cbCliente.Sorted = true;
            this.cbCliente.TabIndex = 198;
            this.cbCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCliente_KeyDown);
            this.cbCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCliente_KeyPress);
            // 
            // lblFechamento
            // 
            this.lblFechamento.Location = new System.Drawing.Point(21, 76);
            this.lblFechamento.Name = "lblFechamento";
            this.lblFechamento.Size = new System.Drawing.Size(84, 16);
            this.lblFechamento.TabIndex = 204;
            this.lblFechamento.Text = "Fechamento:";
            this.lblFechamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Navy;
            this.txtId.Location = new System.Drawing.Point(105, 0);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(75, 34);
            this.txtId.TabIndex = 200;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblObs1
            // 
            this.lblObs1.AutoSize = true;
            this.lblObs1.Location = new System.Drawing.Point(532, 48);
            this.lblObs1.Name = "lblObs1";
            this.lblObs1.Size = new System.Drawing.Size(37, 17);
            this.lblObs1.TabIndex = 202;
            this.lblObs1.Text = "Obs:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(203, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(53, 17);
            this.lblCliente.TabIndex = 201;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnFiltrar.Location = new System.Drawing.Point(257, 2);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.MenuManager = this.barManager1;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(42, 26);
            this.btnFiltrar.TabIndex = 58;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnX
            // 
            this.btnX.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnX.Location = new System.Drawing.Point(230, 4);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnX.MenuManager = this.barManager1;
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(21, 22);
            this.btnX.TabIndex = 57;
            this.btnX.Text = "X";
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(1, 4);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(250, 22);
            this.txtFiltrar.TabIndex = 56;
            this.txtFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltrar_KeyPress);
            // 
            // xtabItenPagamentoExecucao
            // 
            this.xtabItenPagamentoExecucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtabItenPagamentoExecucao.Location = new System.Drawing.Point(0, 100);
            this.xtabItenPagamentoExecucao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtabItenPagamentoExecucao.Name = "xtabItenPagamentoExecucao";
            this.xtabItenPagamentoExecucao.SelectedTabPage = this.xtbpItem;
            this.xtabItenPagamentoExecucao.Size = new System.Drawing.Size(1052, 546);
            this.xtabItenPagamentoExecucao.TabIndex = 106;
            this.xtabItenPagamentoExecucao.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbpItem,
            this.xtbpPagamento,
            this.xtbpExecucao});
            // 
            // xtbpItem
            // 
            this.xtbpItem.Controls.Add(this.txtBordado_Preco);
            this.xtbpItem.Controls.Add(this.txtBordado_Pontos);
            this.xtbpItem.Controls.Add(this.txtBordado_Descricao);
            this.xtbpItem.Controls.Add(this.txtTotal_Item);
            this.xtbpItem.Controls.Add(this.txtPC_Bordadas);
            this.xtbpItem.Controls.Add(this.nudBordado_Id);
            this.xtbpItem.Controls.Add(this.txtTot_a_pagar);
            this.xtbpItem.Controls.Add(this.txtPreco_Por_Peca);
            this.xtbpItem.Controls.Add(this.btnImportar);
            this.xtbpItem.Controls.Add(this.btnAdicionar);
            this.xtbpItem.Controls.Add(this.lblIgual);
            this.xtbpItem.Controls.Add(this.txtPC_Solicitadas);
            this.xtbpItem.Controls.Add(this.lblPeca_solicitadas);
            this.xtbpItem.Controls.Add(this.lblArquivo);
            this.xtbpItem.Controls.Add(this.lblValorApagar1);
            this.xtbpItem.Controls.Add(this.lblLado);
            this.xtbpItem.Controls.Add(this.dtpData_Entrega);
            this.xtbpItem.Controls.Add(this.btnBaixo);
            this.xtbpItem.Controls.Add(this.txtBordado_Arquivo);
            this.xtbpItem.Controls.Add(this.lblDiaSemana);
            this.xtbpItem.Controls.Add(this.lblPecasBordadas);
            this.xtbpItem.Controls.Add(this.picBordado);
            this.xtbpItem.Controls.Add(this.lblPrecoSugerido);
            this.xtbpItem.Controls.Add(this.rg_lado);
            this.xtbpItem.Controls.Add(this.lblDataEntrega);
            this.xtbpItem.Controls.Add(this.btnApagar);
            this.xtbpItem.Controls.Add(this.btnCima);
            this.xtbpItem.Controls.Add(this.lblDescricao1);
            this.xtbpItem.Controls.Add(this.txtObs_Item);
            this.xtbpItem.Controls.Add(this.lblBoradado_id);
            this.xtbpItem.Controls.Add(this.lblObs_item);
            this.xtbpItem.Controls.Add(this.btnInserirItem);
            this.xtbpItem.Controls.Add(this.lblDescricao);
            this.xtbpItem.Controls.Add(this.txtDescricao);
            this.xtbpItem.Controls.Add(this.lblPontos);
            this.xtbpItem.Controls.Add(this.lblLocal);
            this.xtbpItem.Controls.Add(this.rg_local);
            this.xtbpItem.Controls.Add(this.pnlItens);
            this.xtbpItem.Controls.Add(this.lblX);
            this.xtbpItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtbpItem.Name = "xtbpItem";
            this.xtbpItem.Size = new System.Drawing.Size(1045, 512);
            this.xtbpItem.Text = "Ítem";
            // 
            // txtBordado_Preco
            // 
            this.txtBordado_Preco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBordado_Preco.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtBordado_Preco.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBordado_Preco.FocusHighlightEnabled = true;
            this.txtBordado_Preco.Increment = 1D;
            this.txtBordado_Preco.Location = new System.Drawing.Point(739, 137);
            this.txtBordado_Preco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBordado_Preco.Name = "txtBordado_Preco";
            this.txtBordado_Preco.Size = new System.Drawing.Size(59, 23);
            this.txtBordado_Preco.TabIndex = 155;
            // 
            // txtBordado_Pontos
            // 
            this.txtBordado_Pontos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBordado_Pontos.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtBordado_Pontos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBordado_Pontos.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtBordado_Pontos.IsInputReadOnly = true;
            this.txtBordado_Pontos.Location = new System.Drawing.Point(734, 90);
            this.txtBordado_Pontos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBordado_Pontos.Name = "txtBordado_Pontos";
            this.txtBordado_Pontos.Size = new System.Drawing.Size(65, 23);
            this.txtBordado_Pontos.TabIndex = 154;
            // 
            // txtBordado_Descricao
            // 
            this.txtBordado_Descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Descricao.Location = new System.Drawing.Point(605, 250);
            this.txtBordado_Descricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBordado_Descricao.MenuManager = this.barManager1;
            this.txtBordado_Descricao.Name = "txtBordado_Descricao";
            this.txtBordado_Descricao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtBordado_Descricao.Size = new System.Drawing.Size(388, 22);
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
            this.txtTotal_Item.Location = new System.Drawing.Point(960, 403);
            this.txtTotal_Item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal_Item.Name = "txtTotal_Item";
            this.txtTotal_Item.Size = new System.Drawing.Size(79, 26);
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
            this.txtPC_Bordadas.Location = new System.Drawing.Point(960, 305);
            this.txtPC_Bordadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPC_Bordadas.Name = "txtPC_Bordadas";
            this.txtPC_Bordadas.Size = new System.Drawing.Size(79, 23);
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
            this.nudBordado_Id.Location = new System.Drawing.Point(734, 36);
            this.nudBordado_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudBordado_Id.Name = "nudBordado_Id";
            this.nudBordado_Id.Size = new System.Drawing.Size(65, 23);
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
            this.txtTot_a_pagar.Location = new System.Drawing.Point(513, 254);
            this.txtTot_a_pagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTot_a_pagar.Name = "txtTot_a_pagar";
            this.txtTot_a_pagar.Size = new System.Drawing.Size(82, 27);
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
            this.txtPreco_Por_Peca.Location = new System.Drawing.Point(960, 353);
            this.txtPreco_Por_Peca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreco_Por_Peca.Name = "txtPreco_Por_Peca";
            this.txtPreco_Por_Peca.Size = new System.Drawing.Size(79, 23);
            this.txtPreco_Por_Peca.TabIndex = 117;
            this.txtPreco_Por_Peca.ValueChanged += new System.EventHandler(this.txtPreco_Por_Peca_ValueChanged);
            this.txtPreco_Por_Peca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPreco_Por_Peca_KeyDown);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Location = new System.Drawing.Point(617, 343);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(159, 55);
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
            this.btnAdicionar.Location = new System.Drawing.Point(604, 4);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btnAdicionar.Size = new System.Drawing.Size(27, 28);
            this.btnAdicionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdicionar.TabIndex = 143;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblIgual
            // 
            this.lblIgual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIgual.BackColor = System.Drawing.Color.Transparent;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(1016, 378);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(21, 31);
            this.lblIgual.TabIndex = 139;
            this.lblIgual.Text = "=";
            this.lblIgual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtPC_Solicitadas.Location = new System.Drawing.Point(719, 305);
            this.txtPC_Solicitadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPC_Solicitadas.Name = "txtPC_Solicitadas";
            this.txtPC_Solicitadas.Size = new System.Drawing.Size(57, 23);
            this.txtPC_Solicitadas.TabIndex = 115;
            this.txtPC_Solicitadas.ValueChanged += new System.EventHandler(this.txtPC_Solicitadas_ValueChanged);
            this.txtPC_Solicitadas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPC_Solicitadas_KeyDown);
            // 
            // lblPeca_solicitadas
            // 
            this.lblPeca_solicitadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeca_solicitadas.BackColor = System.Drawing.Color.Transparent;
            this.lblPeca_solicitadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeca_solicitadas.Location = new System.Drawing.Point(590, 310);
            this.lblPeca_solicitadas.Name = "lblPeca_solicitadas";
            this.lblPeca_solicitadas.Size = new System.Drawing.Size(117, 16);
            this.lblPeca_solicitadas.TabIndex = 126;
            this.lblPeca_solicitadas.Text = "Peças Solicitadas:";
            this.lblPeca_solicitadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArquivo
            // 
            this.lblArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArquivo.BackColor = System.Drawing.Color.Transparent;
            this.lblArquivo.Location = new System.Drawing.Point(604, 179);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(56, 16);
            this.lblArquivo.TabIndex = 141;
            this.lblArquivo.Text = "Arquivo:";
            this.lblArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorApagar1
            // 
            this.lblValorApagar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorApagar1.BackColor = System.Drawing.Color.Transparent;
            this.lblValorApagar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorApagar1.Location = new System.Drawing.Point(384, 257);
            this.lblValorApagar1.Name = "lblValorApagar1";
            this.lblValorApagar1.Size = new System.Drawing.Size(121, 17);
            this.lblValorApagar1.TabIndex = 127;
            this.lblValorApagar1.Text = "Valor a Pagar:";
            this.lblValorApagar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLado
            // 
            this.lblLado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLado.BackColor = System.Drawing.Color.Transparent;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(401, 334);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(57, 17);
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
            this.dtpData_Entrega.Location = new System.Drawing.Point(863, 470);
            this.dtpData_Entrega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.dtpData_Entrega.Size = new System.Drawing.Size(174, 23);
            this.dtpData_Entrega.TabIndex = 122;
            this.dtpData_Entrega.TextChanged += new System.EventHandler(this.dtpData_Entrega_TextChanged);
            // 
            // btnBaixo
            // 
            this.btnBaixo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaixo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBaixo.Image = ((System.Drawing.Image)(resources.GetObject("btnBaixo.Image")));
            this.btnBaixo.Location = new System.Drawing.Point(605, 143);
            this.btnBaixo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDown);
            this.btnBaixo.Size = new System.Drawing.Size(27, 28);
            this.btnBaixo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBaixo.TabIndex = 147;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // txtBordado_Arquivo
            // 
            this.txtBordado_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Arquivo.Location = new System.Drawing.Point(604, 199);
            this.txtBordado_Arquivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBordado_Arquivo.Name = "txtBordado_Arquivo";
            this.txtBordado_Arquivo.Size = new System.Drawing.Size(195, 23);
            this.txtBordado_Arquivo.TabIndex = 117;
            this.txtBordado_Arquivo.TabStop = false;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiaSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.Location = new System.Drawing.Point(859, 445);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(140, 21);
            this.lblDiaSemana.TabIndex = 134;
            this.lblDiaSemana.Text = "...";
            this.lblDiaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPecasBordadas
            // 
            this.lblPecasBordadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPecasBordadas.BackColor = System.Drawing.Color.Transparent;
            this.lblPecasBordadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecasBordadas.Location = new System.Drawing.Point(838, 307);
            this.lblPecasBordadas.Name = "lblPecasBordadas";
            this.lblPecasBordadas.Size = new System.Drawing.Size(122, 20);
            this.lblPecasBordadas.TabIndex = 135;
            this.lblPecasBordadas.Text = "Peças Bordadas:";
            this.lblPecasBordadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picBordado
            // 
            this.picBordado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBordado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.picBordado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBordado.Location = new System.Drawing.Point(807, 2);
            this.picBordado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBordado.Name = "picBordado";
            this.picBordado.Size = new System.Drawing.Size(233, 246);
            this.picBordado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBordado.TabIndex = 123;
            this.picBordado.TabStop = false;
            // 
            // lblPrecoSugerido
            // 
            this.lblPrecoSugerido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecoSugerido.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoSugerido.Location = new System.Drawing.Point(624, 144);
            this.lblPrecoSugerido.Name = "lblPrecoSugerido";
            this.lblPrecoSugerido.Size = new System.Drawing.Size(110, 16);
            this.lblPrecoSugerido.TabIndex = 130;
            this.lblPrecoSugerido.Text = "Preço Sugerido:";
            this.lblPrecoSugerido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rg_lado
            // 
            this.rg_lado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rg_lado.Location = new System.Drawing.Point(465, 323);
            this.rg_lado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rg_lado.Name = "rg_lado";
            this.rg_lado.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Esquerdo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Direito")});
            this.rg_lado.Size = new System.Drawing.Size(139, 75);
            this.rg_lado.TabIndex = 149;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDataEntrega.Location = new System.Drawing.Point(746, 479);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(110, 16);
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
            this.btnApagar.Location = new System.Drawing.Point(604, 39);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDel);
            this.btnApagar.Size = new System.Drawing.Size(27, 28);
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
            this.btnCima.Location = new System.Drawing.Point(604, 75);
            this.btnCima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCima.Name = "btnCima";
            this.btnCima.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlUp);
            this.btnCima.Size = new System.Drawing.Size(27, 28);
            this.btnCima.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCima.TabIndex = 145;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // lblDescricao1
            // 
            this.lblDescricao1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao1.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao1.Location = new System.Drawing.Point(601, 228);
            this.lblDescricao1.Name = "lblDescricao1";
            this.lblDescricao1.Size = new System.Drawing.Size(87, 23);
            this.lblDescricao1.TabIndex = 142;
            this.lblDescricao1.Text = "Descrição:";
            this.lblDescricao1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtObs_Item
            // 
            this.txtObs_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObs_Item.Location = new System.Drawing.Point(84, 417);
            this.txtObs_Item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObs_Item.Multiline = true;
            this.txtObs_Item.Name = "txtObs_Item";
            this.txtObs_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs_Item.Size = new System.Drawing.Size(308, 84);
            this.txtObs_Item.TabIndex = 121;
            this.txtObs_Item.TabStop = false;
            // 
            // lblBoradado_id
            // 
            this.lblBoradado_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBoradado_id.BackColor = System.Drawing.Color.Transparent;
            this.lblBoradado_id.Location = new System.Drawing.Point(638, 37);
            this.lblBoradado_id.Name = "lblBoradado_id";
            this.lblBoradado_id.Size = new System.Drawing.Size(92, 22);
            this.lblBoradado_id.TabIndex = 140;
            this.lblBoradado_id.Text = "Bordado_Id:";
            this.lblBoradado_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObs_item
            // 
            this.lblObs_item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblObs_item.BackColor = System.Drawing.Color.Transparent;
            this.lblObs_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblObs_item.Location = new System.Drawing.Point(30, 420);
            this.lblObs_item.Name = "lblObs_item";
            this.lblObs_item.Size = new System.Drawing.Size(48, 20);
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
            this.btnInserirItem.Location = new System.Drawing.Point(605, 111);
            this.btnInserirItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlIns);
            this.btnInserirItem.Size = new System.Drawing.Size(27, 28);
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
            this.lblDescricao.Location = new System.Drawing.Point(-3, 289);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 22);
            this.lblDescricao.TabIndex = 132;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescricao.Location = new System.Drawing.Point(84, 290);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(520, 23);
            this.txtDescricao.TabIndex = 120;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // lblPontos
            // 
            this.lblPontos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblPontos.Location = new System.Drawing.Point(666, 90);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(69, 25);
            this.lblPontos.TabIndex = 124;
            this.lblPontos.Text = "Pontos:";
            this.lblPontos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(20, 332);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(57, 17);
            this.lblLocal.TabIndex = 128;
            this.lblLocal.Text = "Local:";
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rg_local
            // 
            this.rg_local.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rg_local.Location = new System.Drawing.Point(84, 326);
            this.rg_local.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rg_local.Name = "rg_local";
            this.rg_local.Size = new System.Drawing.Size(309, 73);
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
            this.pnlItens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlItens.Name = "pnlItens";
            this.pnlItens.Size = new System.Drawing.Size(597, 248);
            this.pnlItens.TabIndex = 0;
            // 
            // dgItens
            // 
            this.dgItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItens.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            gridLevelNode2.RelationName = "Level1";
            this.dgItens.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.dgItens.Location = new System.Drawing.Point(2, 2);
            this.dgItens.MainView = this.gvItens;
            this.dgItens.Margin = new System.Windows.Forms.Padding(2);
            this.dgItens.Name = "dgItens";
            this.dgItens.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorPickEdit3});
            this.dgItens.Size = new System.Drawing.Size(592, 206);
            this.dgItens.TabIndex = 101;
            this.dgItens.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItens});
            // 
            // gvItens
            // 
            this.gvItens.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvItens.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvItens.Appearance.EvenRow.Options.UseFont = true;
            this.gvItens.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.gvItens.Appearance.FocusedRow.Options.UseFont = true;
            this.gvItens.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvItens.Appearance.GroupFooter.Options.UseFont = true;
            this.gvItens.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvItens.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 7F);
            this.gvItens.Appearance.OddRow.Options.UseFont = true;
            this.gvItens.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvItens.Appearance.Row.Options.UseFont = true;
            this.gvItens.Appearance.Row.Options.UseTextOptions = true;
            this.gvItens.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvItens.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItem,
            this.colDescricao,
            this.colData_entrega,
            this.colPc_solicitadas,
            this.colPreco,
            this.colTotal,
            this.colData_execucao,
            this.colPc_entregues,
            this.colPc_defeito,
            this.colPc_nao_bordadas,
            this.colPonto_extras,
            this.colMaterial_id,
            this.colLolal_id,
            this.colLocal,
            this.colArte,
            this.colAplicacao,
            this.colBordado,
            this.colCores,
            this.colTroca_rapida,
            this.colObs,
            this.colBordado_id});
            this.gvItens.FixedLineWidth = 1;
            this.gvItens.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvItens.FooterPanelHeight = 10;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "Sim";
            formatConditionRuleValue1.PredefinedName = "Red Fill, Red Text";
            formatConditionRuleValue1.Value1 = "Sim";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gvItens.FormatRules.Add(gridFormatRule1);
            this.gvItens.GridControl = this.dgItens;
            this.gvItens.GroupFormat = "{0}: [#imagem]{1} {2}";
            this.gvItens.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvItens.Name = "gvItens";
            this.gvItens.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvItens.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvItens.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvItens.OptionsBehavior.AutoPopulateColumns = false;
            this.gvItens.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvItens.OptionsBehavior.Editable = false;
            this.gvItens.OptionsBehavior.ReadOnly = true;
            this.gvItens.OptionsCustomization.AllowColumnMoving = false;
            this.gvItens.OptionsCustomization.AllowColumnResizing = false;
            this.gvItens.OptionsCustomization.AllowFilter = false;
            this.gvItens.OptionsCustomization.AllowGroup = false;
            this.gvItens.OptionsCustomization.AllowSort = false;
            this.gvItens.OptionsDetail.SmartDetailHeight = true;
            this.gvItens.OptionsMenu.EnableColumnMenu = false;
            this.gvItens.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvItens.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvItens.OptionsSelection.MultiSelect = true;
            this.gvItens.OptionsSelection.UseIndicatorForSelection = false;
            this.gvItens.OptionsView.ColumnAutoWidth = false;
            this.gvItens.OptionsView.ShowGroupPanel = false;
            this.gvItens.RowHeight = 18;
            this.gvItens.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvItens_FocusedRowChanged);
            // 
            // colItem
            // 
            this.colItem.Caption = "Ítem";
            this.colItem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colItem.FieldName = "item";
            this.colItem.Name = "colItem";
            this.colItem.OptionsColumn.FixedWidth = true;
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 0;
            this.colItem.Width = 32;
            // 
            // colDescricao
            // 
            this.colDescricao.Caption = "descrição";
            this.colDescricao.FieldName = "descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 1;
            this.colDescricao.Width = 375;
            // 
            // colData_entrega
            // 
            this.colData_entrega.Caption = "data entrega";
            this.colData_entrega.FieldName = "data_entrega";
            this.colData_entrega.Name = "colData_entrega";
            this.colData_entrega.OptionsColumn.FixedWidth = true;
            this.colData_entrega.Visible = true;
            this.colData_entrega.VisibleIndex = 2;
            this.colData_entrega.Width = 74;
            // 
            // colPc_solicitadas
            // 
            this.colPc_solicitadas.AppearanceCell.Options.UseTextOptions = true;
            this.colPc_solicitadas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPc_solicitadas.AppearanceHeader.Options.UseTextOptions = true;
            this.colPc_solicitadas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPc_solicitadas.Caption = "qtde";
            this.colPc_solicitadas.FieldName = "pc_solicitadas";
            this.colPc_solicitadas.Name = "colPc_solicitadas";
            this.colPc_solicitadas.OptionsColumn.FixedWidth = true;
            this.colPc_solicitadas.Visible = true;
            this.colPc_solicitadas.VisibleIndex = 3;
            this.colPc_solicitadas.Width = 54;
            // 
            // colPreco
            // 
            this.colPreco.AppearanceCell.Options.UseTextOptions = true;
            this.colPreco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPreco.AppearanceHeader.Options.UseTextOptions = true;
            this.colPreco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPreco.Caption = "preco";
            this.colPreco.FieldName = "preco_por_peca";
            this.colPreco.Name = "colPreco";
            this.colPreco.OptionsColumn.FixedWidth = true;
            this.colPreco.Visible = true;
            this.colPreco.VisibleIndex = 4;
            this.colPreco.Width = 59;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Tot.ítem";
            this.colTotal.FieldName = "total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.FixedWidth = true;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            // 
            // colData_execucao
            // 
            this.colData_execucao.Caption = "gridColumn1";
            this.colData_execucao.Name = "colData_execucao";
            this.colData_execucao.OptionsColumn.FixedWidth = true;
            // 
            // colPc_entregues
            // 
            this.colPc_entregues.Caption = "gridColumn2";
            this.colPc_entregues.Name = "colPc_entregues";
            this.colPc_entregues.OptionsColumn.FixedWidth = true;
            // 
            // colPc_defeito
            // 
            this.colPc_defeito.Caption = "gridColumn3";
            this.colPc_defeito.Name = "colPc_defeito";
            this.colPc_defeito.OptionsColumn.FixedWidth = true;
            // 
            // colPc_nao_bordadas
            // 
            this.colPc_nao_bordadas.Caption = "gridColumn4";
            this.colPc_nao_bordadas.Name = "colPc_nao_bordadas";
            this.colPc_nao_bordadas.OptionsColumn.FixedWidth = true;
            // 
            // colPonto_extras
            // 
            this.colPonto_extras.Caption = "gridColumn1";
            this.colPonto_extras.Name = "colPonto_extras";
            this.colPonto_extras.OptionsColumn.FixedWidth = true;
            // 
            // colMaterial_id
            // 
            this.colMaterial_id.Caption = "gridColumn2";
            this.colMaterial_id.Name = "colMaterial_id";
            this.colMaterial_id.OptionsColumn.FixedWidth = true;
            // 
            // colLolal_id
            // 
            this.colLolal_id.Caption = "gridColumn3";
            this.colLolal_id.Name = "colLolal_id";
            this.colLolal_id.OptionsColumn.FixedWidth = true;
            // 
            // colLocal
            // 
            this.colLocal.Caption = "gridColumn1";
            this.colLocal.Name = "colLocal";
            this.colLocal.OptionsColumn.FixedWidth = true;
            // 
            // colArte
            // 
            this.colArte.Caption = "gridColumn2";
            this.colArte.Name = "colArte";
            this.colArte.OptionsColumn.FixedWidth = true;
            // 
            // colAplicacao
            // 
            this.colAplicacao.Caption = "gridColumn3";
            this.colAplicacao.Name = "colAplicacao";
            this.colAplicacao.OptionsColumn.FixedWidth = true;
            // 
            // colBordado
            // 
            this.colBordado.Caption = "gridColumn4";
            this.colBordado.Name = "colBordado";
            this.colBordado.OptionsColumn.FixedWidth = true;
            // 
            // colCores
            // 
            this.colCores.Caption = "gridColumn5";
            this.colCores.Name = "colCores";
            this.colCores.OptionsColumn.FixedWidth = true;
            // 
            // colTroca_rapida
            // 
            this.colTroca_rapida.Caption = "gridColumn6";
            this.colTroca_rapida.Name = "colTroca_rapida";
            this.colTroca_rapida.OptionsColumn.FixedWidth = true;
            // 
            // colObs
            // 
            this.colObs.Caption = "gridColumn1";
            this.colObs.Name = "colObs";
            this.colObs.OptionsColumn.FixedWidth = true;
            // 
            // colBordado_id
            // 
            this.colBordado_id.Caption = "gridColumn1";
            this.colBordado_id.Name = "colBordado_id";
            this.colBordado_id.OptionsColumn.FixedWidth = true;
            // 
            // repositoryItemColorPickEdit3
            // 
            this.repositoryItemColorPickEdit3.AutoHeight = false;
            this.repositoryItemColorPickEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit3.Name = "repositoryItemColorPickEdit3";
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.BackColor = System.Drawing.Color.Transparent;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(1003, 326);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(34, 31);
            this.lblX.TabIndex = 138;
            this.lblX.Text = "x";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xtbpPagamento
            // 
            this.xtbpPagamento.Controls.Add(this.dePagamento);
            this.xtbpPagamento.Controls.Add(this.lblDataPagamento);
            this.xtbpPagamento.Controls.Add(this.Saldo);
            this.xtbpPagamento.Controls.Add(this.lblAdicional);
            this.xtbpPagamento.Controls.Add(this.Total_Pagamento2);
            this.xtbpPagamento.Controls.Add(this.txtObs_Pagamento);
            this.xtbpPagamento.Controls.Add(this.Pago);
            this.xtbpPagamento.Controls.Add(this.lblValorAPagar);
            this.xtbpPagamento.Controls.Add(this.Adicional);
            this.xtbpPagamento.Controls.Add(this.lblObs);
            this.xtbpPagamento.Controls.Add(this.lblValoraAmortizar);
            this.xtbpPagamento.Controls.Add(this.lblTotalDoPedido);
            this.xtbpPagamento.Controls.Add(this.ValorAmortizar);
            this.xtbpPagamento.Controls.Add(this.lblSaldoaPagar);
            this.xtbpPagamento.Controls.Add(this.btnAmortizar);
            this.xtbpPagamento.Controls.Add(this.cbQuitado);
            this.xtbpPagamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtbpPagamento.Name = "xtbpPagamento";
            this.xtbpPagamento.Size = new System.Drawing.Size(832, 587);
            this.xtbpPagamento.Text = "Pagamento";
            // 
            // xtbpExecucao
            // 
            this.xtbpExecucao.Controls.Add(this.txtPC_Entregues);
            this.xtbpExecucao.Controls.Add(this.dgLinhas_Item);
            this.xtbpExecucao.Controls.Add(this.lblPc_Entregues);
            this.xtbpExecucao.Controls.Add(this.lblExecucao);
            this.xtbpExecucao.Controls.Add(this.txtTotal_Pontos);
            this.xtbpExecucao.Controls.Add(this.dtpData_Execucao);
            this.xtbpExecucao.Controls.Add(this.lblTotalPontos);
            this.xtbpExecucao.Controls.Add(this.btnExecutarItem);
            this.xtbpExecucao.Controls.Add(this.txtPontos_Extras);
            this.xtbpExecucao.Controls.Add(this.btnApagaLinha);
            this.xtbpExecucao.Controls.Add(this.lblPontosExtras);
            this.xtbpExecucao.Controls.Add(this.btnInsereLinha);
            this.xtbpExecucao.Controls.Add(this.lblDefeito);
            this.xtbpExecucao.Controls.Add(this.btnGravaLinhas);
            this.xtbpExecucao.Controls.Add(this.lblNaoBordadas);
            this.xtbpExecucao.Controls.Add(this.btnRestaura);
            this.xtbpExecucao.Controls.Add(this.txtPC_Defeito);
            this.xtbpExecucao.Controls.Add(this.txtPC_Nao_Bordadas);
            this.xtbpExecucao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtbpExecucao.Name = "xtbpExecucao";
            this.xtbpExecucao.Size = new System.Drawing.Size(832, 587);
            this.xtbpExecucao.Text = "Execução";
            // 
            // dgRegistros
            // 
            this.dgRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRegistros.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.RelationName = "Level1";
            this.dgRegistros.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgRegistros.Location = new System.Drawing.Point(-2, 116);
            this.dgRegistros.MainView = this.gvRegistros;
            this.dgRegistros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.Size = new System.Drawing.Size(301, 524);
            this.dgRegistros.TabIndex = 59;
            this.dgRegistros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRegistros});
            // 
            // gvRegistros
            // 
            this.gvRegistros.DetailHeight = 100;
            this.gvRegistros.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvRegistros.GridControl = this.dgRegistros;
            this.gvRegistros.Name = "gvRegistros";
            this.gvRegistros.OptionsBehavior.Editable = false;
            this.gvRegistros.OptionsBehavior.SmartVertScrollBar = false;
            this.gvRegistros.OptionsCustomization.AllowColumnMoving = false;
            this.gvRegistros.OptionsCustomization.AllowColumnResizing = false;
            this.gvRegistros.OptionsCustomization.AllowFilter = false;
            this.gvRegistros.OptionsCustomization.AllowGroup = false;
            this.gvRegistros.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvRegistros.OptionsCustomization.AllowSort = false;
            this.gvRegistros.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gvRegistros.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvRegistros.OptionsFilter.AllowFilterEditor = false;
            this.gvRegistros.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gvRegistros.OptionsFilter.AllowMRUFilterList = false;
            this.gvRegistros.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gvRegistros.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.gvRegistros.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvRegistros.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvRegistros.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvRegistros.OptionsView.AllowHtmlDrawGroups = false;
            this.gvRegistros.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvRegistros.OptionsView.ShowGroupPanel = false;
            this.gvRegistros.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvRegistros_FocusedRowChanged);
            this.gvRegistros.DoubleClick += new System.EventHandler(this.gvRegistros_DoubleClick);
            // 
            // chkFiltroDemais
            // 
            this.chkFiltroDemais.AutoSize = true;
            this.chkFiltroDemais.Checked = true;
            this.chkFiltroDemais.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroDemais.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroDemais.Location = new System.Drawing.Point(236, 90);
            this.chkFiltroDemais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroDemais.Name = "chkFiltroDemais";
            this.chkFiltroDemais.Size = new System.Drawing.Size(67, 18);
            this.chkFiltroDemais.TabIndex = 104;
            this.chkFiltroDemais.Text = "Demais";
            this.chkFiltroDemais.UseVisualStyleBackColor = true;
            this.chkFiltroDemais.CheckedChanged += new System.EventHandler(this.chkFiltroDemais_CheckedChanged);
            // 
            // chkFiltroMensal
            // 
            this.chkFiltroMensal.AutoSize = true;
            this.chkFiltroMensal.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroMensal.Location = new System.Drawing.Point(236, 70);
            this.chkFiltroMensal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroMensal.Name = "chkFiltroMensal";
            this.chkFiltroMensal.Size = new System.Drawing.Size(65, 18);
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
            this.chkFiltroNaoExecutado.Location = new System.Drawing.Point(104, 92);
            this.chkFiltroNaoExecutado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroNaoExecutado.Name = "chkFiltroNaoExecutado";
            this.chkFiltroNaoExecutado.Size = new System.Drawing.Size(112, 18);
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
            this.chkFiltroNaoQuitado.Location = new System.Drawing.Point(7, 90);
            this.chkFiltroNaoQuitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroNaoQuitado.Name = "chkFiltroNaoQuitado";
            this.chkFiltroNaoQuitado.Size = new System.Drawing.Size(81, 18);
            this.chkFiltroNaoQuitado.TabIndex = 101;
            this.chkFiltroNaoQuitado.Text = "Não Pago";
            this.chkFiltroNaoQuitado.UseVisualStyleBackColor = true;
            this.chkFiltroNaoQuitado.CheckedChanged += new System.EventHandler(this.chkFiltroNaoQuitado_CheckedChanged);
            // 
            // chkFiltroExecutado
            // 
            this.chkFiltroExecutado.AutoSize = true;
            this.chkFiltroExecutado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroExecutado.Location = new System.Drawing.Point(104, 73);
            this.chkFiltroExecutado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroExecutado.Name = "chkFiltroExecutado";
            this.chkFiltroExecutado.Size = new System.Drawing.Size(87, 18);
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
            this.chkFiltroQuitado.Location = new System.Drawing.Point(7, 70);
            this.chkFiltroQuitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroQuitado.Name = "chkFiltroQuitado";
            this.chkFiltroQuitado.Size = new System.Drawing.Size(56, 18);
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
            this.cbFiltroCliente.Location = new System.Drawing.Point(62, 37);
            this.cbFiltroCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFiltroCliente.Name = "cbFiltroCliente";
            this.cbFiltroCliente.Size = new System.Drawing.Size(237, 24);
            this.cbFiltroCliente.TabIndex = 98;
            this.cbFiltroCliente.SelectedIndexChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkFiltroCliente
            // 
            this.chkFiltroCliente.AutoSize = true;
            this.chkFiltroCliente.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroCliente.Location = new System.Drawing.Point(2, 41);
            this.chkFiltroCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroCliente.Name = "chkFiltroCliente";
            this.chkFiltroCliente.Size = new System.Drawing.Size(66, 18);
            this.chkFiltroCliente.TabIndex = 105;
            this.chkFiltroCliente.Text = "Cliente";
            this.chkFiltroCliente.UseVisualStyleBackColor = true;
            this.chkFiltroCliente.CheckedChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // ckbPAGO
            // 
            this.ckbPAGO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ckbPAGO.Location = new System.Drawing.Point(414, 64);
            this.ckbPAGO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbPAGO.Name = "ckbPAGO";
            this.ckbPAGO.Size = new System.Drawing.Size(111, 41);
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
            this.lblTelefone.Location = new System.Drawing.Point(262, 34);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(25, 21);
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
            this.pnlFitro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFitro.Name = "pnlFitro";
            this.pnlFitro.Size = new System.Drawing.Size(300, 645);
            this.pnlFitro.TabIndex = 106;
            // 
            // btnQuitar
            // 
            this.btnQuitar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnQuitar.Location = new System.Drawing.Point(258, 62);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar.MenuManager = this.barManager1;
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(145, 46);
            this.btnQuitar.TabIndex = 217;
            this.btnQuitar.Text = "Baixar o Pedido";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CimaToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 50);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1388, 28);
            this.MenuStrip1.TabIndex = 94;
            this.MenuStrip1.Text = "MenuStrip1";
            this.MenuStrip1.Visible = false;
            // 
            // CimaToolStripMenuItem
            // 
            this.CimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdicionarToolStripMenuItem,
            this.ExcluirToolStripMenuItem,
            this.MaisNomeToolStripMenuItem,
            this.MaisFuncaoToolStripMenuItem,
            this.MaisNomeFuncaoToolStripMenuItem,
            this.MaisNomeMesmaTelaToolStripMenuItem,
            this.GravarToolStripMenuItem});
            this.CimaToolStripMenuItem.Name = "CimaToolStripMenuItem";
            this.CimaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.CimaToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.CimaToolStripMenuItem.Text = "Atalhos";
            this.CimaToolStripMenuItem.Visible = false;
            // 
            // AdicionarToolStripMenuItem
            // 
            this.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem";
            this.AdicionarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.AdicionarToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.AdicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // ExcluirToolStripMenuItem
            // 
            this.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem";
            this.ExcluirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.ExcluirToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.ExcluirToolStripMenuItem.Text = "Excluir";
            // 
            // MaisNomeToolStripMenuItem
            // 
            this.MaisNomeToolStripMenuItem.Name = "MaisNomeToolStripMenuItem";
            this.MaisNomeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.MaisNomeToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.MaisNomeToolStripMenuItem.Text = "Mais_Nome";
            this.MaisNomeToolStripMenuItem.Click += new System.EventHandler(this.MaisNomeToolStripMenuItem_Click);
            // 
            // MaisFuncaoToolStripMenuItem
            // 
            this.MaisFuncaoToolStripMenuItem.Name = "MaisFuncaoToolStripMenuItem";
            this.MaisFuncaoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.MaisFuncaoToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.MaisFuncaoToolStripMenuItem.Text = "Mais_Funcao";
            this.MaisFuncaoToolStripMenuItem.Click += new System.EventHandler(this.MaisFuncaoToolStripMenuItem_Click);
            // 
            // MaisNomeFuncaoToolStripMenuItem
            // 
            this.MaisNomeFuncaoToolStripMenuItem.Name = "MaisNomeFuncaoToolStripMenuItem";
            this.MaisNomeFuncaoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MaisNomeFuncaoToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.MaisNomeFuncaoToolStripMenuItem.Text = "Mais_Nome_Funcao";
            this.MaisNomeFuncaoToolStripMenuItem.Click += new System.EventHandler(this.MaisNomeFuncaoToolStripMenuItem_Click);
            // 
            // MaisNomeMesmaTelaToolStripMenuItem
            // 
            this.MaisNomeMesmaTelaToolStripMenuItem.Name = "MaisNomeMesmaTelaToolStripMenuItem";
            this.MaisNomeMesmaTelaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.MaisNomeMesmaTelaToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.MaisNomeMesmaTelaToolStripMenuItem.Text = "Mais_Nome_Mesma_Tela";
            // 
            // GravarToolStripMenuItem
            // 
            this.GravarToolStripMenuItem.Name = "GravarToolStripMenuItem";
            this.GravarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.GravarToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.GravarToolStripMenuItem.Text = "Gravar";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1360, 699);
            this.Controls.Add(this.MenuStrip1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmPedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.Controls.SetChildIndex(this.scc1, 0);
            this.Controls.SetChildIndex(this.MenuStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).EndInit();
            this.scc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechamento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAbertura.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAbertura.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtBordado_Preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBordado_Pontos)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit3)).EndInit();
            this.xtbpPagamento.ResumeLayout(false);
            this.xtbpPagamento.PerformLayout();
            this.xtbpExecucao.ResumeLayout(false);
            this.xtbpExecucao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFitro)).EndInit();
            this.pnlFitro.ResumeLayout(false);
            this.pnlFitro.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
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
        internal System.Windows.Forms.Label lblEmpregado;
        internal System.Windows.Forms.TextBox txtObs_Pedido;
        internal System.Windows.Forms.Panel pnTotais;
        private DevComponents.Editors.DoubleInput txtDesconto;
        internal System.Windows.Forms.Label lblDesconto;
        internal System.Windows.Forms.TextBox txtQtde_Itens;
        private DevComponents.DotNetBar.TabControlPanel TabControlPanel3;
        internal DevComponents.Editors.IntegerInput txtPC_Entregues;
        internal System.Windows.Forms.Label lblPc_Entregues;
        internal System.Windows.Forms.TextBox txtTotal_Pontos;
        internal System.Windows.Forms.Label lblTotalPontos;
        internal System.Windows.Forms.TextBox txtPontos_Extras;
        internal System.Windows.Forms.Label lblPontosExtras;
        internal System.Windows.Forms.Label lblDefeito;
        internal System.Windows.Forms.Label lblNaoBordadas;
        internal System.Windows.Forms.TextBox txtPC_Defeito;
        internal System.Windows.Forms.TextBox txtPC_Nao_Bordadas;
        private DevComponents.DotNetBar.ButtonX btnRestaura;
        private DevComponents.DotNetBar.ButtonX btnGravaLinhas;
        private DevComponents.DotNetBar.ButtonX btnInsereLinha;
        private DevComponents.DotNetBar.ButtonX btnApagaLinha;
        private DevComponents.DotNetBar.ButtonX btnExecutarItem;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpData_Execucao;
        internal System.Windows.Forms.Label lblExecucao;
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
        internal System.Windows.Forms.Label lblValoraAmortizar;
        private DevComponents.Editors.DoubleInput ValorAmortizar;
        private DevComponents.DotNetBar.ButtonX btnAmortizar;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbQuitado;
        internal System.Windows.Forms.Label lblSaldoaPagar;
        internal System.Windows.Forms.Label lblTotalDoPedido;
        internal System.Windows.Forms.Label lblObs;
        internal System.Windows.Forms.Label lblValorAPagar;
        internal System.Windows.Forms.Label lblDataPagamento;
        internal System.Windows.Forms.TextBox txtObs_Pagamento;
        internal System.Windows.Forms.Label lblAdicional;
        internal System.Windows.Forms.Label LinhaIdLabel;
        internal System.Windows.Forms.Label lblAbertura;
        public System.Windows.Forms.ComboBox cbCliente;
        internal System.Windows.Forms.Label lblFechamento;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label lblObs1;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gvRegistros;
        private DevComponents.Editors.DoubleInput txtPreco_Por_Peca;
        internal System.Windows.Forms.Button btnImportar;
        internal DevComponents.DotNetBar.ButtonX btnAdicionar;
        internal System.Windows.Forms.Label lblIgual;
        internal DevComponents.Editors.IntegerInput txtPC_Solicitadas;
        internal System.Windows.Forms.Label lblPeca_solicitadas;
        internal System.Windows.Forms.Label lblArquivo;
        internal System.Windows.Forms.Label lblLado;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpData_Entrega;
        internal DevComponents.DotNetBar.ButtonX btnBaixo;
        internal System.Windows.Forms.Label lblX;
        internal System.Windows.Forms.TextBox txtBordado_Arquivo;
        internal System.Windows.Forms.Label lblDiaSemana;
        internal System.Windows.Forms.Label lblPecasBordadas;
        public System.Windows.Forms.PictureBox picBordado;
        internal System.Windows.Forms.Label lblPrecoSugerido;
        internal DevExpress.XtraEditors.RadioGroup rg_lado;
        internal System.Windows.Forms.Label lblDataEntrega;
        internal DevComponents.DotNetBar.ButtonX btnApagar;
        internal DevComponents.DotNetBar.ButtonX btnCima;
        internal System.Windows.Forms.Label lblDescricao1;
        internal System.Windows.Forms.TextBox txtObs_Item;
        internal System.Windows.Forms.Label lblBoradado_id;
        internal System.Windows.Forms.Label lblObs_item;
        internal DevComponents.DotNetBar.ButtonX btnInserirItem;
        internal System.Windows.Forms.Label lblDescricao;
        internal System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.Label lblPontos;
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
        internal System.Windows.Forms.Label lblAmortizacao;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private StringReader leitor;
        private DevExpress.XtraBars.BarButtonItem tnImprimirCupom;
        internal System.Windows.Forms.Label lblTelefone;
        private DevExpress.XtraBars.BarButtonItem btnProtocolo;
        private DevComponents.Editors.DoubleInput txtTot_a_pagar;
        internal System.Windows.Forms.Label lblValorApagar1;
        private DevComponents.Editors.DoubleInput txtTotal_Pedido;
        private DevComponents.Editors.IntegerInput txtTot_Pecas;
        private DevComponents.Editors.IntegerInput nudBordado_Id;
        private DevExpress.XtraEditors.PanelControl pnlFitro;
        private DevExpress.XtraEditors.DropDownButton btnQuitar;
        internal DevComponents.Editors.IntegerInput txtPC_Bordadas;
        private DevComponents.Editors.DoubleInput txtTotal_Item;
        private DevExpress.XtraEditors.TextEdit txtBordado_Descricao;
        private DevComponents.Editors.DoubleInput txtBordado_Preco;
        private DevComponents.Editors.IntegerInput txtBordado_Pontos;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem CimaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AdicionarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExcluirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MaisNomeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MaisFuncaoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MaisNomeFuncaoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MaisNomeMesmaTelaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GravarToolStripMenuItem;
        internal DevExpress.XtraGrid.GridControl dgItens;
        internal DevExpress.XtraGrid.Views.Grid.GridView gvItens;
        internal DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colData_entrega;
        private DevExpress.XtraGrid.Columns.GridColumn colPreco;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colData_execucao;
        private DevExpress.XtraGrid.Columns.GridColumn colPc_solicitadas;
        private DevExpress.XtraGrid.Columns.GridColumn colPc_entregues;
        private DevExpress.XtraGrid.Columns.GridColumn colPc_defeito;
        private DevExpress.XtraGrid.Columns.GridColumn colPc_nao_bordadas;
        private DevExpress.XtraGrid.Columns.GridColumn colPonto_extras;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial_id;
        private DevExpress.XtraGrid.Columns.GridColumn colLolal_id;
        private DevExpress.XtraGrid.Columns.GridColumn colLocal;
        private DevExpress.XtraGrid.Columns.GridColumn colArte;
        private DevExpress.XtraGrid.Columns.GridColumn colAplicacao;
        private DevExpress.XtraGrid.Columns.GridColumn colBordado;
        private DevExpress.XtraGrid.Columns.GridColumn colCores;
        private DevExpress.XtraGrid.Columns.GridColumn colTroca_rapida;
        private DevExpress.XtraGrid.Columns.GridColumn colObs;
        private DevExpress.XtraGrid.Columns.GridColumn colBordado_id;
    }
}
