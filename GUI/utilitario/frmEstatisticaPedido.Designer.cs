namespace GUI
{
    partial class frmEstatisticaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstatisticaPedido));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.gvPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPedidos = new DevExpress.XtraGrid.GridControl();
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
            this.btnFiltrar = new DevExpress.XtraEditors.DropDownButton();
            this.chkFiltroDemais = new System.Windows.Forms.CheckBox();
            this.chkFiltroMensal = new System.Windows.Forms.CheckBox();
            this.chkFiltroNaoExecutado = new System.Windows.Forms.CheckBox();
            this.chkFiltroNaoQuitado = new System.Windows.Forms.CheckBox();
            this.btnX = new DevExpress.XtraEditors.DropDownButton();
            this.chkFiltroExecutado = new System.Windows.Forms.CheckBox();
            this.txtFiltrar = new DevExpress.XtraEditors.TextEdit();
            this.chkFiltroQuitado = new System.Windows.Forms.CheckBox();
            this.chartLinhaHistorico = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLinhaHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
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
            this.pedido,
            this.cliente,
            this.data,
            this.valor});
            this.gvPedidos.FixedLineWidth = 1;
            this.gvPedidos.FooterPanelHeight = 20;
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
            // pedido
            // 
            this.pedido.AppearanceCell.Options.UseTextOptions = true;
            this.pedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pedido.AppearanceHeader.Options.UseTextOptions = true;
            this.pedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pedido.Caption = "pedido";
            this.pedido.FieldName = "id";
            this.pedido.Name = "pedido";
            this.pedido.Visible = true;
            this.pedido.VisibleIndex = 0;
            this.pedido.Width = 65;
            // 
            // cliente
            // 
            this.cliente.Caption = "cliente";
            this.cliente.FieldName = "cliente";
            this.cliente.Name = "cliente";
            this.cliente.Visible = true;
            this.cliente.VisibleIndex = 1;
            this.cliente.Width = 200;
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
            this.data.VisibleIndex = 2;
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
            this.valor.VisibleIndex = 3;
            this.valor.Width = 90;
            // 
            // gcPedidos
            // 
            this.gcPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcPedidos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcPedidos.Location = new System.Drawing.Point(3, 63);
            this.gcPedidos.MainView = this.gvPedidos;
            this.gcPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.gcPedidos.Name = "gcPedidos";
            this.gcPedidos.Size = new System.Drawing.Size(624, 430);
            this.gcPedidos.TabIndex = 114;
            this.gcPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidos});
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
            // btnFiltrar
            // 
            this.btnFiltrar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnFiltrar.Location = new System.Drawing.Point(268, 15);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(42, 26);
            this.btnFiltrar.TabIndex = 223;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkFiltroDemais
            // 
            this.chkFiltroDemais.AutoSize = true;
            this.chkFiltroDemais.Checked = true;
            this.chkFiltroDemais.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroDemais.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroDemais.Location = new System.Drawing.Point(545, 34);
            this.chkFiltroDemais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroDemais.Name = "chkFiltroDemais";
            this.chkFiltroDemais.Size = new System.Drawing.Size(67, 18);
            this.chkFiltroDemais.TabIndex = 230;
            this.chkFiltroDemais.Text = "Demais";
            this.chkFiltroDemais.UseVisualStyleBackColor = true;
            this.chkFiltroDemais.CheckedChanged += new System.EventHandler(this.chkFiltroDemais_CheckedChanged);
            // 
            // chkFiltroMensal
            // 
            this.chkFiltroMensal.AutoSize = true;
            this.chkFiltroMensal.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroMensal.Location = new System.Drawing.Point(545, 15);
            this.chkFiltroMensal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroMensal.Name = "chkFiltroMensal";
            this.chkFiltroMensal.Size = new System.Drawing.Size(65, 18);
            this.chkFiltroMensal.TabIndex = 229;
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
            this.chkFiltroNaoExecutado.Location = new System.Drawing.Point(413, 37);
            this.chkFiltroNaoExecutado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroNaoExecutado.Name = "chkFiltroNaoExecutado";
            this.chkFiltroNaoExecutado.Size = new System.Drawing.Size(112, 18);
            this.chkFiltroNaoExecutado.TabIndex = 228;
            this.chkFiltroNaoExecutado.Text = "Não Executado";
            this.chkFiltroNaoExecutado.UseVisualStyleBackColor = true;
            this.chkFiltroNaoExecutado.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.chkFiltroNaoExecutado_ChangeUICues);
            // 
            // chkFiltroNaoQuitado
            // 
            this.chkFiltroNaoQuitado.AutoSize = true;
            this.chkFiltroNaoQuitado.Checked = true;
            this.chkFiltroNaoQuitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroNaoQuitado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroNaoQuitado.Location = new System.Drawing.Point(316, 34);
            this.chkFiltroNaoQuitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroNaoQuitado.Name = "chkFiltroNaoQuitado";
            this.chkFiltroNaoQuitado.Size = new System.Drawing.Size(81, 18);
            this.chkFiltroNaoQuitado.TabIndex = 227;
            this.chkFiltroNaoQuitado.Text = "Não Pago";
            this.chkFiltroNaoQuitado.UseVisualStyleBackColor = true;
            this.chkFiltroNaoQuitado.CheckedChanged += new System.EventHandler(this.chkFiltroNaoQuitado_CheckedChanged);
            // 
            // btnX
            // 
            this.btnX.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnX.Location = new System.Drawing.Point(241, 16);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(21, 22);
            this.btnX.TabIndex = 222;
            this.btnX.Text = "X";
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // chkFiltroExecutado
            // 
            this.chkFiltroExecutado.AutoSize = true;
            this.chkFiltroExecutado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroExecutado.Location = new System.Drawing.Point(413, 17);
            this.chkFiltroExecutado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroExecutado.Name = "chkFiltroExecutado";
            this.chkFiltroExecutado.Size = new System.Drawing.Size(87, 18);
            this.chkFiltroExecutado.TabIndex = 226;
            this.chkFiltroExecutado.Text = "Executado";
            this.chkFiltroExecutado.UseVisualStyleBackColor = true;
            this.chkFiltroExecutado.CheckedChanged += new System.EventHandler(this.chkFiltroExecutado_CheckedChanged);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(13, 16);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(250, 22);
            this.txtFiltrar.TabIndex = 221;
            this.txtFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltrar_KeyPress);
            // 
            // chkFiltroQuitado
            // 
            this.chkFiltroQuitado.AutoSize = true;
            this.chkFiltroQuitado.Checked = true;
            this.chkFiltroQuitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroQuitado.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroQuitado.Location = new System.Drawing.Point(316, 15);
            this.chkFiltroQuitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFiltroQuitado.Name = "chkFiltroQuitado";
            this.chkFiltroQuitado.Size = new System.Drawing.Size(56, 18);
            this.chkFiltroQuitado.TabIndex = 225;
            this.chkFiltroQuitado.Text = "Pago";
            this.chkFiltroQuitado.UseVisualStyleBackColor = true;
            this.chkFiltroQuitado.CheckedChanged += new System.EventHandler(this.chkFiltroQuitado_CheckedChanged);
            // 
            // chartLinhaHistorico
            // 
            this.chartLinhaHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartLinhaHistorico.Diagram = xyDiagram1;
            this.chartLinhaHistorico.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.LeftOutside;
            this.chartLinhaHistorico.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            this.chartLinhaHistorico.Legend.Name = "Default Legend";
            this.chartLinhaHistorico.Location = new System.Drawing.Point(635, 64);
            this.chartLinhaHistorico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartLinhaHistorico.Name = "chartLinhaHistorico";
            series1.Name = "valor";
            this.chartLinhaHistorico.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartLinhaHistorico.Size = new System.Drawing.Size(841, 429);
            this.chartLinhaHistorico.TabIndex = 231;
            // 
            // frmEstatisticaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 498);
            this.Controls.Add(this.chartLinhaHistorico);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.chkFiltroDemais);
            this.Controls.Add(this.chkFiltroMensal);
            this.Controls.Add(this.chkFiltroNaoExecutado);
            this.Controls.Add(this.chkFiltroNaoQuitado);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.chkFiltroExecutado);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.chkFiltroQuitado);
            this.Controls.Add(this.gcPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEstatisticaPedido";
            this.Text = "Estatística de Pedidos";
            this.Load += new System.EventHandler(this.frmCalculaTotalPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLinhaHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal DevExpress.XtraGrid.Columns.GridColumn valor;
        internal DevExpress.XtraGrid.Columns.GridColumn data;
        internal DevExpress.XtraGrid.Columns.GridColumn cliente;
        internal DevExpress.XtraGrid.Columns.GridColumn pedido;
        internal DevExpress.XtraGrid.Views.Grid.GridView gvPedidos;
        internal DevExpress.XtraGrid.GridControl gcPedidos;
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
        private DevExpress.XtraEditors.DropDownButton btnFiltrar;
        internal System.Windows.Forms.CheckBox chkFiltroDemais;
        internal System.Windows.Forms.CheckBox chkFiltroMensal;
        internal System.Windows.Forms.CheckBox chkFiltroNaoExecutado;
        internal System.Windows.Forms.CheckBox chkFiltroNaoQuitado;
        private DevExpress.XtraEditors.DropDownButton btnX;
        internal System.Windows.Forms.CheckBox chkFiltroExecutado;
        private DevExpress.XtraEditors.TextEdit txtFiltrar;
        internal System.Windows.Forms.CheckBox chkFiltroQuitado;
        internal DevExpress.XtraCharts.ChartControl chartLinhaHistorico;
    }
}