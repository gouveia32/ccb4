namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnTesteConexao = new DevComponents.DotNetBar.ButtonX();
            this.btnSalvar = new DevComponents.DotNetBar.ButtonX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbServidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ceBDTeste = new DevExpress.XtraEditors.CheckEdit();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Version = new System.Windows.Forms.Label();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceBDTeste.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Location = new System.Drawing.Point(42, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(260, 18);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Iniciando...";
            // 
            // picLogo
            // 
            this.picLogo.EditValue = ((object)(resources.GetObject("picLogo.EditValue")));
            this.picLogo.Location = new System.Drawing.Point(41, 11);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.AllowFocused = false;
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogo.Properties.ShowMenu = false;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picLogo.Properties.ZoomAccelerationFactor = 1D;
            this.picLogo.Size = new System.Drawing.Size(261, 70);
            this.picLogo.TabIndex = 8;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.ButtonImageCollapse = ((System.Drawing.Image)(resources.GetObject("expandablePanel1.ButtonImageCollapse")));
            this.expandablePanel1.ButtonImageExpand = ((System.Drawing.Image)(resources.GetObject("expandablePanel1.ButtonImageExpand")));
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Info;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.btnTesteConexao);
            this.expandablePanel1.Controls.Add(this.btnSalvar);
            this.expandablePanel1.Controls.Add(this.LabelX2);
            this.expandablePanel1.Controls.Add(this.tbUsuario);
            this.expandablePanel1.Controls.Add(this.tbServidor);
            this.expandablePanel1.Controls.Add(this.ceBDTeste);
            this.expandablePanel1.Controls.Add(this.LabelX3);
            this.expandablePanel1.Controls.Add(this.LabelX1);
            this.expandablePanel1.Controls.Add(this.tbSenha);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Expanded = false;
            this.expandablePanel1.ExpandedBounds = new System.Drawing.Rectangle(10, 12, 275, 159);
            this.expandablePanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.Location = new System.Drawing.Point(10, 12);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(26, 159);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.Style.WordWrap = true;
            this.expandablePanel1.TabIndex = 14;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Configurar";
            // 
            // btnTesteConexao
            // 
            this.btnTesteConexao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTesteConexao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTesteConexao.Location = new System.Drawing.Point(7, 112);
            this.btnTesteConexao.Name = "btnTesteConexao";
            this.btnTesteConexao.Size = new System.Drawing.Size(94, 23);
            this.btnTesteConexao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTesteConexao.TabIndex = 16;
            this.btnTesteConexao.Text = "Testar Conexão";
            this.btnTesteConexao.Click += new System.EventHandler(this.btnTesteConexao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalvar.Location = new System.Drawing.Point(173, 109);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX2.Location = new System.Drawing.Point(135, 34);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(49, 20);
            this.LabelX2.TabIndex = 12;
            this.LabelX2.Text = "Usuário";
            // 
            // tbUsuario
            // 
            // 
            // 
            // 
            this.tbUsuario.Border.Class = "TextBoxBorder";
            this.tbUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbUsuario.Location = new System.Drawing.Point(184, 34);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(64, 21);
            this.tbUsuario.TabIndex = 12;
            this.tbUsuario.TabStop = false;
            // 
            // tbServidor
            // 
            // 
            // 
            // 
            this.tbServidor.Border.Class = "TextBoxBorder";
            this.tbServidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbServidor.Location = new System.Drawing.Point(59, 34);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(73, 21);
            this.tbServidor.TabIndex = 11;
            this.tbServidor.TabStop = false;
            // 
            // ceBDTeste
            // 
            this.ceBDTeste.Location = new System.Drawing.Point(50, 63);
            this.ceBDTeste.Name = "ceBDTeste";
            this.ceBDTeste.Properties.Caption = "BD teste";
            this.ceBDTeste.Size = new System.Drawing.Size(75, 19);
            this.ceBDTeste.TabIndex = 14;
            this.ceBDTeste.TabStop = false;
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX3.Location = new System.Drawing.Point(137, 66);
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.Size = new System.Drawing.Size(41, 21);
            this.LabelX3.TabIndex = 13;
            this.LabelX3.Text = "Senha";
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(7, 34);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(53, 19);
            this.LabelX1.TabIndex = 10;
            this.LabelX1.Text = "Servidor";
            // 
            // tbSenha
            // 
            // 
            // 
            // 
            this.tbSenha.Border.Class = "TextBoxBorder";
            this.tbSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSenha.Location = new System.Drawing.Point(184, 66);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(64, 21);
            this.tbSenha.TabIndex = 13;
            this.tbSenha.TabStop = false;
            this.tbSenha.Text = "ebtaju1";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(231, 177);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(71, 30);
            this.Cancel.TabIndex = 20;
            this.Cancel.TabStop = false;
            this.Cancel.Text = "&Cancela";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(145, 177);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(202, 142);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(101, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "poqw01";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(202, 116);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(101, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "gouveia";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.InitialImage")));
            this.PictureBox1.Location = new System.Drawing.Point(42, 113);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(93, 94);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 21;
            this.PictureBox1.TabStop = false;
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.Gainsboro;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(173, 88);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(126, 18);
            this.Version.TabIndex = 22;
            this.Version.Text = "Versão:";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(145, 114);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(49, 20);
            this.labelX4.TabIndex = 26;
            this.labelX4.Text = "Usuário:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(145, 141);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(49, 20);
            this.labelX5.TabIndex = 26;
            this.labelX5.Text = "   Senha:";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 217);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.ShowInTaskbar = true;
            this.Text = "ccb4";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceBDTeste.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.LabelX LabelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUsuario;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServidor;
        public DevExpress.XtraEditors.CheckEdit ceBDTeste;
        private DevComponents.DotNetBar.LabelX LabelX3;
        private DevComponents.DotNetBar.LabelX LabelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSenha;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox txtSenha;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Version;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnSalvar;
        private DevComponents.DotNetBar.ButtonX btnTesteConexao;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}
