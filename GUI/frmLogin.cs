using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Reflection;
using BLL;
using Modelo;
using DAL;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class frmLogin : SplashScreen
    {
        private fnParametros parametros = new fnParametros();

        public bool Logado { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
            this.Logado = false;
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion


        private void Cancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Version ver = Assembly.GetExecutingAssembly().GetName().Version;
            this.Version.Text = String.Format("Versão: {0}.{1}.{2}.{3}", ver.Major,ver.Minor, ver.Revision, ver.MinorRevision );

            txtSenha.Text = "";

            //Recupera dados do servidor no registro
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\ccb4");
            if ((key != null))
            {
                try
                {
                    tbServidor.Text = key.GetValue("MySqlServidor", "127.0.0.1").ToString();
                    tbUsuario.Text = key.GetValue("MySqlUsuario", "root").ToString();
                    tbSenha.Text = key.GetValue("MySqlSenha", "").ToString();
                    string database;
                    if (key.GetValue("BDteste", false).ToString() == "True" )
                    {
                        ceBDTeste.Checked = true;
                        database = "ccb2";
                        GUI.Properties.Settings.Default.BDTeste = true;
                    }
                    else
                    {
                        ceBDTeste.Checked = false;
                        database = "ccb";
                        GUI.Properties.Settings.Default.BDTeste = false;
                    }

                    txtUsuario.Text = key.GetValue("Usuario", "visitante").ToString();
                    ClassBD.StringDeConexao = 
                           string.Format("server={0:s};user id={1:s};password={2:s};database={3:s};port=3306;default command timeout=600;",
                                          tbServidor.Text, tbUsuario.Text, tbSenha.Text, database);
                    if (!TestaConexao())
                    {
                        epnlConfigurar.Expanded = true;
                        this.AcceptButton = btnSalvar;
                    }
                    else
                    {
                        //lblStatus.Text = "Conectado";
                    }
                }
                finally
                {
                    key.Close();
                }
            }
            else
            {
                epnlConfigurar.Expanded = true;
            }

            parametros.CarregaParametros(1); //Carrega os parametros do perfil 1 para Settings
            //ConectarBD();
            txtSenha.Focus();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BLLUsuario bllUsuario = new BLLUsuario();

            Usuario us = bllUsuario.CarregaUsuario(txtUsuario.Text, txtSenha.Text);

            try
            {
                bllUsuario.AcessoSistema(us);
                //MessageBox.Show("Acesso válido");
                this.Logado = true;
                GUI.Properties.Settings.Default.Usuario = txtUsuario.Text;
                GUI.Properties.Settings.Default.Conectado = true;
                this.DialogResult = DialogResult.OK;
                //this.Dispose();
                this.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Grava dados do servidor no registro
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\ccb4");
                try
                {
                    key.SetValue("MySqlServidor", tbServidor.Text);
                    key.SetValue("MySqlUsuario", tbUsuario.Text);
                    key.SetValue("MySqlSenha", tbSenha.Text);
                    key.SetValue("BDteste", ceBDTeste.Checked);
                    string database;
                    if (key.GetValue("BDteste", false).ToString() == "True")
                    {
                        ceBDTeste.Checked = true;
                        database = "ccb2";
                        GUI.Properties.Settings.Default.BDTeste = true;
                    }
                    else
                    {
                        ceBDTeste.Checked = false;
                        database = "ccb";
                        GUI.Properties.Settings.Default.BDTeste = false;
                    }

                    epnlConfigurar.Expanded = false;
                    ClassBD.StringDeConexao =
                           string.Format("server={0:s};user id={1:s};password={2:s};database={3:s};port=3306;default command timeout=600;",
                                          tbServidor.Text, tbUsuario.Text, tbSenha.Text, database);
                    TestaConexao();
                }
                finally
                {
                    key.Close();
                    txtSenha.Focus();
                }
            }

        }

        private bool TestaConexao()
        {
            try
            {
                if (ceBDTeste.Checked)
                    ClassBD.banco = "ccb2";
                else
                    ClassBD.banco = "ccb";

                ClassBD.servidor = tbServidor.Text;
                ClassBD.usuario = tbUsuario.Text;
                ClassBD.senha = tbSenha.Text;
                ClassBD.StringDeConexao =
                     string.Format("server={0:s};user id={1:s};password={2:s};database={3:s};port=3306;default command timeout=600;",
                      tbServidor.Text, tbUsuario.Text, tbSenha.Text, ClassBD.banco);

                //testar a conexao
                ClassBD db = new ClassBD();
                db.TestarConexao();
                lblStatus.Text = "Conectado (" + ClassBD.banco + ")";
                lblStatus.ForeColor  = Color.Green;

                this.AcceptButton = btnOK;
                return true;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                                "Verifique os dados informados");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
            lblStatus.Text = "Não Conectado";
            lblStatus.ForeColor = Color.Red;
            this.AcceptButton = btnSalvar;
            return false;
        }

        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            if (TestaConexao())
                MessageBox.Show("Conexão efetuada com sucesso");
        }
    }
}