namespace GUI
{
    partial class frmCalculaTotalPedido
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculaTotalPedido));
            this.executado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.seq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPedidos = new DevExpress.XtraGrid.GridControl();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.ComboItem12 = new DevComponents.Editors.ComboItem();
            this.ComboItem11 = new DevComponents.Editors.ComboItem();
            this.ComboItem10 = new DevComponents.Editors.ComboItem();
            this.ComboItem9 = new DevComponents.Editors.ComboItem();
            this.ComboItem8 = new DevComponents.Editors.ComboItem();
            this.ComboItem7 = new DevComponents.Editors.ComboItem();
            this.ComboItem6 = new DevComponents.Editors.ComboItem();
            this.ComboItem5 = new DevComponents.Editors.ComboItem();
            this.ComboItem4 = new DevComponents.Editors.ComboItem();
            this.ComboItem3 = new DevComponents.Editors.ComboItem();
            this.ComboItem2 = new DevComponents.Editors.ComboItem();
            this.ComboItem1 = new DevComponents.Editors.ComboItem();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.btnRemoverTodos = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoverSelecionado = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // executado
            // 
            this.executado.AppearanceCell.Options.UseTextOptions = true;
            this.executado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.executado.AppearanceHeader.Options.UseTextOptions = true;
            this.executado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.executado.Caption = "exe";
            this.executado.FieldName = "executado";
            this.executado.Name = "executado";
            this.executado.Visible = true;
            this.executado.VisibleIndex = 4;
            this.executado.Width = 60;
            // 
            // gvPedidos
            // 
            this.gvPedidos.Appearance.EvenRow.Options.UseFont = true;
            this.gvPedidos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPedidos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPedidos.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 7F);
            this.gvPedidos.Appearance.OddRow.Options.UseFont = true;
            this.gvPedidos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 7F);
            this.gvPedidos.Appearance.Row.Options.UseFont = true;
            this.gvPedidos.Appearance.Row.Options.UseTextOptions = true;
            this.gvPedidos.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.seq,
            this.pedido,
            this.cliente,
            this.data,
            this.executado,
            this.valor});
            this.gvPedidos.FixedLineWidth = 1;
            this.gvPedidos.FooterPanelHeight = 20;
            gridFormatRule1.Column = this.executado;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "Sim";
            formatConditionRuleValue1.PredefinedName = "Red Fill, Red Text";
            formatConditionRuleValue1.Value1 = "Sim";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gvPedidos.FormatRules.Add(gridFormatRule1);
            this.gvPedidos.GridControl = this.gcPedidos;
            this.gvPedidos.GroupFormat = "{0}: [#imagem]{1} {2}";
            this.gvPedidos.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvPedidos.Name = "gvPedidos";
            this.gvPedidos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPedidos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPedidos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvPedidos.OptionsBehavior.AutoPopulateColumns = false;
            this.gvPedidos.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvPedidos.OptionsBehavior.Editable = false;
            this.gvPedidos.OptionsBehavior.ReadOnly = true;
            this.gvPedidos.OptionsCustomization.AllowColumnMoving = false;
            this.gvPedidos.OptionsCustomization.AllowColumnResizing = false;
            this.gvPedidos.OptionsCustomization.AllowFilter = false;
            this.gvPedidos.OptionsCustomization.AllowGroup = false;
            this.gvPedidos.OptionsCustomization.AllowSort = false;
            this.gvPedidos.OptionsDetail.SmartDetailHeight = true;
            this.gvPedidos.OptionsMenu.EnableColumnMenu = false;
            this.gvPedidos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPedidos.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvPedidos.OptionsSelection.MultiSelect = true;
            this.gvPedidos.OptionsSelection.UseIndicatorForSelection = false;
            this.gvPedidos.OptionsView.ColumnAutoWidth = false;
            this.gvPedidos.OptionsView.ShowFooter = true;
            this.gvPedidos.OptionsView.ShowGroupPanel = false;
            this.gvPedidos.RowHeight = 23;
            // 
            // seq
            // 
            this.seq.AppearanceCell.Options.UseTextOptions = true;
            this.seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.seq.AppearanceHeader.Options.UseTextOptions = true;
            this.seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.seq.Caption = "seq";
            this.seq.FieldName = "seq";
            this.seq.Name = "seq";
            this.seq.Visible = true;
            this.seq.VisibleIndex = 0;
            this.seq.Width = 45;
            // 
            // pedido
            // 
            this.pedido.AppearanceCell.Options.UseTextOptions = true;
            this.pedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pedido.AppearanceHeader.Options.UseTextOptions = true;
            this.pedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pedido.Caption = "pedido";
            this.pedido.FieldName = "pedido";
            this.pedido.Name = "pedido";
            this.pedido.Visible = true;
            this.pedido.VisibleIndex = 1;
            this.pedido.Width = 65;
            // 
            // cliente
            // 
            this.cliente.Caption = "cliente";
            this.cliente.FieldName = "cliente";
            this.cliente.Name = "cliente";
            this.cliente.Visible = true;
            this.cliente.VisibleIndex = 2;
            this.cliente.Width = 150;
            // 
            // data
            // 
            this.data.AppearanceCell.Options.UseTextOptions = true;
            this.data.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.data.AppearanceHeader.Options.UseTextOptions = true;
            this.data.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.data.Caption = "data";
            this.data.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.data.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.data.FieldName = "data";
            this.data.Name = "data";
            this.data.Visible = true;
            this.data.VisibleIndex = 3;
            this.data.Width = 80;
            // 
            // valor
            // 
            this.valor.AppearanceCell.Options.UseTextOptions = true;
            this.valor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.valor.AppearanceHeader.Options.UseTextOptions = true;
            this.valor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.valor.Caption = "valor";
            this.valor.DisplayFormat.FormatString = "{0:n2}";
            this.valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.valor.FieldName = "valor";
            this.valor.Name = "valor";
            this.valor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor", "{0:n2}")});
            this.valor.Visible = true;
            this.valor.VisibleIndex = 5;
            this.valor.Width = 90;
            // 
            // gcPedidos
            // 
            this.gcPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcPedidos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcPedidos.Location = new System.Drawing.Point(125, 0);
            this.gcPedidos.MainView = this.gvPedidos;
            this.gcPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.gcPedidos.Name = "gcPedidos";
            this.gcPedidos.Size = new System.Drawing.Size(496, 406);
            this.gcPedidos.TabIndex = 114;
            this.gcPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidos});
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(6, 21);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(75, 23);
            this.LabelX1.TabIndex = 115;
            this.LabelX1.Text = "Pedido:";
            // 
            // ComboItem12
            // 
            this.ComboItem12.Text = "Obs";
            // 
            // ComboItem11
            // 
            this.ComboItem11.Text = "email";
            // 
            // ComboItem10
            // 
            this.ComboItem10.Text = "CEP";
            // 
            // ComboItem9
            // 
            this.ComboItem9.Text = "Estado";
            // 
            // ComboItem8
            // 
            this.ComboItem8.Text = "Cidade";
            // 
            // ComboItem7
            // 
            this.ComboItem7.Text = "Endereco";
            // 
            // ComboItem6
            // 
            this.ComboItem6.Text = "Incr_Estadual";
            // 
            // ComboItem5
            // 
            this.ComboItem5.Text = "Cgc_Cpf";
            // 
            // ComboItem4
            // 
            this.ComboItem4.Text = "Contato_Nome";
            // 
            // ComboItem3
            // 
            this.ComboItem3.Text = "Contato_Funcao";
            // 
            // ComboItem2
            // 
            this.ComboItem2.Text = "Nome";
            // 
            // ComboItem1
            // 
            this.ComboItem1.Text = "Cliente_Id";
            // 
            // txtPedido
            // 
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.ForeColor = System.Drawing.Color.Navy;
            this.txtPedido.Location = new System.Drawing.Point(7, 41);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(112, 26);
            this.txtPedido.TabIndex = 201;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedido_KeyPress);
            // 
            // btnRemoverTodos
            // 
            this.btnRemoverTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverTodos.Image")));
            this.btnRemoverTodos.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRemoverTodos.Location = new System.Drawing.Point(6, 192);
            this.btnRemoverTodos.Name = "btnRemoverTodos";
            this.btnRemoverTodos.Size = new System.Drawing.Size(113, 59);
            this.btnRemoverTodos.TabIndex = 218;
            this.btnRemoverTodos.Text = "Remover todos";
            this.btnRemoverTodos.Click += new System.EventHandler(this.btnRemoverTodos_Click_1);
            // 
            // btnRemoverSelecionado
            // 
            this.btnRemoverSelecionado.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverSelecionado.Image")));
            this.btnRemoverSelecionado.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRemoverSelecionado.Location = new System.Drawing.Point(6, 130);
            this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
            this.btnRemoverSelecionado.Size = new System.Drawing.Size(113, 56);
            this.btnRemoverSelecionado.TabIndex = 219;
            this.btnRemoverSelecionado.Text = "Remover Selecionado";
            this.btnRemoverSelecionado.Click += new System.EventHandler(this.btnRemoverSelecionado_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(7, 353);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 41);
            this.btnFechar.TabIndex = 220;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCalculaTotalPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(621, 405);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRemoverSelecionado);
            this.Controls.Add(this.btnRemoverTodos);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.gcPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCalculaTotalPedido";
            this.Text = "Calcula Total de Pedidos";
            this.Activated += new System.EventHandler(this.frmCalculaTotalPedido_Activated);
            this.Load += new System.EventHandler(this.frmCalculaTotalPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal DevExpress.XtraGrid.Columns.GridColumn valor;
        internal DevExpress.XtraGrid.Columns.GridColumn data;
        internal DevExpress.XtraGrid.Columns.GridColumn cliente;
        internal DevExpress.XtraGrid.Columns.GridColumn pedido;
        internal DevExpress.XtraGrid.Columns.GridColumn seq;
        internal DevExpress.XtraGrid.Views.Grid.GridView gvPedidos;
        internal DevExpress.XtraGrid.GridControl gcPedidos;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        internal DevComponents.Editors.ComboItem ComboItem12;
        internal DevComponents.Editors.ComboItem ComboItem11;
        internal DevComponents.Editors.ComboItem ComboItem10;
        internal DevComponents.Editors.ComboItem ComboItem9;
        internal DevComponents.Editors.ComboItem ComboItem8;
        internal DevComponents.Editors.ComboItem ComboItem7;
        internal DevComponents.Editors.ComboItem ComboItem6;
        internal DevComponents.Editors.ComboItem ComboItem5;
        internal DevComponents.Editors.ComboItem ComboItem4;
        internal DevComponents.Editors.ComboItem ComboItem3;
        internal DevComponents.Editors.ComboItem ComboItem2;
        internal DevComponents.Editors.ComboItem ComboItem1;
        internal System.Windows.Forms.TextBox txtPedido;
        private DevExpress.XtraEditors.SimpleButton btnRemoverTodos;
        private DevExpress.XtraEditors.SimpleButton btnRemoverSelecionado;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraGrid.Columns.GridColumn executado;
    }
}