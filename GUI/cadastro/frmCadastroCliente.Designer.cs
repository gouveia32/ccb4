namespace GUI
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtInscr_Estadual = new System.Windows.Forms.TextBox();
            this.MaterialTipoLabel = new System.Windows.Forms.Label();
            this.txtCgc_Cpf = new System.Windows.Forms.TextBox();
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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtContato_Nome = new System.Windows.Forms.TextBox();
            this.MaterialNomeLabel = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.CorNomeLabel = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtContato_Funcao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new DevExpress.XtraEditors.DropDownButton();
            this.btnFiltrar = new DevExpress.XtraEditors.DropDownButton();
            this.txtFiltrar = new DevExpress.XtraEditors.TextEdit();
            this.dgRegistros = new DevExpress.XtraGrid.GridControl();
            this.gdRegistros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).BeginInit();
            this.scc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            // btnAlterar
            // 
            this.btnAlterar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAlterar_ItemClick);
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
            this.scc1.Location = new System.Drawing.Point(0, 50);
            this.scc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scc1.Panel1.Controls.Add(this.panelControl1);
            this.scc1.Panel1.Controls.Add(this.dgRegistros);
            this.scc1.Panel2.Controls.Add(this.txtObs);
            this.scc1.Panel2.Controls.Add(this.txtInscr_Estadual);
            this.scc1.Panel2.Controls.Add(this.MaterialTipoLabel);
            this.scc1.Panel2.Controls.Add(this.txtCgc_Cpf);
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
            this.scc1.Panel2.Controls.Add(this.txtEstado);
            this.scc1.Panel2.Controls.Add(this.Label11);
            this.scc1.Panel2.Controls.Add(this.Label10);
            this.scc1.Panel2.Controls.Add(this.Label9);
            this.scc1.Panel2.Controls.Add(this.txtContato_Nome);
            this.scc1.Panel2.Controls.Add(this.MaterialNomeLabel);
            this.scc1.Panel2.Controls.Add(this.txtNome);
            this.scc1.Panel2.Controls.Add(this.CorNomeLabel);
            this.scc1.Panel2.Controls.Add(this.txtId);
            this.scc1.Panel2.Controls.Add(this.txtContato_Funcao);
            this.scc1.Panel2.Controls.Add(this.label1);
            this.scc1.Size = new System.Drawing.Size(1148, 691);
            this.scc1.SplitterPosition = 386;
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
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.Location = new System.Drawing.Point(111, 396);
            this.txtObs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(580, 104);
            this.txtObs.TabIndex = 180;
            // 
            // txtInscr_Estadual
            // 
            this.txtInscr_Estadual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInscr_Estadual.Location = new System.Drawing.Point(110, 272);
            this.txtInscr_Estadual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInscr_Estadual.Name = "txtInscr_Estadual";
            this.txtInscr_Estadual.Size = new System.Drawing.Size(581, 23);
            this.txtInscr_Estadual.TabIndex = 165;
            // 
            // MaterialTipoLabel
            // 
            this.MaterialTipoLabel.AutoSize = true;
            this.MaterialTipoLabel.Location = new System.Drawing.Point(13, 276);
            this.MaterialTipoLabel.Name = "MaterialTipoLabel";
            this.MaterialTipoLabel.Size = new System.Drawing.Size(98, 17);
            this.MaterialTipoLabel.TabIndex = 168;
            this.MaterialTipoLabel.Text = "Inscr Estadual:";
            // 
            // txtCgc_Cpf
            // 
            this.txtCgc_Cpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCgc_Cpf.Location = new System.Drawing.Point(110, 231);
            this.txtCgc_Cpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCgc_Cpf.Name = "txtCgc_Cpf";
            this.txtCgc_Cpf.Size = new System.Drawing.Size(581, 23);
            this.txtCgc_Cpf.TabIndex = 164;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(71, 400);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(37, 17);
            this.Label7.TabIndex = 179;
            this.Label7.Text = "Obs:";
            // 
            // MaterialFabricanteLabel
            // 
            this.MaterialFabricanteLabel.AutoSize = true;
            this.MaterialFabricanteLabel.Location = new System.Drawing.Point(41, 235);
            this.MaterialFabricanteLabel.Name = "MaterialFabricanteLabel";
            this.MaterialFabricanteLabel.Size = new System.Drawing.Size(69, 17);
            this.MaterialFabricanteLabel.TabIndex = 167;
            this.MaterialFabricanteLabel.Text = "CGC/CPF:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(107, 89);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(43, 17);
            this.Label6.TabIndex = 177;
            this.Label6.Text = "email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(155, 85);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(536, 23);
            this.txtEmail.TabIndex = 178;
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(860, 367);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(38, 17);
            this.Label5.TabIndex = 176;
            this.Label5.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCEP.Location = new System.Drawing.Point(902, 363);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(101, 23);
            this.txtCEP.TabIndex = 175;
            // 
            // txtTelefone3
            // 
            this.txtTelefone3.Location = new System.Drawing.Point(460, 52);
            this.txtTelefone3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefone3.MaxLength = 15;
            this.txtTelefone3.Name = "txtTelefone3";
            this.txtTelefone3.Size = new System.Drawing.Size(146, 23);
            this.txtTelefone3.TabIndex = 157;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Location = new System.Drawing.Point(309, 52);
            this.txtTelefone2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefone2.MaxLength = 15;
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(146, 23);
            this.txtTelefone2.TabIndex = 156;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(83, 55);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(70, 17);
            this.Label4.TabIndex = 174;
            this.Label4.Text = "Telefones:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.Location = new System.Drawing.Point(111, 319);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(580, 23);
            this.txtEndereco.TabIndex = 166;
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Location = new System.Drawing.Point(155, 52);
            this.txtTelefone1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefone1.MaxLength = 15;
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(146, 23);
            this.txtTelefone1.TabIndex = 154;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(41, 322);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 17);
            this.Label2.TabIndex = 169;
            this.Label2.Text = "Endereço:";
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(738, 367);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 17);
            this.Label3.TabIndex = 172;
            this.Label3.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.Location = new System.Drawing.Point(110, 363);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(581, 23);
            this.txtCidade.TabIndex = 171;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.Location = new System.Drawing.Point(773, 363);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(46, 23);
            this.txtEstado.TabIndex = 173;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(51, 367);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(54, 17);
            this.Label11.TabIndex = 170;
            this.Label11.Text = "Cidade:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(65, 202);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(49, 17);
            this.Label10.TabIndex = 163;
            this.Label10.Text = "Nome:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(52, 170);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(58, 17);
            this.Label9.TabIndex = 162;
            this.Label9.Text = "Função:";
            // 
            // txtContato_Nome
            // 
            this.txtContato_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContato_Nome.Location = new System.Drawing.Point(110, 198);
            this.txtContato_Nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContato_Nome.Name = "txtContato_Nome";
            this.txtContato_Nome.Size = new System.Drawing.Size(581, 23);
            this.txtContato_Nome.TabIndex = 159;
            // 
            // MaterialNomeLabel
            // 
            this.MaterialNomeLabel.AutoSize = true;
            this.MaterialNomeLabel.Location = new System.Drawing.Point(80, 132);
            this.MaterialNomeLabel.Name = "MaterialNomeLabel";
            this.MaterialNomeLabel.Size = new System.Drawing.Size(63, 17);
            this.MaterialNomeLabel.TabIndex = 161;
            this.MaterialNomeLabel.Text = "Contato:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(155, 15);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(536, 23);
            this.txtNome.TabIndex = 153;
            // 
            // CorNomeLabel
            // 
            this.CorNomeLabel.AutoSize = true;
            this.CorNomeLabel.Location = new System.Drawing.Point(106, 18);
            this.CorNomeLabel.Name = "CorNomeLabel";
            this.CorNomeLabel.Size = new System.Drawing.Size(49, 17);
            this.CorNomeLabel.TabIndex = 160;
            this.CorNomeLabel.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(16, 42);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 34);
            this.txtId.TabIndex = 152;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContato_Funcao
            // 
            this.txtContato_Funcao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContato_Funcao.Location = new System.Drawing.Point(110, 166);
            this.txtContato_Funcao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContato_Funcao.Name = "txtContato_Funcao";
            this.txtContato_Funcao.Size = new System.Drawing.Size(581, 23);
            this.txtContato_Funcao.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 158;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnX.Location = new System.Drawing.Point(420, 1);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnX.MenuManager = this.barManager1;
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 27);
            this.btnX.TabIndex = 57;
            this.btnX.ToolTip = "Limpar Filtro";
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnFiltrar.Location = new System.Drawing.Point(368, 1);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.MenuManager = this.barManager1;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(59, 25);
            this.btnFiltrar.TabIndex = 58;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Location = new System.Drawing.Point(0, 3);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(362, 22);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltrar_KeyPress);
            // 
            // dgRegistros
            // 
            this.dgRegistros.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.RelationName = "Level1";
            this.dgRegistros.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgRegistros.Location = new System.Drawing.Point(10, 33);
            this.dgRegistros.MainView = this.gdRegistros;
            this.dgRegistros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.Size = new System.Drawing.Size(440, 469);
            this.dgRegistros.TabIndex = 118;
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
            this.gdRegistros.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            this.gdRegistros.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdRegistros_FocusedRowChanged);
            this.gdRegistros.DoubleClick += new System.EventHandler(this.gdRegistros_DoubleClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnX);
            this.panelControl1.Controls.Add(this.btnFiltrar);
            this.panelControl1.Controls.Add(this.txtFiltrar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(450, 32);
            this.panelControl1.TabIndex = 119;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1148, 741);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmCadastroCliente";
            this.Text = "Cliente";
            this.Activated += new System.EventHandler(this.frmCadastroCliente_Activated);
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).EndInit();
            this.scc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtObs;
        internal System.Windows.Forms.TextBox txtInscr_Estadual;
        internal System.Windows.Forms.Label MaterialTipoLabel;
        internal System.Windows.Forms.TextBox txtCgc_Cpf;
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
        internal System.Windows.Forms.TextBox txtEstado;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtContato_Nome;
        internal System.Windows.Forms.Label MaterialNomeLabel;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label CorNomeLabel;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.TextBox txtContato_Funcao;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DropDownButton btnX;
        private DevExpress.XtraEditors.DropDownButton btnFiltrar;
        private DevExpress.XtraEditors.TextEdit txtFiltrar;
        private DevExpress.XtraGrid.GridControl dgRegistros;
        private DevExpress.XtraGrid.Views.Grid.GridView gdRegistros;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
