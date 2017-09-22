using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Modelo;
using BLL;

namespace GUI
{
    public partial class dlgCadastroCliente : DevExpress.XtraEditors.XtraForm
    {
        public Cliente modeloCliente;

        public dlgCadastroCliente()
        {
            InitializeComponent();
        }

        private void dlgCadastroCliente_Load(object sender, EventArgs e)
        {
            if (modeloCliente.id == 0)
            {
                txtCliente_Id.Text = "";
                txtNome.Text = "";
                txtContato_Funcao.Text = "";
                txtContato_Nome.Text = "";
                txtCgc_Cpf.Text = "";
                txtInscr_Estadual.Text = "";
                txtEndereco.Text = "";
                txtCidade.Text = "";
                txtEstado.Text = "";
                txtCEP.Text = "";
                txtTelefone1.Text = "";
                txtTelefone2.Text = "";
                txtTelefone3.Text = "";
                txtEmail.Text = "";
                txtObs.Text = "";
            }
            else
            {
                txtCliente_Id.Value = modeloCliente.id;
                txtNome.Text = modeloCliente.nome;
                txtContato_Funcao.Text = modeloCliente.contato_funcao;
                txtContato_Nome.Text = modeloCliente.contato_funcao;
                txtCgc_Cpf.Text = modeloCliente.cgc_cpf;
                txtInscr_Estadual.Text = modeloCliente.inscr_estadual;
                txtEndereco.Text = modeloCliente.endereco;
                txtCidade.Text = modeloCliente.cidade;
                txtEstado.Text = modeloCliente.estado;
                txtCEP.Text = modeloCliente.cep;
                txtTelefone1.Text = modeloCliente.telefone1;
                txtTelefone2.Text = modeloCliente.telefone2;
                txtTelefone3.Text = modeloCliente.telefone3;
                txtEmail.Text = modeloCliente.email;
                txtObs.Text = modeloCliente.obs;
            }
        }

        private void TelaParaModelo(Cliente modelo)
        {
            modelo.nome = txtNome.Text;
            modelo.contato_funcao = txtContato_Funcao.Text;
            modelo.contato_nome = txtContato_Nome.Text;
            modelo.cgc_cpf = txtCgc_Cpf.Text;
            modelo.inscr_estadual = txtInscr_Estadual.Text;
            modelo.endereco = txtEndereco.Text;
            modelo.cidade = txtCidade.Text;
            modelo.estado = txtEstado.Text;
            modelo.telefone1 = txtTelefone1.Text;
            modelo.telefone2 = txtTelefone2.Text;
            modelo.telefone3 = txtTelefone3.Text;
            modelo.email = txtEmail.Text;
            modelo.obs = txtObs.Text;
        }

        private void GravarRegistro()
        {
            int idAtual;

            try
            {
                //leitura dos dados
                TelaParaModelo(modeloCliente);

                //objeto para gravar os dados no bd
                ClienteBLL bll = new ClienteBLL();

                if (modeloCliente.id == 0)
                {
                    //cadastrar novo grupo
                    bll.Incluir(modeloCliente);
                    idAtual = modeloCliente.id;
                    MessageBox.Show("Cliente Inserido. Id=" + modeloCliente.id.ToString());
                }
                else
                {
                    //alerar um cliente
                    idAtual = txtCliente_Id.Value;
                    modeloCliente.id = idAtual;
                    bll.Altera(modeloCliente);
                    MessageBox.Show("Cliente alterado!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            GravarRegistro();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}