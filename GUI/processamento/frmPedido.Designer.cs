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
            this.cbMensal = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbExecutado = new DevComponents.DotNetBar.Controls.CheckBoxX();
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
            this.nudBordado_Id = new DevComponents.Editors.IntegerInput();
            this.txtTot_a_pagar = new DevComponents.Editors.DoubleInput();
            this.txtPreco_Por_Peca = new DevComponents.Editors.DoubleInput();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAdicionar = new DevComponents.DotNetBar.ButtonX();
            this.Label20 = new System.Windows.Forms.Label();
            this.txtPC_Solicitadas = new DevComponents.Editors.IntegerInput();
            this.txtTotal_Item = new System.Windows.Forms.TextBox();
            this.lblPeca_solicitadas = new System.Windows.Forms.Label();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.txtPC_Bordadas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.dtpData_Entrega = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnBaixo = new DevComponents.DotNetBar.ButtonX();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtBordado_Arquivo = new System.Windows.Forms.TextBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.picBordado = new System.Windows.Forms.PictureBox();
            this.txtBordado_Descricao = new System.Windows.Forms.TextBox();
            this.btnAgenda = new DevComponents.DotNetBar.ButtonX();
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
            this.btnQuitar = new DevExpress.XtraEditors.CheckButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tnImprimirCupom = new DevExpress.XtraBars.BarButtonItem();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnProtocolo = new DevExpress.XtraBars.BarButtonItem();
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
            this.scc1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.scc1.Location = new System.Drawing.Point(0, 50);
            this.scc1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.scc1.Panel1.Controls.Add(this.cbFiltroCliente);
            this.scc1.Panel1.Controls.Add(this.chkFiltroCliente);
            this.scc1.Panel1.Controls.Add(this.chkFiltroDemais);
            this.scc1.Panel1.Controls.Add(this.chkFiltroMensal);
            this.scc1.Panel1.Controls.Add(this.chkFiltroNaoExecutado);
            this.scc1.Panel1.Controls.Add(this.chkFiltroNaoQuitado);
            this.scc1.Panel1.Controls.Add(this.chkFiltroExecutado);
            this.scc1.Panel1.Controls.Add(this.chkFiltroQuitado);
            this.scc1.Panel1.Controls.Add(this.dgRegistros);
            this.scc1.Panel1.Controls.Add(this.btnFiltrar);
            this.scc1.Panel1.Controls.Add(this.btnX);
            this.scc1.Panel1.Controls.Add(this.txtFiltrar);
            this.scc1.Panel2.Controls.Add(this.btnQuitar);
            this.scc1.Panel2.Controls.Add(this.ckbPAGO);
            this.scc1.Panel2.Controls.Add(this.deFechamento);
            this.scc1.Panel2.Controls.Add(this.deAbertura);
            this.scc1.Panel2.Controls.Add(this.btnAlterarCliente);
            this.scc1.Panel2.Controls.Add(this.btncadastroCliente);
            this.scc1.Panel2.Controls.Add(this.btnPesquisar);
            this.scc1.Panel2.Controls.Add(this.cbMensal);
            this.scc1.Panel2.Controls.Add(this.cbExecutado);
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
            this.scc1.Size = new System.Drawing.Size(1360, 649);
            this.scc1.SplitterPosition = 219;
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
            this.btnAlterarCliente.Location = new System.Drawing.Point(771, 4);
            this.btnAlterarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(37, 28);
            this.btnAlterarCliente.TabIndex = 212;
            this.btnAlterarCliente.Text = "M";
            // 
            // btncadastroCliente
            // 
            this.btncadastroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncadastroCliente.Location = new System.Drawing.Point(813, 4);
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
            this.btnPesquisar.Location = new System.Drawing.Point(743, 2);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 28);
            this.btnPesquisar.TabIndex = 208;
            this.btnPesquisar.Text = "??";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbMensal
            // 
            // 
            // 
            // 
            this.cbMensal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbMensal.Location = new System.Drawing.Point(339, 78);
            this.cbMensal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMensal.Name = "cbMensal";
            this.cbMensal.Size = new System.Drawing.Size(68, 28);
            this.cbMensal.TabIndex = 207;
            this.cbMensal.Text = "Mensal";
            // 
            // cbExecutado
            // 
            this.cbExecutado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbExecutado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbExecutado.Location = new System.Drawing.Point(996, 48);
            this.cbExecutado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbExecutado.Name = "cbExecutado";
            this.cbExecutado.Size = new System.Drawing.Size(87, 28);
            this.cbExecutado.TabIndex = 206;
            this.cbExecutado.Text = "Executado";
            // 
            // cbEmpregado
            // 
            this.cbEmpregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmpregado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmpregado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmpregado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpregado.FormattingEnabled = true;
            this.cbEmpregado.Location = new System.Drawing.Point(960, 6);
            this.cbEmpregado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpregado.Name = "cbEmpregado";
            this.cbEmpregado.Size = new System.Drawing.Size(130, 24);
            this.cbEmpregado.TabIndex = 196;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(876, 10);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(84, 17);
            this.Label4.TabIndex = 205;
            this.Label4.Text = "Empregado:";
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
            this.txtObs_Pedido.Size = new System.Drawing.Size(404, 51);
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItens.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItens.EnableHeadersVisualStyles = false;
            this.dgItens.Location = new System.Drawing.Point(2, 2);
            this.dgItens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgItens.MultiSelect = false;
            this.dgItens.Name = "dgItens";
            this.dgItens.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F);
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
            this.dgItens.Size = new System.Drawing.Size(642, 220);
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
            this.pnTotais.Location = new System.Drawing.Point(2, 222);
            this.pnTotais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnTotais.Name = "pnTotais";
            this.pnTotais.Size = new System.Drawing.Size(642, 28);
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
            this.txtTot_Pecas.IsInputReadOnly = true;
            this.txtTot_Pecas.Location = new System.Drawing.Point(467, 1);
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
            this.txtAmortizacao.Increment = 1D;
            this.txtAmortizacao.Location = new System.Drawing.Point(171, 1);
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
            this.txtTotal_Pedido.Increment = 1D;
            this.txtTotal_Pedido.IsInputReadOnly = true;
            this.txtTotal_Pedido.Location = new System.Drawing.Point(560, 1);
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
            this.txtDesconto.Increment = 1D;
            this.txtDesconto.Location = new System.Drawing.Point(343, 1);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(82, 23);
            this.txtDesconto.TabIndex = 101;
            this.txtDesconto.ValueChanged += new System.EventHandler(this.Desconto_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(87, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 102;
            this.label6.Text = "Amortização:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Location = new System.Drawing.Point(256, 6);
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
            this.txtQtde_Itens.Location = new System.Drawing.Point(5, 6);
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
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Location = new System.Drawing.Point(583, 103);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(117, 16);
            this.Label14.TabIndex = 114;
            this.Label14.Text = "Peças Entregues:";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label14.Visible = false;
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
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(591, 180);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(101, 16);
            this.Label3.TabIndex = 111;
            this.Label3.Text = "Total de Pontos:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(419, 176);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(101, 16);
            this.Label1.TabIndex = 109;
            this.Label1.Text = "Pontos Extras:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(408, 103);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(117, 16);
            this.Label12.TabIndex = 105;
            this.Label12.Text = "Defeito ao Bordar:";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(408, 135);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(117, 16);
            this.Label11.TabIndex = 107;
            this.Label11.Text = "Não Bordadas:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnExecutarItem.Location = new System.Drawing.Point(14055, 31);
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
            this.dtpData_Execucao.Location = new System.Drawing.Point(13925, 44);
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
            // Label27
            // 
            this.Label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label27.BackColor = System.Drawing.Color.Transparent;
            this.Label27.Location = new System.Drawing.Point(13824, 50);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(92, 16);
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
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLinhas_Item.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgLinhas_Item.EnableHeadersVisualStyles = false;
            this.dgLinhas_Item.Location = new System.Drawing.Point(19, 78);
            this.dgLinhas_Item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgLinhas_Item.MultiSelect = false;
            this.dgLinhas_Item.Name = "dgLinhas_Item";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 7.8F);
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
            this.dgLinhas_Item.Size = new System.Drawing.Size(296, 0);
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
            // Label30
            // 
            this.Label30.BackColor = System.Drawing.Color.Transparent;
            this.Label30.Location = new System.Drawing.Point(450, 146);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(110, 16);
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
            // Label29
            // 
            this.Label29.BackColor = System.Drawing.Color.Transparent;
            this.Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.Location = new System.Drawing.Point(9, 255);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(159, 22);
            this.Label29.TabIndex = 97;
            this.Label29.Text = "Saldo a Pagar:";
            this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.Transparent;
            this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.Location = new System.Drawing.Point(9, 73);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(159, 22);
            this.Label28.TabIndex = 95;
            this.Label28.Text = "Total do Pedido:";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.Color.Transparent;
            this.Label23.Location = new System.Drawing.Point(86, 308);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(82, 16);
            this.Label23.TabIndex = 93;
            this.Label23.Text = "Obsevação:";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label26
            // 
            this.Label26.BackColor = System.Drawing.Color.Transparent;
            this.Label26.Location = new System.Drawing.Point(83, 217);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(85, 16);
            this.Label26.TabIndex = 89;
            this.Label26.Text = "Valor já pago:";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Location = new System.Drawing.Point(37, 36);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(131, 16);
            this.Label18.TabIndex = 83;
            this.Label18.Text = "Data do Pagamento:";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtObs_Pagamento.Size = new System.Drawing.Size(14126, 0);
            this.txtObs_Pagamento.TabIndex = 3;
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Location = new System.Drawing.Point(90, 122);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(78, 16);
            this.Label24.TabIndex = 85;
            this.Label24.Text = "Adicional:";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(43, 47);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(61, 16);
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
            this.cbCliente.Location = new System.Drawing.Point(258, 5);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(474, 24);
            this.cbCliente.Sorted = true;
            this.cbCliente.TabIndex = 198;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(21, 76);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 16);
            this.Label2.TabIndex = 204;
            this.Label2.Text = "Fechamento:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(532, 48);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(37, 17);
            this.Label7.TabIndex = 202;
            this.Label7.Text = "Obs:";
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
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnFiltrar.Location = new System.Drawing.Point(172, -1);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.MenuManager = this.barManager1;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(51, 31);
            this.btnFiltrar.TabIndex = 58;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnX.Location = new System.Drawing.Point(151, -1);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnX.MenuManager = this.barManager1;
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(21, 31);
            this.btnX.TabIndex = 57;
            this.btnX.Text = "X";
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Location = new System.Drawing.Point(2, 4);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(172, 22);
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
            this.xtabItenPagamentoExecucao.Size = new System.Drawing.Size(1100, 545);
            this.xtabItenPagamentoExecucao.TabIndex = 106;
            this.xtabItenPagamentoExecucao.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbpItem,
            this.xtbpPagamento,
            this.xtbpExecucao});
            // 
            // xtbpItem
            // 
            this.xtbpItem.Controls.Add(this.nudBordado_Id);
            this.xtbpItem.Controls.Add(this.txtTot_a_pagar);
            this.xtbpItem.Controls.Add(this.txtPreco_Por_Peca);
            this.xtbpItem.Controls.Add(this.btnImportar);
            this.xtbpItem.Controls.Add(this.btnAdicionar);
            this.xtbpItem.Controls.Add(this.Label20);
            this.xtbpItem.Controls.Add(this.txtPC_Solicitadas);
            this.xtbpItem.Controls.Add(this.txtTotal_Item);
            this.xtbpItem.Controls.Add(this.lblPeca_solicitadas);
            this.xtbpItem.Controls.Add(this.lblArquivo);
            this.xtbpItem.Controls.Add(this.txtPC_Bordadas);
            this.xtbpItem.Controls.Add(this.label8);
            this.xtbpItem.Controls.Add(this.lblLado);
            this.xtbpItem.Controls.Add(this.dtpData_Entrega);
            this.xtbpItem.Controls.Add(this.btnBaixo);
            this.xtbpItem.Controls.Add(this.Label19);
            this.xtbpItem.Controls.Add(this.txtBordado_Arquivo);
            this.xtbpItem.Controls.Add(this.lblDiaSemana);
            this.xtbpItem.Controls.Add(this.Label16);
            this.xtbpItem.Controls.Add(this.picBordado);
            this.xtbpItem.Controls.Add(this.txtBordado_Descricao);
            this.xtbpItem.Controls.Add(this.btnAgenda);
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
            this.xtbpItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtbpItem.Name = "xtbpItem";
            this.xtbpItem.Size = new System.Drawing.Size(1093, 511);
            this.xtbpItem.Text = "Ítem";
            // 
            // nudBordado_Id
            // 
            this.nudBordado_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.nudBordado_Id.BackgroundStyle.Class = "DateTimeInputBackground";
            this.nudBordado_Id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nudBordado_Id.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.nudBordado_Id.IsInputReadOnly = true;
            this.nudBordado_Id.Location = new System.Drawing.Point(785, 21);
            this.nudBordado_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudBordado_Id.Name = "nudBordado_Id";
            this.nudBordado_Id.Size = new System.Drawing.Size(56, 23);
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
            this.txtTot_a_pagar.Increment = 1D;
            this.txtTot_a_pagar.IsInputReadOnly = true;
            this.txtTot_a_pagar.Location = new System.Drawing.Point(562, 257);
            this.txtTot_a_pagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTot_a_pagar.Name = "txtTot_a_pagar";
            this.txtTot_a_pagar.Size = new System.Drawing.Size(82, 23);
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
            this.txtPreco_Por_Peca.Increment = 1D;
            this.txtPreco_Por_Peca.Location = new System.Drawing.Point(1006, 321);
            this.txtPreco_Por_Peca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreco_Por_Peca.Name = "txtPreco_Por_Peca";
            this.txtPreco_Por_Peca.Size = new System.Drawing.Size(79, 23);
            this.txtPreco_Por_Peca.TabIndex = 118;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Location = new System.Drawing.Point(704, 316);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(159, 55);
            this.btnImportar.TabIndex = 116;
            this.btnImportar.Text = "Carregar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(653, 4);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btnAdicionar.Size = new System.Drawing.Size(27, 28);
            this.btnAdicionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdicionar.TabIndex = 143;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Label20
            // 
            this.Label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(1067, 342);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(21, 31);
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
            this.txtPC_Solicitadas.Location = new System.Drawing.Point(807, 278);
            this.txtPC_Solicitadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPC_Solicitadas.Name = "txtPC_Solicitadas";
            this.txtPC_Solicitadas.Size = new System.Drawing.Size(57, 23);
            this.txtPC_Solicitadas.TabIndex = 115;
            // 
            // txtTotal_Item
            // 
            this.txtTotal_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal_Item.Enabled = false;
            this.txtTotal_Item.Location = new System.Drawing.Point(1006, 380);
            this.txtTotal_Item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal_Item.Name = "txtTotal_Item";
            this.txtTotal_Item.Size = new System.Drawing.Size(79, 23);
            this.txtTotal_Item.TabIndex = 137;
            this.txtTotal_Item.TabStop = false;
            this.txtTotal_Item.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPeca_solicitadas
            // 
            this.lblPeca_solicitadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeca_solicitadas.BackColor = System.Drawing.Color.Transparent;
            this.lblPeca_solicitadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeca_solicitadas.Location = new System.Drawing.Point(680, 278);
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
            this.lblArquivo.Location = new System.Drawing.Point(677, 167);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(56, 16);
            this.lblArquivo.TabIndex = 141;
            this.lblArquivo.Text = "Arquivo:";
            this.lblArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPC_Bordadas
            // 
            this.txtPC_Bordadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPC_Bordadas.Enabled = false;
            this.txtPC_Bordadas.Location = new System.Drawing.Point(1006, 278);
            this.txtPC_Bordadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPC_Bordadas.Name = "txtPC_Bordadas";
            this.txtPC_Bordadas.Size = new System.Drawing.Size(79, 23);
            this.txtPC_Bordadas.TabIndex = 129;
            this.txtPC_Bordadas.TabStop = false;
            this.txtPC_Bordadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 127;
            this.label8.Text = "Valor a Pagar:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLado
            // 
            this.lblLado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLado.BackColor = System.Drawing.Color.Transparent;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(401, 337);
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
            this.dtpData_Entrega.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpData_Entrega.IsPopupCalendarOpen = false;
            this.dtpData_Entrega.Location = new System.Drawing.Point(912, 465);
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
            this.btnBaixo.Location = new System.Drawing.Point(654, 143);
            this.btnBaixo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDown);
            this.btnBaixo.Size = new System.Drawing.Size(27, 28);
            this.btnBaixo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBaixo.TabIndex = 147;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // Label19
            // 
            this.Label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(1053, 300);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(34, 31);
            this.Label19.TabIndex = 138;
            this.Label19.Text = "x";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBordado_Arquivo
            // 
            this.txtBordado_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Arquivo.Location = new System.Drawing.Point(681, 188);
            this.txtBordado_Arquivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBordado_Arquivo.Name = "txtBordado_Arquivo";
            this.txtBordado_Arquivo.Size = new System.Drawing.Size(170, 23);
            this.txtBordado_Arquivo.TabIndex = 117;
            this.txtBordado_Arquivo.TabStop = false;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiaSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.Location = new System.Drawing.Point(907, 444);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(140, 21);
            this.lblDiaSemana.TabIndex = 134;
            this.lblDiaSemana.Text = "...";
            this.lblDiaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label16
            // 
            this.Label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(891, 284);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(122, 20);
            this.Label16.TabIndex = 135;
            this.Label16.Text = "Peças Bordadas:";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picBordado
            // 
            this.picBordado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBordado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.picBordado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBordado.Location = new System.Drawing.Point(852, 4);
            this.picBordado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBordado.Name = "picBordado";
            this.picBordado.Size = new System.Drawing.Size(233, 246);
            this.picBordado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBordado.TabIndex = 123;
            this.picBordado.TabStop = false;
            // 
            // txtBordado_Descricao
            // 
            this.txtBordado_Descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Descricao.Location = new System.Drawing.Point(663, 242);
            this.txtBordado_Descricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBordado_Descricao.Name = "txtBordado_Descricao";
            this.txtBordado_Descricao.Size = new System.Drawing.Size(426, 23);
            this.txtBordado_Descricao.TabIndex = 119;
            this.txtBordado_Descricao.TabStop = false;
            this.txtBordado_Descricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBordado_Descricao_KeyPress);
            // 
            // btnAgenda
            // 
            this.btnAgenda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgenda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgenda.Location = new System.Drawing.Point(1055, 412);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(30, 28);
            this.btnAgenda.TabIndex = 150;
            this.btnAgenda.TabStop = false;
            // 
            // txtBordado_Pontos
            // 
            this.txtBordado_Pontos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Pontos.Enabled = false;
            this.txtBordado_Pontos.Location = new System.Drawing.Point(785, 91);
            this.txtBordado_Pontos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBordado_Pontos.Name = "txtBordado_Pontos";
            this.txtBordado_Pontos.Size = new System.Drawing.Size(61, 23);
            this.txtBordado_Pontos.TabIndex = 125;
            this.txtBordado_Pontos.TabStop = false;
            this.txtBordado_Pontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(681, 144);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(101, 16);
            this.Label5.TabIndex = 130;
            this.Label5.Text = "Preço Sugerido:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rg_lado
            // 
            this.rg_lado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rg_lado.Location = new System.Drawing.Point(465, 326);
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
            this.lblDataEntrega.Location = new System.Drawing.Point(796, 470);
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
            this.btnApagar.Location = new System.Drawing.Point(653, 39);
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
            this.btnCima.Location = new System.Drawing.Point(653, 75);
            this.btnCima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCima.Name = "btnCima";
            this.btnCima.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlUp);
            this.btnCima.Size = new System.Drawing.Size(27, 28);
            this.btnCima.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCima.TabIndex = 145;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // Label25
            // 
            this.Label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label25.BackColor = System.Drawing.Color.Transparent;
            this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location = new System.Drawing.Point(660, 214);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(87, 23);
            this.Label25.TabIndex = 142;
            this.Label25.Text = "Descrição:";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtObs_Item
            // 
            this.txtObs_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObs_Item.Location = new System.Drawing.Point(85, 405);
            this.txtObs_Item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObs_Item.Multiline = true;
            this.txtObs_Item.Name = "txtObs_Item";
            this.txtObs_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs_Item.Size = new System.Drawing.Size(308, 89);
            this.txtObs_Item.TabIndex = 121;
            this.txtObs_Item.TabStop = false;
            // 
            // Label21
            // 
            this.Label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label21.BackColor = System.Drawing.Color.Transparent;
            this.Label21.Location = new System.Drawing.Point(695, 37);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(83, 16);
            this.Label21.TabIndex = 140;
            this.Label21.Text = "Bordado_Id:";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObs_item
            // 
            this.lblObs_item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblObs_item.BackColor = System.Drawing.Color.Transparent;
            this.lblObs_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblObs_item.Location = new System.Drawing.Point(30, 423);
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
            this.btnInserirItem.Location = new System.Drawing.Point(654, 111);
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
            this.lblDescricao.Location = new System.Drawing.Point(-10, 293);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 22);
            this.lblDescricao.TabIndex = 132;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBordado_Preco
            // 
            this.txtBordado_Preco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBordado_Preco.Enabled = false;
            this.txtBordado_Preco.Location = new System.Drawing.Point(788, 140);
            this.txtBordado_Preco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBordado_Preco.Name = "txtBordado_Preco";
            this.txtBordado_Preco.Size = new System.Drawing.Size(56, 23);
            this.txtBordado_Preco.TabIndex = 131;
            this.txtBordado_Preco.TabStop = false;
            this.txtBordado_Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescricao.Location = new System.Drawing.Point(84, 293);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(520, 23);
            this.txtDescricao.TabIndex = 120;
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(705, 90);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(69, 25);
            this.Label9.TabIndex = 124;
            this.Label9.Text = "Pontos:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(20, 335);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(57, 17);
            this.lblLocal.TabIndex = 128;
            this.lblLocal.Text = "Local:";
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rg_local
            // 
            this.rg_local.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rg_local.Location = new System.Drawing.Point(84, 329);
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
            this.pnlItens.Size = new System.Drawing.Size(646, 252);
            this.pnlItens.TabIndex = 0;
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
            this.xtbpPagamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtbpPagamento.Name = "xtbpPagamento";
            this.xtbpPagamento.Size = new System.Drawing.Size(1093, 511);
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
            this.xtbpExecucao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtbpExecucao.Name = "xtbpExecucao";
            this.xtbpExecucao.Size = new System.Drawing.Size(1093, 511);
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
            this.dgRegistros.Location = new System.Drawing.Point(0, 107);
            this.dgRegistros.MainView = this.gdRegistros;
            this.dgRegistros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.Size = new System.Drawing.Size(256, 533);
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
            this.chkFiltroDemais.Location = new System.Drawing.Point(190, 89);
            this.chkFiltroDemais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroDemais.Name = "chkFiltroDemais";
            this.chkFiltroDemais.Size = new System.Drawing.Size(67, 18);
            this.chkFiltroDemais.TabIndex = 104;
            this.chkFiltroDemais.Text = "Demais";
            this.chkFiltroDemais.UseVisualStyleBackColor = true;
            this.chkFiltroDemais.CheckedChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkFiltroMensal
            // 
            this.chkFiltroMensal.AutoSize = true;
            this.chkFiltroMensal.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroMensal.Location = new System.Drawing.Point(190, 69);
            this.chkFiltroMensal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroMensal.Name = "chkFiltroMensal";
            this.chkFiltroMensal.Size = new System.Drawing.Size(65, 18);
            this.chkFiltroMensal.TabIndex = 103;
            this.chkFiltroMensal.Text = "Mensal";
            this.chkFiltroMensal.UseVisualStyleBackColor = true;
            this.chkFiltroMensal.CheckedChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkFiltroNaoExecutado
            // 
            this.chkFiltroNaoExecutado.AutoSize = true;
            this.chkFiltroNaoExecutado.Checked = true;
            this.chkFiltroNaoExecutado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroNaoExecutado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroNaoExecutado.Location = new System.Drawing.Point(83, 89);
            this.chkFiltroNaoExecutado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroNaoExecutado.Name = "chkFiltroNaoExecutado";
            this.chkFiltroNaoExecutado.Size = new System.Drawing.Size(112, 18);
            this.chkFiltroNaoExecutado.TabIndex = 102;
            this.chkFiltroNaoExecutado.Text = "Não Executado";
            this.chkFiltroNaoExecutado.UseVisualStyleBackColor = true;
            this.chkFiltroNaoExecutado.CheckedChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkFiltroNaoQuitado
            // 
            this.chkFiltroNaoQuitado.AutoSize = true;
            this.chkFiltroNaoQuitado.Checked = true;
            this.chkFiltroNaoQuitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroNaoQuitado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroNaoQuitado.Location = new System.Drawing.Point(1, 89);
            this.chkFiltroNaoQuitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroNaoQuitado.Name = "chkFiltroNaoQuitado";
            this.chkFiltroNaoQuitado.Size = new System.Drawing.Size(81, 18);
            this.chkFiltroNaoQuitado.TabIndex = 101;
            this.chkFiltroNaoQuitado.Text = "Não Pago";
            this.chkFiltroNaoQuitado.UseVisualStyleBackColor = true;
            this.chkFiltroNaoQuitado.CheckedChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkFiltroExecutado
            // 
            this.chkFiltroExecutado.AutoSize = true;
            this.chkFiltroExecutado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroExecutado.Location = new System.Drawing.Point(83, 69);
            this.chkFiltroExecutado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroExecutado.Name = "chkFiltroExecutado";
            this.chkFiltroExecutado.Size = new System.Drawing.Size(87, 18);
            this.chkFiltroExecutado.TabIndex = 100;
            this.chkFiltroExecutado.Text = "Executado";
            this.chkFiltroExecutado.UseVisualStyleBackColor = true;
            this.chkFiltroExecutado.CheckedChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkFiltroQuitado
            // 
            this.chkFiltroQuitado.AutoSize = true;
            this.chkFiltroQuitado.Checked = true;
            this.chkFiltroQuitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroQuitado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroQuitado.Location = new System.Drawing.Point(1, 69);
            this.chkFiltroQuitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroQuitado.Name = "chkFiltroQuitado";
            this.chkFiltroQuitado.Size = new System.Drawing.Size(56, 18);
            this.chkFiltroQuitado.TabIndex = 99;
            this.chkFiltroQuitado.Text = "Pago";
            this.chkFiltroQuitado.UseVisualStyleBackColor = true;
            this.chkFiltroQuitado.CheckedChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbFiltroCliente
            // 
            this.cbFiltroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltroCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFiltroCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFiltroCliente.FormattingEnabled = true;
            this.cbFiltroCliente.Location = new System.Drawing.Point(64, 33);
            this.cbFiltroCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFiltroCliente.Name = "cbFiltroCliente";
            this.cbFiltroCliente.Size = new System.Drawing.Size(162, 24);
            this.cbFiltroCliente.TabIndex = 98;
            this.cbFiltroCliente.SelectedIndexChanged += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkFiltroCliente
            // 
            this.chkFiltroCliente.AutoSize = true;
            this.chkFiltroCliente.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroCliente.Location = new System.Drawing.Point(0, 37);
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
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(222, 64);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(111, 41);
            this.btnQuitar.TabIndex = 216;
            this.btnQuitar.Text = "Baixar o Pedido";
            this.btnQuitar.CheckedChanged += new System.EventHandler(this.btnQuitar_CheckedChanged);
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
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1360, 699);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deFechamento;
        private DevExpress.XtraEditors.DateEdit deAbertura;
        internal System.Windows.Forms.Button btnAlterarCliente;
        internal System.Windows.Forms.Button btncadastroCliente;
        private DevComponents.DotNetBar.ButtonX btnPesquisar;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbMensal;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbExecutado;
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
        internal System.Windows.Forms.TextBox txtTotal_Item;
        internal System.Windows.Forms.Label lblPeca_solicitadas;
        internal System.Windows.Forms.Label lblArquivo;
        internal System.Windows.Forms.TextBox txtPC_Bordadas;
        internal System.Windows.Forms.Label lblLado;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpData_Entrega;
        internal DevComponents.DotNetBar.ButtonX btnBaixo;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtBordado_Arquivo;
        internal System.Windows.Forms.Label lblDiaSemana;
        internal System.Windows.Forms.Label Label16;
        public System.Windows.Forms.PictureBox picBordado;
        internal System.Windows.Forms.TextBox txtBordado_Descricao;
        private DevComponents.DotNetBar.ButtonX btnAgenda;
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
        internal DevExpress.XtraEditors.CheckButton btnQuitar;
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
    }
}
