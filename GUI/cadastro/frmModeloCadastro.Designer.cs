namespace GUI
{
    partial class frmModeloCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModeloCadastro));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.scc1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnInserir = new DevExpress.XtraBars.BarButtonItem();
            this.btnGravar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAlterar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.txtLocalizar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnLocalizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.btnProxima = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).BeginInit();
            this.scc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // scc1
            // 
            this.scc1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.scc1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.scc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scc1.Location = new System.Drawing.Point(0, 40);
            this.scc1.Name = "scc1";
            this.scc1.Panel1.Text = "Esquerdo";
            this.scc1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.scc1.Panel2.Text = "direito";
            this.scc1.Size = new System.Drawing.Size(978, 546);
            this.scc1.SplitterPosition = 250;
            this.scc1.TabIndex = 0;
            this.scc1.Text = "scc1";
            // 
            // barManager1
            // 
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.CloseButtonAffectAllTabs = false;
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem3,
            this.btnInserir,
            this.btnGravar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.txtLocalizar,
            this.btnLocalizar,
            this.btnAnterior,
            this.btnProxima,
            this.btnImprimir,
            this.btnAtualizar});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 12;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInserir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGravar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAlterar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcluir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAtualizar),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.txtLocalizar, "", false, true, true, 301),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLocalizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAnterior),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProxima),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImprimir)});
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Opções";
            // 
            // btnInserir
            // 
            this.btnInserir.Caption = "Inserir";
            this.btnInserir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnInserir.Glyph")));
            this.btnInserir.Id = 1;
            this.btnInserir.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInserir_ItemClick);
            // 
            // btnGravar
            // 
            this.btnGravar.Caption = "Gravar";
            this.btnGravar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGravar.Glyph")));
            this.btnGravar.Id = 2;
            this.btnGravar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.btnGravar.Name = "btnGravar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.btnAlterar.Caption = "Alterar";
            this.btnAlterar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Glyph")));
            this.btnAlterar.Id = 3;
            this.btnAlterar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.DownChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAlterar_DownChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Caption = "Excluir";
            this.btnExcluir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Glyph")));
            this.btnExcluir.Id = 4;
            this.btnExcluir.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete));
            this.btnExcluir.Name = "btnExcluir";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar";
            this.btnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Glyph")));
            this.btnCancelar.Id = 5;
            this.btnCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelar_ItemClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Caption = "Atualizar";
            this.btnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Glyph")));
            this.btnAtualizar.Id = 11;
            this.btnAtualizar.Name = "btnAtualizar";
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Caption = "Localizar";
            this.txtLocalizar.CaptionAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtLocalizar.Edit = this.repositoryItemTextEdit1;
            this.txtLocalizar.Id = 6;
            this.txtLocalizar.Name = "txtLocalizar";
            toolTipTitleItem1.Text = "Digite o que deseja localizar";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = resources.GetString("toolTipItem1.Text");
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.txtLocalizar.SuperTip = superToolTip1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Caption = "Localizar";
            this.btnLocalizar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Glyph")));
            this.btnLocalizar.Id = 7;
            this.btnLocalizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.btnLocalizar.Name = "btnLocalizar";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Caption = "Anterior";
            this.btnAnterior.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Glyph")));
            this.btnAnterior.Id = 8;
            this.btnAnterior.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left));
            this.btnAnterior.Name = "btnAnterior";
            // 
            // btnProxima
            // 
            this.btnProxima.Caption = "Próxima";
            this.btnProxima.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProxima.Glyph")));
            this.btnProxima.Id = 9;
            this.btnProxima.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right));
            this.btnProxima.Name = "btnProxima";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Glyph")));
            this.btnImprimir.Id = 10;
            this.btnImprimir.Name = "btnImprimir";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(978, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 586);
            this.barDockControl2.Size = new System.Drawing.Size(978, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Size = new System.Drawing.Size(0, 546);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(978, 40);
            this.barDockControl4.Size = new System.Drawing.Size(0, 546);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem1";
            this.barButtonItem3.Id = 0;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // frmModeloCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 586);
            this.Controls.Add(this.scc1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmModeloCadastro";
            this.Text = "Modelo de Formulário Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmModeloCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).EndInit();
            this.scc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.BarEditItem txtLocalizar;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        public DevExpress.XtraBars.BarButtonItem btnInserir;
        public DevExpress.XtraBars.BarButtonItem btnGravar;
        public DevExpress.XtraBars.BarButtonItem btnAlterar;
        public DevExpress.XtraBars.BarButtonItem btnExcluir;
        public DevExpress.XtraBars.BarButtonItem btnCancelar;
        public DevExpress.XtraBars.BarButtonItem btnLocalizar;
        public DevExpress.XtraBars.BarButtonItem btnAnterior;
        public DevExpress.XtraBars.BarButtonItem btnProxima;
        public DevExpress.XtraBars.BarButtonItem btnImprimir;
        public DevExpress.XtraEditors.SplitContainerControl scc1;
        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraBars.BarButtonItem btnAtualizar;
        public DevExpress.XtraBars.Bar bar1;
    }
}