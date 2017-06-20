namespace GUI
{
    partial class CoolPrintPreviewDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolPrintPreviewDialog));
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._btnPrint = new System.Windows.Forms.ToolStripButton();
            this.cbImpressoras = new System.Windows.Forms.ToolStripComboBox();
            this._btnPageSetup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._btnZoom = new System.Windows.Forms.ToolStripSplitButton();
            this._itemActualSize = new System.Windows.Forms.ToolStripMenuItem();
            this._itemFullPage = new System.Windows.Forms.ToolStripMenuItem();
            this._itemPageWidth = new System.Windows.Forms.ToolStripMenuItem();
            this._itemTwoPages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this._item500 = new System.Windows.Forms.ToolStripMenuItem();
            this._item200 = new System.Windows.Forms.ToolStripMenuItem();
            this._item150 = new System.Windows.Forms.ToolStripMenuItem();
            this._item100 = new System.Windows.Forms.ToolStripMenuItem();
            this._item75 = new System.Windows.Forms.ToolStripMenuItem();
            this._item50 = new System.Windows.Forms.ToolStripMenuItem();
            this._item25 = new System.Windows.Forms.ToolStripMenuItem();
            this._item10 = new System.Windows.Forms.ToolStripMenuItem();
            this._separator = new System.Windows.Forms.ToolStripSeparator();
            this._btnCancel = new System.Windows.Forms.ToolStripButton();
            this._preview = new GUI.CoolPrintPreviewControl();
            this._toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolStrip
            // 
            this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnPrint,
            this.cbImpressoras,
            this._btnPageSetup,
            this.toolStripSeparator2,
            this._btnZoom,
            this._separator,
            this._btnCancel});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(350, 27);
            this._toolStrip.TabIndex = 0;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _btnPrint
            // 
            this._btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("_btnPrint.Image")));
            this._btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Size = new System.Drawing.Size(24, 24);
            this._btnPrint.Text = "Print Document";
            this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // cbImpressoras
            // 
            this.cbImpressoras.BackColor = System.Drawing.SystemColors.Info;
            this.cbImpressoras.Name = "cbImpressoras";
            this.cbImpressoras.Size = new System.Drawing.Size(137, 27);
            this.cbImpressoras.SelectedIndexChanged += new System.EventHandler(this.cbImpressoras_SelectedIndexChanged);
            // 
            // _btnPageSetup
            // 
            this._btnPageSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnPageSetup.Image = ((System.Drawing.Image)(resources.GetObject("_btnPageSetup.Image")));
            this._btnPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnPageSetup.Name = "_btnPageSetup";
            this._btnPageSetup.Size = new System.Drawing.Size(24, 24);
            this._btnPageSetup.Text = "Page Setup";
            this._btnPageSetup.Click += new System.EventHandler(this._btnPageSetup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // _btnZoom
            // 
            this._btnZoom.AutoToolTip = false;
            this._btnZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itemActualSize,
            this._itemFullPage,
            this._itemPageWidth,
            this._itemTwoPages,
            this.toolStripMenuItem1,
            this._item500,
            this._item200,
            this._item150,
            this._item100,
            this._item75,
            this._item50,
            this._item25,
            this._item10});
            this._btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("_btnZoom.Image")));
            this._btnZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnZoom.Name = "_btnZoom";
            this._btnZoom.Size = new System.Drawing.Size(75, 24);
            this._btnZoom.Text = "&Zoom";
            this._btnZoom.ButtonClick += new System.EventHandler(this._btnZoom_ButtonClick);
            this._btnZoom.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._btnZoom_DropDownItemClicked);
            // 
            // _itemActualSize
            // 
            this._itemActualSize.Image = ((System.Drawing.Image)(resources.GetObject("_itemActualSize.Image")));
            this._itemActualSize.Name = "_itemActualSize";
            this._itemActualSize.Size = new System.Drawing.Size(135, 22);
            this._itemActualSize.Text = "Actual Size";
            // 
            // _itemFullPage
            // 
            this._itemFullPage.Image = ((System.Drawing.Image)(resources.GetObject("_itemFullPage.Image")));
            this._itemFullPage.Name = "_itemFullPage";
            this._itemFullPage.Size = new System.Drawing.Size(135, 22);
            this._itemFullPage.Text = "Full Page";
            // 
            // _itemPageWidth
            // 
            this._itemPageWidth.Image = ((System.Drawing.Image)(resources.GetObject("_itemPageWidth.Image")));
            this._itemPageWidth.Name = "_itemPageWidth";
            this._itemPageWidth.Size = new System.Drawing.Size(135, 22);
            this._itemPageWidth.Text = "Page Width";
            // 
            // _itemTwoPages
            // 
            this._itemTwoPages.Image = ((System.Drawing.Image)(resources.GetObject("_itemTwoPages.Image")));
            this._itemTwoPages.Name = "_itemTwoPages";
            this._itemTwoPages.Size = new System.Drawing.Size(135, 22);
            this._itemTwoPages.Text = "Two Pages";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // _item500
            // 
            this._item500.Name = "_item500";
            this._item500.Size = new System.Drawing.Size(135, 22);
            this._item500.Text = "500%";
            // 
            // _item200
            // 
            this._item200.Name = "_item200";
            this._item200.Size = new System.Drawing.Size(135, 22);
            this._item200.Text = "200%";
            // 
            // _item150
            // 
            this._item150.Name = "_item150";
            this._item150.Size = new System.Drawing.Size(135, 22);
            this._item150.Text = "150%";
            // 
            // _item100
            // 
            this._item100.Name = "_item100";
            this._item100.Size = new System.Drawing.Size(135, 22);
            this._item100.Text = "100%";
            // 
            // _item75
            // 
            this._item75.Name = "_item75";
            this._item75.Size = new System.Drawing.Size(135, 22);
            this._item75.Text = "75%";
            // 
            // _item50
            // 
            this._item50.Name = "_item50";
            this._item50.Size = new System.Drawing.Size(135, 22);
            this._item50.Text = "50%";
            // 
            // _item25
            // 
            this._item25.Name = "_item25";
            this._item25.Size = new System.Drawing.Size(135, 22);
            this._item25.Text = "25%";
            // 
            // _item10
            // 
            this._item10.Name = "_item10";
            this._item10.Size = new System.Drawing.Size(135, 22);
            this._item10.Text = "10%";
            // 
            // _separator
            // 
            this._separator.Name = "_separator";
            this._separator.Size = new System.Drawing.Size(6, 27);
            this._separator.Visible = false;
            // 
            // _btnCancel
            // 
            this._btnCancel.AutoToolTip = false;
            this._btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("_btnCancel.Image")));
            this._btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(77, 24);
            this._btnCancel.Text = "Cancelar";
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _preview
            // 
            this._preview.AutoScroll = true;
            this._preview.AutoScrollMinSize = new System.Drawing.Size(0, 8);
            this._preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this._preview.Document = null;
            this._preview.Location = new System.Drawing.Point(0, 27);
            this._preview.Name = "_preview";
            this._preview.Size = new System.Drawing.Size(350, 464);
            this._preview.TabIndex = 1;
            this._preview.ZoomMode = GUI.ZoomMode.PageWidth;
            // 
            // CoolPrintPreviewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(350, 491);
            this.Controls.Add(this._preview);
            this.Controls.Add(this._toolStrip);
            this.Name = "CoolPrintPreviewDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visão da Impressão";
            this.Load += new System.EventHandler(this.CoolPrintPreviewDialog_Load);
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _btnPrint;
        private System.Windows.Forms.ToolStripButton _btnPageSetup;
        private CoolPrintPreviewControl _preview;
        private System.Windows.Forms.ToolStripSplitButton _btnZoom;
        private System.Windows.Forms.ToolStripMenuItem _itemActualSize;
        private System.Windows.Forms.ToolStripMenuItem _itemFullPage;
        private System.Windows.Forms.ToolStripMenuItem _itemPageWidth;
        private System.Windows.Forms.ToolStripMenuItem _itemTwoPages;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _item500;
        private System.Windows.Forms.ToolStripMenuItem _item200;
        private System.Windows.Forms.ToolStripMenuItem _item150;
        private System.Windows.Forms.ToolStripMenuItem _item100;
        private System.Windows.Forms.ToolStripMenuItem _item75;
        private System.Windows.Forms.ToolStripMenuItem _item50;
        private System.Windows.Forms.ToolStripMenuItem _item25;
        private System.Windows.Forms.ToolStripMenuItem _item10;
        private System.Windows.Forms.ToolStripSeparator _separator;
        private System.Windows.Forms.ToolStripButton _btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox cbImpressoras;
    }
}