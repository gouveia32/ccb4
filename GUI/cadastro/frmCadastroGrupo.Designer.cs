namespace GUI
{
    partial class frmCadastroGrupos
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.txtGrupo = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgRegistros = new DevExpress.XtraGrid.GridControl();
            this.gdRegistros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtFiltrar = new DevExpress.XtraEditors.TextEdit();
            this.btnX = new DevExpress.XtraEditors.DropDownButton();
            this.btnFiltrar = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).BeginInit();
            this.scc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).BeginInit();
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
            // scc1
            // 
            this.scc1.Location = new System.Drawing.Point(0, 40);
            this.scc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scc1.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.scc1.Panel1.Appearance.Options.UseBackColor = true;
            this.scc1.Panel1.Controls.Add(this.btnFiltrar);
            this.scc1.Panel1.Controls.Add(this.btnX);
            this.scc1.Panel1.Controls.Add(this.txtFiltrar);
            this.scc1.Panel1.Controls.Add(this.dgRegistros);
            this.scc1.Panel2.Controls.Add(this.labelControl2);
            this.scc1.Panel2.Controls.Add(this.labelControl1);
            this.scc1.Panel2.Controls.Add(this.txtGrupo);
            this.scc1.Panel2.Controls.Add(this.txtId);
            this.scc1.Size = new System.Drawing.Size(978, 545);
            this.scc1.SplitterPosition = 150;
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
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(56, 89);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(354, 20);
            this.txtGrupo.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(56, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 20);
            this.txtId.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Grupo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Id:";
            // 
            // dgRegistros
            // 
            this.dgRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Level1";
            this.dgRegistros.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgRegistros.Location = new System.Drawing.Point(0, 28);
            this.dgRegistros.MainView = this.gdRegistros;
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.Size = new System.Drawing.Size(170, 513);
            this.dgRegistros.TabIndex = 41;
            this.dgRegistros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdRegistros});
            // 
            // gdRegistros
            // 
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
            this.txtFiltrar.Size = new System.Drawing.Size(83, 20);
            this.txtFiltrar.TabIndex = 6;
            this.txtFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltrar_KeyPress);
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnX.Location = new System.Drawing.Point(68, 3);
            this.btnX.MenuManager = this.barManager1;
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(18, 20);
            this.btnX.TabIndex = 6;
            this.btnX.Text = "X";
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnFiltrar.Location = new System.Drawing.Point(85, 3);
            this.btnFiltrar.MenuManager = this.barManager1;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(44, 20);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmCadastroGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(978, 585);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCadastroGrupos";
            this.Text = "Grupos";
            this.Activated += new System.EventHandler(this.frmCadastroGrupos_Activated);
            this.Load += new System.EventHandler(this.frmCadastroGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scc1)).EndInit();
            this.scc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtGrupo;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgRegistros;
        private DevExpress.XtraGrid.Views.Grid.GridView gdRegistros;
        private DevExpress.XtraEditors.TextEdit txtFiltrar;
        private DevExpress.XtraEditors.DropDownButton btnX;
        private DevExpress.XtraEditors.DropDownButton btnFiltrar;
    }
}
