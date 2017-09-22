namespace GUI
{
    partial class frmCadastroEmpregado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEmpregado));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.deDemissao = new DevExpress.XtraEditors.DateEdit();
            this.deAdmissao = new DevExpress.XtraEditors.DateEdit();
            this.deNascimento = new DevExpress.XtraEditors.DateEdit();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.MaterialTipoLabel = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.MaterialFabricanteLabel = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtTelefone3 = new System.Windows.Forms.TextBox();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.CorNomeLabel = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new DevExpress.XtraEditors.DropDownButton();
            this.btnX = new DevExpress.XtraEditors.DropDownButton();
            this.dgRegistros = new DevExpress.XtraGrid.GridControl();
            this.gdRegistros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtFiltrar = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtUf = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).BeginInit();
            this.scc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDemissao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDemissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAdmissao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAdmissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNascimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNascimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
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
            // btnExcluir
            // 
            this.btnExcluir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcluir_ItemClick);
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
            this.scc1.Panel1.Controls.Add(this.panelControl2);
            this.scc1.Panel1.Controls.Add(this.panelControl1);
            this.scc1.Panel2.Controls.Add(this.txtUf);
            this.scc1.Panel2.Controls.Add(this.deDemissao);
            this.scc1.Panel2.Controls.Add(this.deAdmissao);
            this.scc1.Panel2.Controls.Add(this.deNascimento);
            this.scc1.Panel2.Controls.Add(this.txtObs);
            this.scc1.Panel2.Controls.Add(this.MaterialTipoLabel);
            this.scc1.Panel2.Controls.Add(this.Label7);
            this.scc1.Panel2.Controls.Add(this.MaterialFabricanteLabel);
            this.scc1.Panel2.Controls.Add(this.Label6);
            this.scc1.Panel2.Controls.Add(this.txtEmail);
            this.scc1.Panel2.Controls.Add(this.Label5);
            this.scc1.Panel2.Controls.Add(this.txtCEP);
            this.scc1.Panel2.Controls.Add(this.txtTelefone3);
            this.scc1.Panel2.Controls.Add(this.txtTelefone2);
            this.scc1.Panel2.Controls.Add(this.Label4);
            this.scc1.Panel2.Controls.Add(this.txtEndereco);
            this.scc1.Panel2.Controls.Add(this.txtTelefone1);
            this.scc1.Panel2.Controls.Add(this.Label2);
            this.scc1.Panel2.Controls.Add(this.Label3);
            this.scc1.Panel2.Controls.Add(this.txtCidade);
            this.scc1.Panel2.Controls.Add(this.Label11);
            this.scc1.Panel2.Controls.Add(this.Label10);
            this.scc1.Panel2.Controls.Add(this.Label9);
            this.scc1.Panel2.Controls.Add(this.txtFuncao);
            this.scc1.Panel2.Controls.Add(this.txtNome);
            this.scc1.Panel2.Controls.Add(this.CorNomeLabel);
            this.scc1.Panel2.Controls.Add(this.txtId);
            this.scc1.Panel2.Controls.Add(this.label1);
            this.scc1.Size = new System.Drawing.Size(984, 549);
            this.scc1.SplitterPosition = 450;
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
            this.bar1.OptionsBar.UseWholeRow = true;
            // 
            // deDemissao
            // 
            this.deDemissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deDemissao.EditValue = "";
            this.deDemissao.Location = new System.Drawing.Point(362, 128);
            this.deDemissao.Name = "deDemissao";
            this.deDemissao.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.deDemissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDemissao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDemissao.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deDemissao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deDemissao.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deDemissao.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deDemissao.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deDemissao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deDemissao.Properties.NullText = "\"\"";
            this.deDemissao.Size = new System.Drawing.Size(151, 20);
            this.deDemissao.TabIndex = 7;
            // 
            // deAdmissao
            // 
            this.deAdmissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deAdmissao.EditValue = null;
            this.deAdmissao.Location = new System.Drawing.Point(363, 101);
            this.deAdmissao.Name = "deAdmissao";
            this.deAdmissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAdmissao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAdmissao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deAdmissao.Size = new System.Drawing.Size(150, 20);
            this.deAdmissao.TabIndex = 6;
            // 
            // deNascimento
            // 
            this.deNascimento.EditValue = null;
            this.deNascimento.Location = new System.Drawing.Point(122, 101);
            this.deNascimento.Name = "deNascimento";
            this.deNascimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNascimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNascimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deNascimento.Size = new System.Drawing.Size(150, 20);
            this.deNascimento.TabIndex = 5;
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.Location = new System.Drawing.Point(84, 256);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(429, 85);
            this.txtObs.TabIndex = 13;
            // 
            // MaterialTipoLabel
            // 
            this.MaterialTipoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialTipoLabel.AutoSize = true;
            this.MaterialTipoLabel.Location = new System.Drawing.Point(299, 131);
            this.MaterialTipoLabel.Name = "MaterialTipoLabel";
            this.MaterialTipoLabel.Size = new System.Drawing.Size(56, 13);
            this.MaterialTipoLabel.TabIndex = 225;
            this.MaterialTipoLabel.Text = "Demissão:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(48, 256);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(30, 13);
            this.Label7.TabIndex = 236;
            this.Label7.Text = "Obs:";
            // 
            // MaterialFabricanteLabel
            // 
            this.MaterialFabricanteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialFabricanteLabel.AutoSize = true;
            this.MaterialFabricanteLabel.Location = new System.Drawing.Point(303, 104);
            this.MaterialFabricanteLabel.Name = "MaterialFabricanteLabel";
            this.MaterialFabricanteLabel.Size = new System.Drawing.Size(56, 13);
            this.MaterialFabricanteLabel.TabIndex = 224;
            this.MaterialFabricanteLabel.Text = "Admissão:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(82, 73);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(35, 13);
            this.Label6.TabIndex = 234;
            this.Label6.Text = "email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(123, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 21);
            this.txtEmail.TabIndex = 4;
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(380, 229);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(30, 13);
            this.Label5.TabIndex = 233;
            this.Label5.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCEP.Location = new System.Drawing.Point(414, 226);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(99, 21);
            this.txtCEP.TabIndex = 12;
            // 
            // txtTelefone3
            // 
            this.txtTelefone3.Location = new System.Drawing.Point(393, 43);
            this.txtTelefone3.MaxLength = 15;
            this.txtTelefone3.Name = "txtTelefone3";
            this.txtTelefone3.Size = new System.Drawing.Size(120, 21);
            this.txtTelefone3.TabIndex = 217;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Location = new System.Drawing.Point(258, 43);
            this.txtTelefone2.MaxLength = 15;
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(120, 21);
            this.txtTelefone2.TabIndex = 3;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(61, 46);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 13);
            this.Label4.TabIndex = 231;
            this.Label4.Text = "Telefones:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.Location = new System.Drawing.Point(84, 190);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(429, 21);
            this.txtEndereco.TabIndex = 9;
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Location = new System.Drawing.Point(123, 43);
            this.txtTelefone1.MaxLength = 15;
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(120, 21);
            this.txtTelefone1.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 193);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 226;
            this.Label2.Text = "Endereço:";
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(274, 229);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(24, 13);
            this.Label3.TabIndex = 229;
            this.Label3.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.Location = new System.Drawing.Point(84, 226);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(186, 21);
            this.txtCidade.TabIndex = 10;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(34, 229);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(44, 13);
            this.Label11.TabIndex = 227;
            this.Label11.Text = "Cidade:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(70, 157);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(46, 13);
            this.Label10.TabIndex = 222;
            this.Label10.Text = "Função:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(51, 103);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(66, 13);
            this.Label9.TabIndex = 221;
            this.Label9.Text = "Nascimento:";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuncao.Location = new System.Drawing.Point(122, 154);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(391, 21);
            this.txtFuncao.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(125, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 21);
            this.txtNome.TabIndex = 1;
            // 
            // CorNomeLabel
            // 
            this.CorNomeLabel.AutoSize = true;
            this.CorNomeLabel.Location = new System.Drawing.Point(81, 16);
            this.CorNomeLabel.Name = "CorNomeLabel";
            this.CorNomeLabel.Size = new System.Drawing.Size(38, 13);
            this.CorNomeLabel.TabIndex = 220;
            this.CorNomeLabel.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(4, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(49, 29);
            this.txtId.TabIndex = 210;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 218;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnFiltrar.Location = new System.Drawing.Point(405, 2);
            this.btnFiltrar.MenuManager = this.barManager1;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(44, 21);
            this.btnFiltrar.TabIndex = 54;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnX.Location = new System.Drawing.Point(385, 4);
            this.btnX.MenuManager = this.barManager1;
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(18, 18);
            this.btnX.TabIndex = 53;
            this.btnX.Text = "X";
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // dgRegistros
            // 
            this.dgRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.dgRegistros.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgRegistros.Location = new System.Drawing.Point(2, 2);
            this.dgRegistros.MainView = this.gdRegistros;
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.Size = new System.Drawing.Size(446, 515);
            this.dgRegistros.TabIndex = 51;
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
            this.gdRegistros.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdRegistros_FocusedRowChanged);
            this.gdRegistros.DoubleClick += new System.EventHandler(this.gdRegistros_DoubleClick);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Location = new System.Drawing.Point(3, 3);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(400, 20);
            this.txtFiltrar.TabIndex = 52;
            this.txtFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltrar_KeyPress);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnX);
            this.panelControl1.Controls.Add(this.txtFiltrar);
            this.panelControl1.Controls.Add(this.btnFiltrar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(450, 26);
            this.panelControl1.TabIndex = 55;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgRegistros);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 26);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(450, 519);
            this.panelControl2.TabIndex = 56;
            // 
            // txtUf
            // 
            this.txtUf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUf.FormattingEnabled = true;
            this.txtUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtUf.Location = new System.Drawing.Point(302, 227);
            this.txtUf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(45, 21);
            this.txtUf.TabIndex = 11;
            // 
            // frmCadastroEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 589);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroEmpregado";
            this.Text = "Empregado";
            this.Activated += new System.EventHandler(this.frmCadastroEmpregado_Activated);
            this.Load += new System.EventHandler(this.frmCadastroEmpregado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).EndInit();
            this.scc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDemissao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDemissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAdmissao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAdmissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNascimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNascimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deDemissao;
        private DevExpress.XtraEditors.DateEdit deAdmissao;
        private DevExpress.XtraEditors.DateEdit deNascimento;
        internal System.Windows.Forms.TextBox txtObs;
        internal System.Windows.Forms.Label MaterialTipoLabel;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label MaterialFabricanteLabel;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCEP;
        internal System.Windows.Forms.TextBox txtTelefone3;
        internal System.Windows.Forms.TextBox txtTelefone2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtTelefone1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtCidade;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtFuncao;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label CorNomeLabel;
        internal System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DropDownButton btnFiltrar;
        private DevExpress.XtraEditors.DropDownButton btnX;
        private DevExpress.XtraGrid.GridControl dgRegistros;
        private DevExpress.XtraGrid.Views.Grid.GridView gdRegistros;
        private DevExpress.XtraEditors.TextEdit txtFiltrar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox txtUf;
    }
}
