namespace GUI
{
    partial class frmPreferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreferencias));
            this.corCriacaoUrgente = new DevExpress.XtraEditors.ColorPickEdit();
            this.corCriacaoNormal = new DevExpress.XtraEditors.ColorPickEdit();
            this.corPedidoMensal = new DevExpress.XtraEditors.ColorPickEdit();
            this.corPedidoNormal = new DevExpress.XtraEditors.ColorPickEdit();
            this.Label11 = new System.Windows.Forms.Label();
            this.corTarefaSelecionada = new DevExpress.XtraEditors.ColorPickEdit();
            this.Label10 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtEmailNotificacao = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbNotificarEmail = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtEmailOrigem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtTelefone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label4 = new System.Windows.Forms.Label();
            this.intTempoAtualizaPedidos = new DevComponents.Editors.IntegerInput();
            this.Label6 = new System.Windows.Forms.Label();
            this.intTimeOut = new DevComponents.Editors.IntegerInput();
            this.LinhaIdLabel = new System.Windows.Forms.Label();
            this.btnPadraoCores = new DevComponents.DotNetBar.ButtonX();
            this.btnGravarPreferencias = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.corCriacaoUrgente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corCriacaoNormal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corPedidoMensal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corPedidoNormal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corTarefaSelecionada.Properties)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intTempoAtualizaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // corCriacaoUrgente
            // 
            this.corCriacaoUrgente.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.corCriacaoUrgente.Location = new System.Drawing.Point(567, 127);
            this.corCriacaoUrgente.Name = "corCriacaoUrgente";
            this.corCriacaoUrgente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.corCriacaoUrgente.Size = new System.Drawing.Size(50, 20);
            this.corCriacaoUrgente.TabIndex = 57;
            // 
            // corCriacaoNormal
            // 
            this.corCriacaoNormal.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.corCriacaoNormal.Location = new System.Drawing.Point(567, 101);
            this.corCriacaoNormal.Name = "corCriacaoNormal";
            this.corCriacaoNormal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.corCriacaoNormal.Size = new System.Drawing.Size(50, 20);
            this.corCriacaoNormal.TabIndex = 56;
            // 
            // corPedidoMensal
            // 
            this.corPedidoMensal.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.corPedidoMensal.Location = new System.Drawing.Point(567, 75);
            this.corPedidoMensal.Name = "corPedidoMensal";
            this.corPedidoMensal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.corPedidoMensal.Size = new System.Drawing.Size(50, 20);
            this.corPedidoMensal.TabIndex = 55;
            // 
            // corPedidoNormal
            // 
            this.corPedidoNormal.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.corPedidoNormal.Location = new System.Drawing.Point(567, 49);
            this.corPedidoNormal.Name = "corPedidoNormal";
            this.corPedidoNormal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.corPedidoNormal.Size = new System.Drawing.Size(50, 20);
            this.corPedidoNormal.TabIndex = 54;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(482, 134);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(89, 13);
            this.Label11.TabIndex = 44;
            this.Label11.Text = "Criação Urgente:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // corTarefaSelecionada
            // 
            this.corTarefaSelecionada.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.corTarefaSelecionada.Location = new System.Drawing.Point(567, 181);
            this.corTarefaSelecionada.Name = "corTarefaSelecionada";
            this.corTarefaSelecionada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.corTarefaSelecionada.Size = new System.Drawing.Size(50, 20);
            this.corTarefaSelecionada.TabIndex = 58;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(482, 108);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(83, 13);
            this.Label10.TabIndex = 42;
            this.Label10.Text = "Criação Normal:";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cancelar
            // 
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Location = new System.Drawing.Point(204, 12);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(90, 31);
            this.Cancelar.TabIndex = 53;
            this.Cancelar.TabStop = false;
            this.Cancelar.Text = "&Fechar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(482, 82);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(79, 13);
            this.Label9.TabIndex = 41;
            this.Label9.Text = "Pedido Mensal:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtEmailNotificacao);
            this.Panel1.Controls.Add(this.cbNotificarEmail);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.txtEmailOrigem);
            this.Panel1.Controls.Add(this.txtSenha);
            this.Panel1.Location = new System.Drawing.Point(28, 120);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(420, 138);
            this.Panel1.TabIndex = 52;
            // 
            // txtEmailNotificacao
            // 
            // 
            // 
            // 
            this.txtEmailNotificacao.Border.Class = "TextBoxBorder";
            this.txtEmailNotificacao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmailNotificacao.Location = new System.Drawing.Point(167, 36);
            this.txtEmailNotificacao.Name = "txtEmailNotificacao";
            this.txtEmailNotificacao.Size = new System.Drawing.Size(207, 21);
            this.txtEmailNotificacao.TabIndex = 27;
            this.txtEmailNotificacao.Text = "gouveia32@gmail.com";
            // 
            // cbNotificarEmail
            // 
            // 
            // 
            // 
            this.cbNotificarEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbNotificarEmail.Location = new System.Drawing.Point(20, 12);
            this.cbNotificarEmail.Name = "cbNotificarEmail";
            this.cbNotificarEmail.Size = new System.Drawing.Size(122, 23);
            this.cbNotificarEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNotificarEmail.TabIndex = 25;
            this.cbNotificarEmail.Text = "Notificar por Email";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(47, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(115, 13);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Email para notificação:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(90, 75);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 13);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Email Origem:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(120, 101);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 13);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Senha:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailOrigem
            // 
            // 
            // 
            // 
            this.txtEmailOrigem.Border.Class = "TextBoxBorder";
            this.txtEmailOrigem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmailOrigem.Location = new System.Drawing.Point(167, 73);
            this.txtEmailOrigem.Name = "txtEmailOrigem";
            this.txtEmailOrigem.Size = new System.Drawing.Size(207, 21);
            this.txtEmailOrigem.TabIndex = 27;
            this.txtEmailOrigem.Text = "pontofinobordados@gmail.com";
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.Border.Class = "TextBoxBorder";
            this.txtSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSenha.Location = new System.Drawing.Point(167, 99);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(127, 21);
            this.txtSenha.TabIndex = 27;
            this.txtSenha.Text = "POQW0101";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(482, 56);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(79, 13);
            this.Label8.TabIndex = 43;
            this.Label8.Text = "Pedido Normal:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefone
            // 
            // 
            // 
            // 
            this.txtTelefone.Border.Class = "TextBoxBorder";
            this.txtTelefone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefone.Location = new System.Drawing.Point(121, 328);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(410, 21);
            this.txtTelefone.TabIndex = 49;
            this.txtTelefone.Text = "Tel.: 79 3211-5232 / 79 3041-8914";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(458, 188);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(103, 13);
            this.Label7.TabIndex = 40;
            this.Label7.Text = "Tarefa Selecionada:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(59, 330);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(58, 13);
            this.lblTel.TabIndex = 46;
            this.lblTel.Text = "Telefones:";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNomeEmpresa
            // 
            // 
            // 
            // 
            this.txtNomeEmpresa.Border.Class = "TextBoxBorder";
            this.txtNomeEmpresa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNomeEmpresa.Location = new System.Drawing.Point(121, 276);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(410, 21);
            this.txtNomeEmpresa.TabIndex = 50;
            this.txtNomeEmpresa.Text = "Ponto Fino Bordados";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(33, 278);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(82, 13);
            this.Label5.TabIndex = 47;
            this.Label5.Text = "Nome Empresa:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndereco
            // 
            // 
            // 
            // 
            this.txtEndereco.Border.Class = "TextBoxBorder";
            this.txtEndereco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEndereco.Location = new System.Drawing.Point(121, 302);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(410, 21);
            this.txtEndereco.TabIndex = 51;
            this.txtEndereco.Text = "Rua José Luciano Siqueira, 335 - Suissa";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(59, 304);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 13);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "Endereço:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intTempoAtualizaPedidos
            // 
            // 
            // 
            // 
            this.intTempoAtualizaPedidos.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intTempoAtualizaPedidos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intTempoAtualizaPedidos.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intTempoAtualizaPedidos.Increment = 100;
            this.intTempoAtualizaPedidos.Location = new System.Drawing.Point(232, 94);
            this.intTempoAtualizaPedidos.Name = "intTempoAtualizaPedidos";
            this.intTempoAtualizaPedidos.ShowUpDown = true;
            this.intTempoAtualizaPedidos.Size = new System.Drawing.Size(80, 21);
            this.intTempoAtualizaPedidos.TabIndex = 38;
            this.intTempoAtualizaPedidos.Value = 60;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(25, 94);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(203, 13);
            this.Label6.TabIndex = 37;
            this.Label6.Text = "Tempo de atualização dos pedidos (seg):";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intTimeOut
            // 
            // 
            // 
            // 
            this.intTimeOut.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intTimeOut.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intTimeOut.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intTimeOut.Increment = 100;
            this.intTimeOut.Location = new System.Drawing.Point(232, 68);
            this.intTimeOut.Name = "intTimeOut";
            this.intTimeOut.ShowUpDown = true;
            this.intTimeOut.Size = new System.Drawing.Size(80, 21);
            this.intTimeOut.TabIndex = 39;
            this.intTimeOut.Value = 300;
            // 
            // LinhaIdLabel
            // 
            this.LinhaIdLabel.AutoSize = true;
            this.LinhaIdLabel.Location = new System.Drawing.Point(45, 68);
            this.LinhaIdLabel.Name = "LinhaIdLabel";
            this.LinhaIdLabel.Size = new System.Drawing.Size(183, 13);
            this.LinhaIdLabel.TabIndex = 36;
            this.LinhaIdLabel.Text = "Tempo de Espera para Logout (seg):";
            this.LinhaIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPadraoCores
            // 
            this.btnPadraoCores.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPadraoCores.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPadraoCores.Image = ((System.Drawing.Image)(resources.GetObject("btnPadraoCores.Image")));
            this.btnPadraoCores.Location = new System.Drawing.Point(485, 12);
            this.btnPadraoCores.Name = "btnPadraoCores";
            this.btnPadraoCores.Size = new System.Drawing.Size(132, 31);
            this.btnPadraoCores.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPadraoCores.TabIndex = 59;
            this.btnPadraoCores.Text = "Padrão de Cores";
            // 
            // btnGravarPreferencias
            // 
            this.btnGravarPreferencias.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGravarPreferencias.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGravarPreferencias.Image = ((System.Drawing.Image)(resources.GetObject("btnGravarPreferencias.Image")));
            this.btnGravarPreferencias.Location = new System.Drawing.Point(28, 12);
            this.btnGravarPreferencias.Name = "btnGravarPreferencias";
            this.btnGravarPreferencias.Size = new System.Drawing.Size(151, 31);
            this.btnGravarPreferencias.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGravarPreferencias.TabIndex = 45;
            this.btnGravarPreferencias.Text = "Gravar Preferências";
            this.btnGravarPreferencias.Click += new System.EventHandler(this.btnGravarPreferencias_Click);
            // 
            // frmPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 465);
            this.Controls.Add(this.btnPadraoCores);
            this.Controls.Add(this.corCriacaoUrgente);
            this.Controls.Add(this.corCriacaoNormal);
            this.Controls.Add(this.corPedidoMensal);
            this.Controls.Add(this.corPedidoNormal);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.corTarefaSelecionada);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnGravarPreferencias);
            this.Controls.Add(this.intTempoAtualizaPedidos);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.intTimeOut);
            this.Controls.Add(this.LinhaIdLabel);
            this.Name = "frmPreferencias";
            this.Text = "Preferências";
            this.Load += new System.EventHandler(this.frmPreferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corCriacaoUrgente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corCriacaoNormal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corPedidoMensal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corPedidoNormal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corTarefaSelecionada.Properties)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intTempoAtualizaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intTimeOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.ButtonX btnPadraoCores;
        public DevExpress.XtraEditors.ColorPickEdit corCriacaoUrgente;
        public DevExpress.XtraEditors.ColorPickEdit corCriacaoNormal;
        public DevExpress.XtraEditors.ColorPickEdit corPedidoMensal;
        public DevExpress.XtraEditors.ColorPickEdit corPedidoNormal;
        internal System.Windows.Forms.Label Label11;
        public DevExpress.XtraEditors.ColorPickEdit corTarefaSelecionada;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button Cancelar;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Panel Panel1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmailNotificacao;
        public DevComponents.DotNetBar.Controls.CheckBoxX cbNotificarEmail;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmailOrigem;
        public DevComponents.DotNetBar.Controls.TextBoxX txtSenha;
        internal System.Windows.Forms.Label Label8;
        public DevComponents.DotNetBar.Controls.TextBoxX txtTelefone;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lblTel;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNomeEmpresa;
        internal System.Windows.Forms.Label Label5;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEndereco;
        internal System.Windows.Forms.Label Label4;
        internal DevComponents.DotNetBar.ButtonX btnGravarPreferencias;
        public DevComponents.Editors.IntegerInput intTempoAtualizaPedidos;
        internal System.Windows.Forms.Label Label6;
        public DevComponents.Editors.IntegerInput intTimeOut;
        internal System.Windows.Forms.Label LinhaIdLabel;
    }
}