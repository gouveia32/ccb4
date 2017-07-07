using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using Modelo;

namespace GUI.dialogo
{
    public partial class dlgSelecionaBordado : DevExpress.XtraEditors.XtraForm
    {
        public dlgSelecionaBordado()
        {
            InitializeComponent();
        }

        private void atalhoDadosDoBordado_Click(object sender, EventArgs e)
        {
            if (scBordado.Panel1Collapsed)
            {
                scBordado.Panel1Collapsed = false;
                CarregaDetalhes();
                this.Height = 500;
                this.Top = 50;
            }
            else
            {
                scBordado.Panel1Collapsed = true;
                this.Height = 260;
                this.Top = 50;
            }
        }

        private void CarregaDetalhes()
        {
            DataTable dt, dtPreco;
            int bordado_id;

            if (gvBordados.SelectedRowsCount < 1) return;
            bordado_id = Convert.ToInt32(gvBordados.GetDataRow(gvBordados.FocusedRowHandle).ItemArray[0]);

            BLLBordado bll = new BLLBordado();
            Bordado modelo = new Bordado();

            modelo = bll.CarregaModeloBordado(bordado_id);

            if (modelo.id != null)
            {
                txtId.Text = Convert.ToString (modelo.id);
                txtArquivo.Text = modelo.arquivo;
                txtDescricao.Text = modelo.descricao;
                txtPreco.Value = (double)modelo.preco;
                txtObs_publica.Text = modelo.obs_publica;
                txtObs_Restrita.Text = modelo.obs_restrita;
            }


            dtPreco = MySQL_Select(Conn, "Select clientes.id as id, " _
                               & "clientes.nome as cliente, " _
                               & "notas_especificas.valor as valor, " _
                               & "notas_especificas.data_atualizacao as data_atualizacao, " _
                               & "notas_especificas.obs as obs " _
                               & "From notas_especificas left Join clientes On notas_especificas.cliente_id = clientes.id " _
                               & "where notas_especificas.bordado_id=" & bordado_id)
            Dim r As Integer
            dgnotas.Rows.Clear()
            For r = 0 To dtPreco.Rows.Count - 1
                dgnotas.Rows.Add()
                dgnotas.Item(0, r).Value = dtPreco.Rows(r).Item("id")
                dgnotas.Item(1, r).Value = dtPreco.Rows(r).Item("cliente")
                dgnotas.Item(2, r).Value = dtPreco.Rows(r).Item("valor")
                dgnotas.Item(3, r).Value = dtPreco.Rows(r).Item("obs")
            Next

        End If
    }
    }
}