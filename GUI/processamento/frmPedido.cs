using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmPedido : GUI.frmModeloCadastro
    {
        DateTime _start;
        int _page = 0;
        //Font _font = new Font("Segoe UI", 14);
        Font _font = new Font("Courier New", 10);
        public int OpcaoImpressao = 1; //1=Cupom, 2=Protocolo
        int UltimoItem;
        DateTime UltimaDataEntrega = Convert.ToDateTime("01/01/01");
        bool mPodeAlterar = false;
        DataTable dtItens;

        frmPrincipal fp;
        private fnLocalizar loc = new fnLocalizar();

        public frmPedido(frmPrincipal _fp)
        {
            InitializeComponent();
            fp = _fp;
        }

        private void LimpaTela(bool Limpa_Pedido)
        {
            Bitmap bit = new Bitmap(picBordado.Width, picBordado.Height);
            Graphics g = Graphics.FromImage(bit);

            mPodeAlterar = false;

            if (Limpa_Pedido)
            {
                deFechamento.EditValue = null;
                deAbertura.EditValue = DateTime.Now;
                if (UltimaDataEntrega == Convert.ToDateTime("01/01/01"))
                    dtpData_Entrega.Value = Convert.ToDateTime(String.Format("{0:dd/MM/yyyy} 16:00", DateTime.Now.AddDays(1)));
                else
                    dtpData_Entrega.Value = Convert.ToDateTime(String.Format("{0:dd/MM/yyyy} 16:00", UltimaDataEntrega));

                txtId.Text = "";
                cbCliente.Text = "";
                lblTelefone.Text = "";
                cbEmpregado.Text = "";
                //depPagamento.Text = "";
                Adicional.Value = 0;
                txtDesconto.Value = 0;
                txtAmortizacao.Value = 0;
                txtTotal_Pedido.Text = "0.00";
                txtObs_Pedido.Text = "";
                txtObs_Pagamento.Text = "";
                dtpData_Execucao.Text = "";
                rg_lado.SelectedIndex = -1;
                rg_local.SelectedIndex = -1;
                ckbPAGO.Checked = false;
                cbQuitado.Checked = false;
                chkMensal.Checked = false;
                chkExecutado.Checked = false;
                //dgItens.Rows.Clear();
            }

            nudBordado_Id.Text = "";
            txtBordado_Arquivo.Text = "";
            txtBordado_Descricao.Text = "";
            txtObs_Item.Text = "";
            txtBordado_Pontos.Text = "0";
            txtPontos_Extras.Text = "0";
            txtTotal_Pontos.Text = "0";
            txtBordado_Preco.Text = "0.00";
            txtPC_Solicitadas.Text = "0";
            txtPC_Entregues.Text = "0";
            txtPC_Defeito.Text = "0";
            txtPC_Nao_Bordadas.Text = "0";
            txtPreco_Por_Peca.Text = "0.00";
            txtTotal_Item.Text = "0.00";
            //dtpData_Entrega.Value = dtpAbertura.Value;

            g.Clear(picBordado.BackColor); //limpa com a cor de fundo
            picBordado.Image = bit;
            mPodeAlterar = true;
        }

        private void PedidoTelaParaModelo(Pedido modelo)
        {
            if (txtId.Text != "") modelo.id = Convert.ToInt32(txtId.Text);
            modelo.data_abertura = Convert.ToDateTime(deAbertura.EditValue);
            modelo.data_fechamento = Convert.ToDateTime(deFechamento.EditValue);
            modelo.data_pagamento = Convert.ToDateTime(dePagamento.EditValue);

            //Captura cliente_id do combobox
            var row = (DataRowView)cbCliente.SelectedItem;
            modelo.cliente_id = Convert.ToInt32(row[0]);

            modelo.mensal = chkMensal.Checked;
            modelo.pago_antecipado = ckbPAGO.Checked;
            modelo.desconto = txtDesconto.Value;
            modelo.pago = txtAmortizacao.Value;
            modelo.executado = chkExecutado.Checked;

            modelo.obs_pedido = txtObs_Pedido.Text;
        }

        private void PedidoModeloParaTela(Pedido modelo)
        {
            txtId.Text = modelo.id.ToString();
            deAbertura.EditValue = modelo.data_abertura;
            deFechamento.EditValue = modelo.data_fechamento;
            dePagamento.EditValue = modelo.data_pagamento;
            cbCliente.Text = modelo.Cliente.nome;
            lblTelefone.Text = modelo.Cliente.telefone1;
            chkMensal.Checked = modelo.mensal;
            ckbPAGO.Checked = modelo.pago_antecipado;
            txtAmortizacao.Value = modelo.pago;
            txtDesconto.Value = modelo.desconto;
            txtObs_Pedido.Text = modelo.obs_pedido;
            //lblContato.Text = modelo.Cliente.telefone1;
        }

        private void ItemModeloParaTela(Item item)
        {
            if (item.Bordado == null) return;
            mPodeAlterar = true;
            nudBordado_Id.Value = item.Bordado.id;
            txtBordado_Arquivo.Text = item.Bordado.arquivo;
            txtBordado_Descricao.Text = item.Bordado.descricao;
            txtDescricao.Text = item.descricao;
            txtBordado_Pontos.Text = item.Bordado.pontos.ToString();
            txtBordado_Preco.Text = item.Bordado.preco.ToString();
            rg_local.SelectedIndex = item.local_id;
            rg_lado.SelectedIndex = item.lado;

            txtObs_Item.Text = item.obs;

            txtPC_Solicitadas.Value = txtPC_Bordadas.Value = item.pc_solicitadas;
            txtPreco_Por_Peca.Value = item.preco_por_peca;
            txtTotal_Item.Text = (item.pc_entregues * item.preco_por_peca).ToString();


            dtpData_Entrega.Value = Convert.ToDateTime(item.data_entrega);
            //Carrega a Imagem
            byte[] img = (byte[])item.Bordado.imagem;

            if (img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                picBordado.Image = Image.FromStream(ms);
                ms.Dispose();
            }
            mPodeAlterar = true;
        }

        private void ItemTelaParaModelo(Item item)
        {
            item.pedido_id = Convert.ToInt32(txtId.Text);
            item.bordado_id = nudBordado_Id.Value;
            item.obs = txtObs_Item.Text;
            item.local_id = rg_local.SelectedIndex;
            item.lado = rg_lado.SelectedIndex;
            item.pc_solicitadas = Convert.ToInt32(txtPC_Solicitadas.Text);
            item.preco_por_peca = Convert.ToDouble(txtPreco_Por_Peca.Text);
        }

        private void ItemTelaParaGrade(int row)
        {
            if (row < 0) return;

            if (gvItens.RowCount > row && mPodeAlterar)
            {
                gvItens.SetRowCellValue(row,"bordado_id",nudBordado_Id.Value);
                gvItens.SetRowCellValue(row, "colPc_solicitadas", txtPC_Solicitadas.Value);
                gvItens.SetRowCellValue(row, "preco", txtPreco_Por_Peca.Value);

                //dgItensO.Rows[row].Cells["qtde"].Value = txtPC_Solicitadas.Value;
                //dgItensO.Rows[row].Cells["preco"].Value = txtPreco_Por_Peca.Value;
                //dgItensO.Rows[row].Cells["Tot_item"].Value =
                txtTotal_Item.Value = 
                       txtPC_Solicitadas.Value * txtPreco_Por_Peca.Value;
                //dgItensO.Rows[row].Cells["data_entrega"].Value = dtpData_Entrega.Value;
                //dgItensO.Rows[row].Cells["descricao"].Value = txtDescricao.Text;
                //dgItensO.Rows[row].Cells["obs"].Value = txtObs_Item.Text;
                //dgItensO.Rows[row].Cells["local_id"].Value = rg_local.SelectedIndex;
                //dgItensO.Rows[row].Cells["lado"].Value = rg_lado.SelectedIndex;
                //dgItensO.Rows[row].Cells["pc_solicitadas"].Value = Convert.ToInt32(txtPC_Solicitadas.Value);
                //dgItensO.Rows[row].Cells["preco"].Value = Convert.ToDouble(txtPreco_Por_Peca.Value);
            }
        }

        private void ItensTelaParaModelo(ItemCollection modelo)
        {

            //Gruarda informações do ítem selecionado da tela para a grade
            //ItemTelaParaGrade(dgItens.CurrentRow.Index);
            //Itens
            //modelo.Clear();  //limpa inicialmente
            for (int i = 0; i < gvItens.DataRowCount; i++)
            {
                DataRow row = gvItens.GetDataRow(i);
                Item item = new Item();

                if (txtId.Text != "") item.pedido_id = Convert.ToInt32(txtId.Text);
                item.bordado_id = Convert.ToInt32 (row[21]); 
                item.item = Convert.ToInt32(row[0]);
                item.pc_entregues =
                item.pc_solicitadas =
                    Convert.ToInt32(row[3]);
                item.preco_por_peca = Convert.ToDouble(row[4]);
                item.data_entrega = Convert.ToDateTime(row[2]);
                item.descricao = Convert.ToString(row[1]);
                item.obs = Convert.ToString(row[20]);

                modelo.Add(item);
            }
        }

        private void ItensModeloParaTela(ItemCollection modelo)
        {
            int tot_pecas = 0;
            Double tot_valor = 0;

           
           // dgItensO.Rows.Clear();
            foreach (Item item in modelo)
            {
                //dgItensO.Rows.Add();
                //dgItensO.Rows[dgItensO.RowCount - 1].Cells["item"].Value = item.item;
                //dgItensO.Rows[dgItensO.RowCount - 1].Cells[1].Value = item.descricao;
                //dgItensO.Rows[dgItensO.RowCount - 1].Cells[2].Value = item.data_entrega;
                //dgItensO.Rows[dgItensO.RowCount - 1].Cells[3].Value = item.pc_entregues;
                //dgItensO.Rows[dgItensO.RowCount - 1].Cells[4].Value = item.preco_por_peca;
                //dgItensO.Rows[dgItensO.RowCount - 1].Cells[5].Value = item.Subtotal;
                //dgItensO.Rows[dgItensO.RowCount - 1].Cells[13].Value = item.local_id;
                //dgItensO.Rows[dgItensO.RowCount - 1].Cells[14].Value = item.lado;
                //dgItensO.Rows[dgItensO.RowCount - 1].Cells[20].Value = item.obs;

                tot_pecas += item.pc_entregues;
                tot_valor += item.Subtotal;
            }

            txtTot_Pecas.Text = Convert.ToString(tot_pecas);
            //txtQtde_Itens.Text = Convert.ToString(dgItensO.RowCount);
            txtTotal_Pedido.Text = Convert.ToString(tot_valor);

            if (ckbPAGO.Checked)
            {
                txtTot_a_pagar.Value = 0;
            }
            else
            {
                txtTot_a_pagar.Value = tot_valor -
                    Convert.ToDouble(txtAmortizacao.Text) -
                    txtDesconto.Value;
            }

            // dados do primeiro item
            BLLItem bll = new BLLItem();
            Item item1 = new Item();
            //if (dgItensO.RowCount > 0)
            //{
                //item1 = bll.CarregaItemDoPedido(Convert.ToInt32(txtId.Text),
                //                           Convert.ToInt32(dgItensO.Rows[0].Cells[0].Value));
                //ItemModeloParaTela(item1);
            //}

            //mPodeAlterar = true;
            //rg_local.SelectedIndex = item1.local_id; 
        }

        private void CalculaTotais()
        {
            int tot_pecas = 0;
            Double tot_valor = 0;

            if (dtItens == null) return;
            //primeiro guarda os dados da tela na grid
            //ItemTelaParaGrade(dgItens.CurrentRow.Index);
            foreach (DataRow row in dtItens.Rows)
            {
                if (row.RowState != DataRowState.Added) // se não for nova
                {
                    tot_pecas += Convert.ToInt32(row.ItemArray[6].ToString());
                    tot_valor += Convert.ToDouble(row.ItemArray[8]);
                }

            }
            txtTot_Pecas.Value = tot_pecas;
            txtQtde_Itens.Text = Convert.ToString(gvItens.RowCount);
            txtTotal_Pedido.Value = (tot_valor - txtDesconto.Value);
            txtPC_Bordadas.Value = txtPC_Solicitadas.Value;
            if (ckbPAGO.Checked)
            {
                txtTot_a_pagar.Value = 0;
            }
            else
            {
                txtTot_a_pagar.Value = tot_valor -
                Convert.ToDouble(txtAmortizacao.Text) -
                txtDesconto.Value;
            }
        }

        /// <Carrega os registros que obedecem filtro>
        /// 
        /// </summary>
        /// <param name="Posicionar_id"></param>

        private void Filtrar(int Posicionar_id = 0)
        {
            string filtro = "";
            // Warning!!! Optional parameters not supported
            fp.MostraAgaurde("Aguarde", "Carregando dados...");

            if (chkFiltroCliente.Checked)
            {
                filtro = ("clientes.nome=\'" + (cbFiltroCliente.Text + "\' "));
            }

            if ((chkFiltroNaoQuitado.Checked == true))
            {
                if ((chkFiltroQuitado.Checked == false))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Quitado='0' ";
                    }
                    else
                    {
                        filtro += "And Quitado='0' ";
                    }
                }
            }

            if ((chkFiltroNaoQuitado.Checked == false))
            {
                if ((chkFiltroQuitado.Checked == true))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Quitado='1' ";
                    }
                    else
                    {
                        filtro += "And Quitado='1' ";
                    }
                }
            }

            if ((chkFiltroNaoExecutado.Checked == true))
            {
                if ((chkFiltroExecutado.Checked == false))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Executado='0' ";
                    }
                    else
                    {
                        filtro += "And Executado='0' ";
                    }
                }
            }

            if ((chkFiltroNaoExecutado.Checked == false))
            {
                if ((chkFiltroExecutado.Checked == true))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Executado='1' ";
                    }
                    else
                    {
                        filtro += "And Executado='1' ";
                    }
                }
            }

            if ((chkFiltroDemais.Checked == true))
            {
                if ((chkFiltroMensal.Checked == false))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Mensal='0' ";
                    }
                    else
                    {
                        filtro += "And Mensal='0' ";
                    }
                }
            }

            if ((chkFiltroDemais.Checked == false))
            {
                if ((chkFiltroMensal.Checked == true))
                {
                    if ((filtro == ""))
                    {
                        filtro = "Mensal='1' ";
                    }
                    else
                    {
                        filtro += "And Mensal='1' ";
                    }
                }
            }

            BLLPedido bll = new BLLPedido();
            if (filtro == "")
                dgRegistros.DataSource = bll.Filtrar(txtFiltrar.Text, "");
            else
                if (txtFiltrar.Text == "")
                dgRegistros.DataSource = bll.Filtrar("", filtro);
            else
                dgRegistros.DataSource = bll.Filtrar(txtFiltrar.Text, filtro);

            if (Posicionar_id > 0)
            {
                loc.Localizar(gvRegistros, "id=" + Posicionar_id.ToString(), 0, true, false);
                CarregaPedidoAtual(Posicionar_id);
            }
            else
            {
                if (gvRegistros.RowCount > 0) ExibeItens(0);
            }
            if (txtFiltrar.Text == "")
            {
                fp.sbRegistros.Caption = String.Format("{0} registros", gvRegistros.RowCount);
                btnX.Visible = false;
            }
            else
            {
                fp.sbRegistros.Caption = String.Format("{0} registros (filtrado)", gvRegistros.RowCount);
                btnX.Visible = true;
            }

            fp.OcultaAguarde();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            scc1.SplitterPosition = btnFiltrar.Location.X + btnFiltrar.Size.Width;
            scc1.Panel2.Enabled = true;

            //CarregaCombo cbCliente
            BLLCliente c = new BLLCliente();
            cbCliente.DataSource = c.Filtrar("");
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";


            //Carrega cbFiltroCliente
            cbFiltroCliente.Items.Clear();
            foreach (DataRowView item in cbCliente.Items)
            {
                cbFiltroCliente.Items.Add(item.Row.ItemArray[1]);
            }

            //CarregaCombo rg_local
            BLLLocal l = new BLLLocal();
            DataTable dt = l.Filtrar("");
            if (dt.Rows.Count > 0)
            {
                for (int r = 0; r < dt.Rows.Count - 1; r++)
                    rg_local.Properties.Items.Add(new RadioGroupItem(dt.Rows[r].ItemArray[0],
                        Convert.ToString(dt.Rows[r].ItemArray[1])));
            }

            Filtrar();

            gvRegistros.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gvRegistros.Columns[0].Width = 50;
            gvRegistros.Columns[1].Width = 125;
            gvRegistros.Columns[2].Width = 90;
            gvRegistros.Columns[3].Visible = false;
            if (gvItens.RowCount > 0) Carrega_Item(0); // mostra 1o item
        }

        private void CarregaPedidoAtual(int pedido_id)
        {
            BLLPedido bll = new BLLPedido();
            Pedido modelo = bll.CarregaPedido(pedido_id);
            PedidoModeloParaTela(modelo);

            //Carrega itens
            BLLItem bllItem = new BLLItem();
            ItemCollection itemCollection = bllItem.CarregaItensDoPedido(modelo.id);
            dgItens.DataSource = itemCollection;
            ItensModeloParaTela(itemCollection);

            //alterabotoes(1);
        }

        private void btnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
        }

        private void ExibeItens(int row)
        {
            if (row >= 0)
            {
                BLLPedido bll = new BLLPedido();
                Pedido modelo = bll.CarregaPedido(Convert.ToInt32(gvRegistros.GetDataRow(row).ItemArray[0]));
                PedidoModeloParaTela(modelo);
                //alterabotoes(1);

                //Carrega itens
                BLLItem bllItem = new BLLItem();

                dtItens = bllItem.ItensDoPedido(modelo.id);
                dgItens.DataSource = dtItens;
            }
        }

       private void Carrega_Item (int row)
        {
            if (row >= 0)
            {
                BLLItem bll = new BLLItem();
                Bordado bordado = new Bordado();
                Item item = new Item(bordado);
                if (txtId.Text == "")
                {
                    LimpaTela(false);
                }
                else
                {
                    item = bll.CarregaItemDoPedido(Convert.ToInt32(txtId.Text),
                               Convert.ToInt32(gvItens.GetDataRow(row).ItemArray[3]));
                    ItemModeloParaTela(item);
                }
            }
        }

        private void dgItens_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (UltimoItem != e.RowIndex) Carrega_Item(e.RowIndex);
            UltimoItem = e.RowIndex;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void txtFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Filtrar();
            if (e.KeyChar == 27) btnX_Click(sender, e);
        }

        private void btnAlterar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
            Filtrar();
            btnX.Visible = false;
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Aguarde", "Carregando...");

            frmImprimePedido report = new frmImprimePedido(Convert.ToInt32(txtId.Text));

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print Preview form modally, 
                // and load the report document into it.
                printTool.ShowPreviewDialog();
            }
        }

        private void btnLocalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loc.Localizar(gvRegistros, Convert.ToString(txtLocalizar.EditValue), 0, true);
        }

        private void btnAnterior_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string txtProcurar = Convert.ToString(txtLocalizar.EditValue);

            if (txtProcurar == "")
            {
                //txtLocalizar.Focus();
                return;
            }
            loc.Localizar(gvRegistros, txtProcurar, gvRegistros.FocusedRowHandle - 1, false);
        }

        private void btnProxima_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string txtProcurar = Convert.ToString(txtLocalizar.EditValue);

            if (txtProcurar == "")
            {
                //txtLocalizar.Focus();
                return;
            }
            loc.Localizar(gvRegistros, txtProcurar, gvRegistros.FocusedRowHandle + 1, true);
        }

        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loc.Localizar(gvRegistros, (sender as TextEdit).Text, 0, true);
        }

        private void btnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Filtrar();
        }

        private void tnImprimirCupom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpcaoImpressao = 1;
            using (var dlg = new CoolPrintPreviewDialog())
            {
                dlg.Document = this.printDocument1;
                dlg.ShowDialog(this);
            }
        }

        void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _start = DateTime.Now;
            _page = 0;
        }

        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            switch (OpcaoImpressao)
            {
                case 1:
                    MontaCupom(e);
                    break;
                case 2:
                    MontaProtocolo(e);
                    break;
            }

            // move on to next page
            _page++;
            //e.HasMorePages = _page < 10;
        }


        //   void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //   {
        //MessageBox.Show (String.Format("Document rendered in {0} ms", DateTime.Now.Subtract(_start).TotalMilliseconds));
        // }

        private void btnProtocolo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpcaoImpressao = 2;
            using (var dlg = new CoolPrintPreviewDialog())
            {
                dlg.Document = this.printDocument1;
                dlg.ShowDialog(this);
            }
        }

        //-----------------------------------------------------------------------------------------
        private string Truncate(string value, int maxLength)
        {
            return string.IsNullOrEmpty(value) ? value : value.Substring(0, Math.Min(value.Length, maxLength));
        }

        //-----------------------------------------------------------------------------------------
        #region  ** Layout da impressao


        List<string> SplitString(int chunk, string input)
        {
            List<string> list = new List<string>();
            int cycles = input.Length / chunk;

            if (input.Length % chunk != 0)
                cycles++;

            for (int i = 0; i < cycles; i++)
            {
                try
                {
                    list.Add(input.Substring(i * chunk, chunk));
                }
                catch
                {
                    list.Add(input.Substring(i * chunk));
                }
            }
            return list;
        }

        void MontaCupom(System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Carrega parametros
            BLLParametros param = new BLLParametros();
            Parametros modelo = param.CarregaModeloParametros(1);

            // fill page with text
            Rectangle rc = e.MarginBounds;
            rc.Height = _font.Height + 10;


            int ln = 1;
            int col = 2;

            DateTime? Data_Entrega = default(DateTime);
            int qtde = 0;
            int totItens = 0;
            int RegAtual;
            Decimal Valor = 0.0M;
            Decimal totValor = 0.0M;

            Graphics g = e.Graphics;
            //g.FillRectangle(new SolidBrush(Color.Yellow), 0, 0, 340, e.MarginBounds.Height);

            //g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality

            Font fonteTiket = new Font("Courier New", 10, System.Drawing.GraphicsUnit.Point);

            //'g.DrawImage(Image.FromFile(Application.StartupPath & "\PF_Sem_Tel_450_138.bmp"), col, ln)

            g.DrawString(modelo.NomeEmpresa, fonteTiket, Brushes.Black, col + 5, ln);
            ln += 15;
            g.DrawString(modelo.endereco, fonteTiket, Brushes.Black, col + 5, ln);
            ln += 15;
            g.DrawString(modelo.telefone, fonteTiket, Brushes.Black, col + 5, ln);
            ln += 25;
            //g.DrawString(" *** TICKET DE VENDA ***", fonteTitulo, Brushes.Black, 32, ln)
            //ln += 30
            //g.DrawString("PEDIDO:", fonteTiket, Brushes.Black, col, ln)
            string p = string.Format("{0,0:000000}", txtId.Text);
            string np = "";
            foreach (char c in p)
            {
                np += c + " ";
            }
            g.DrawString(string.Format("PEDIDO: ** {0:s}**            DATA:{1:dd/MM/yyyy}", np, DateTime.Now), fonteTiket, Brushes.Black, col, ln);
            //g.DrawString("Data:" & Format(Now(), "dd/MM/yyyy"), fonteTiket, Brushes.Black, col + 190, ln - 5)
            ln += 15;
            //                      1         2         3         4
            //             12345678901234567890123456789012345678901234567890
            g.DrawString("------------------------------------------------", fonteTiket, Brushes.Black, col, ln);
            ln += 18;
            g.DrawString("CLIENTE: " + Truncate(cbCliente.Text, 39), fonteTiket, Brushes.Black, col, ln);
            ln += 15;
            g.DrawString("   Tel.: " + lblTelefone.Text, fonteTiket, Brushes.Black, col, ln);
            ln += 15;
            g.DrawString("------------------------------------------------", fonteTiket, Brushes.Black, col, ln);
            ln += 15;
            g.DrawString("ÍTEM DESCRIÇÃO              QTD VALOR      TOTAL", fonteTiket, Brushes.Black, col, ln);
            ln += 15;

            RegAtual = 0;
            foreach (DataRow row in dtItens.Rows)
            {
                Data_Entrega = Convert.ToDateTime(row.ItemArray[5]);
                qtde = Convert.ToInt32(row.ItemArray[6]);
                totItens += qtde;
                Valor = Convert.ToDecimal(row.ItemArray[8]);
                totValor += Valor;
                g.DrawString(string.Format("{0,3:D}  {1,-22:s} {2,3:D} {3,5:0.00} {4,10:0.00}",
                    Convert.ToInt32(row.ItemArray[3]),
                    Truncate(Convert.ToString(row.ItemArray[4]), 22),
                    qtde,
                    Convert.ToDecimal(row.ItemArray[7]),
                    Convert.ToDecimal(row.ItemArray[8])), fonteTiket, Brushes.Black, col, ln);

                int lo, ld;
                string linha;
                string[] mLado = { "Esq", "Dir" };

                object o = row.ItemArray[9];
                lo = Convert.ToInt32(o == null ? "" : row.ItemArray[9]);
                o = row.ItemArray[10];
                ld = Convert.ToInt32(o == null ? "" : row.ItemArray[10]);

                linha = "";
                if (lo != -1)
                {
                    linha = "     Local:" + rg_local.Properties.Items[lo].Description + "  ";
                }
                if (ld != -1)
                {
                    linha += "Lado:" + mLado[ld];
                }
                if (!string.IsNullOrEmpty(linha))
                {
                    ln += 15;
                    g.DrawString(linha, fonteTiket, Brushes.Black, col, ln);
                }
                linha = Convert.ToString(row.ItemArray[11]);
                string[] aLinhas = linha.Split(new[] { '\n', '\t' });
                int i, j;
                for (i = 0; i < aLinhas.Length; i++)
                {
                    if (aLinhas[i] != "")
                    {
                        //ln += 15;
                        //g.DrawString("   => ", fonteTiket, Brushes.Black, col, ln);
                        List<string> lista = SplitString(43, aLinhas[i]);

                        for (j = 0; j < lista.Count; j++)
                        {
                            ln += 15;
                            g.DrawString("     " + lista[j], fonteTiket, Brushes.Black, col, ln);
                        }
                        ln += 15;
                        //ln += ((aLinhas.Length - 1) * 12);
                    }

                }

                ln += 20;
                RegAtual += 1;
            }

            Decimal d;

            if (txtDesconto.Value != 0)
            {
                d = Convert.ToDecimal(txtDesconto.Text);
                g.DrawString(String.Format("Desconto:{0,10:0.#0}", d * -1), fonteTiket, Brushes.Black, col + 250, ln);
                totValor -= d;
                ln += 15;
            }
            g.DrawString("------------------------------------------------", fonteTiket, Brushes.Black, col, ln);
            ln += 15;
            g.DrawString(String.Format("                 Total => {0,5:D}       {1,10:0.#0}", totItens, totValor), fonteTiket, Brushes.Black, col, ln);
            ln += 15;

            if (ckbPAGO.Checked)
            {
                ln += 15;
                g.DrawString(String.Format("*** P A G O ***"), fonteTiket, Brushes.Black, col + 100, ln);
                ln += 35;
            }
            else
            {
                if (txtAmortizacao.Value != 0)
                {
                    d = Convert.ToDecimal(txtAmortizacao.Text);
                    g.DrawString(String.Format("                 Pagamento Antecipado:{0,10:0.#0}", d), fonteTiket, Brushes.Black, col, ln);
                    totValor -= d;
                    ln += 15;
                }

                g.DrawString("                              ------------------", fonteTiket, Brushes.Black, col, ln);
                ln += 10;
                g.DrawString(String.Format("                     Valor a Pagar => {0,10:0.#0}", totValor), fonteTiket, Brushes.Black, col, ln);
                ln += 30;
            }
            Data_Entrega = dtpData_Entrega.Value; //primeiro ítem
            g.DrawString(String.Format(" Entrega:{0:dd/MM/yyyy(ddd)} a partir de {1:HH:mm}", Data_Entrega, Data_Entrega), fonteTiket, Brushes.Black, col, ln);
            ln += 45;
            g.DrawString("__________________________________", fonteTiket, Brushes.Black, col + 45, ln);
            ln += 15;
            g.DrawString("                 ATENDENTE", fonteTiket, Brushes.Black, col, ln);
            ln += 35;
            g.DrawString("================================================", fonteTiket, Brushes.Black, col, ln);
            ln += 15;
        }


        void MontaProtocolo(System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Carrega parametros
            BLLParametros param = new BLLParametros();
            Parametros modelo = param.CarregaModeloParametros(1);

            // fill page with text
            Rectangle rc = e.MarginBounds;
            rc.Height = _font.Height + 10;


            int ln = 1;
            int col = 2;

            DateTime? Data_Entrega = default(DateTime);
            int qtde = 0;
            int totItens = 0;
            int RegAtual;
            Decimal Valor = 0.0M;
            Decimal totValor = 0.0M;

            Graphics g = e.Graphics;
            //g.FillRectangle(new SolidBrush(Color.GreenYellow), 0, 0, 340, e.MarginBounds.Height);


            //g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality

            Font fonteTiket = new Font("Courier New", 10, System.Drawing.GraphicsUnit.Point);

            string p = string.Format("{0,0:000000}", txtId.Text);
            string np = "";
            foreach (char c in p)
            {
                np += c + " ";
            }
            g.DrawString(string.Format("PEDIDO: ** {0:s}**            DATA:{1:dd/MM/yyyy}", np, DateTime.Now), fonteTiket, Brushes.Black, col, ln);
            //g.DrawString("Data:" & Format(Now(), "dd/MM/yyyy"), fonteTiket, Brushes.Black, col + 190, ln - 5)
            ln += 10;
            //                      1         2         3         4
            //             12345678901234567890123456789012345678901234567890
            g.DrawString("------------------------------------------------", fonteTiket, Brushes.Black, col, ln);
            ln += 18;
            g.DrawString("CLIENTE: " + Truncate(cbCliente.Text, 39), fonteTiket, Brushes.Black, col, ln);
            ln += 15;
            g.DrawString("   Tel.: " + lblTelefone.Text, fonteTiket, Brushes.Black, col, ln);
            ln += 15;
            g.DrawString("------------------------------------------------", fonteTiket, Brushes.Black, col, ln);
            ln += 15;
            g.DrawString("ÍTEM DESCRIÇÃO              QTD", fonteTiket, Brushes.Black, col, ln);
            ln += 15;

            RegAtual = 0;
            foreach (DataRow row in dtItens.Rows)
            {
                Data_Entrega = Convert.ToDateTime(row.ItemArray[5]);
                qtde = Convert.ToInt32(row.ItemArray[6]);
                totItens += qtde;
                Valor = Convert.ToDecimal(row.ItemArray[8]);
                totValor += Valor;
                g.DrawString(string.Format("{0,3:D}  {1,-22:s} {2,3:D}",
                    Convert.ToInt32(row.ItemArray[3]),
                    Truncate(Convert.ToString(row.ItemArray[4]), 22),
                    qtde), fonteTiket, Brushes.Black, col, ln);

                int lo, ld;
                string linha;
                string[] mLado = { "Esq", "Dir" };

                lo = Convert.ToInt32(row.ItemArray[9]);
                ld = Convert.ToInt32(row.ItemArray[10]);

                linha = "";
                if (lo != -1)
                {
                    linha = "Local:" + rg_local.Properties.Items[lo].Description + "  ";
                }
                if (ld != -1)
                {
                    linha += "     Lado:" + mLado[ld];
                }
                if (!string.IsNullOrEmpty(linha))
                {
                    ln += 12;
                    g.DrawString(linha, fonteTiket, Brushes.Black, col, ln);
                }
                linha = Convert.ToString(row.ItemArray[11]);
                string[] aLinhas = linha.Split(new[] { '\n', '\t' });
                int i, j;
                for (i = 0; i < aLinhas.Length; i++)
                {
                    if (aLinhas[i] != "")
                    {
                        //ln += 15;
                        //g.DrawString("   => ", fonteTiket, Brushes.Black, col, ln);
                        List<string> lista = SplitString(43, aLinhas[i]);

                        for (j = 0; j < lista.Count; j++)
                        {
                            ln += 15;
                            g.DrawString("     " + lista[j], fonteTiket, Brushes.Black, col, ln);
                        }
                        ln += 15;
                        //ln += ((aLinhas.Length - 1) * 12);
                    }

                }
                ln += 20;
                RegAtual += 1;
            }

            g.DrawString("------------------------------------------------", fonteTiket, Brushes.Black, col, ln);
            ln += 15;
            Data_Entrega = dtpData_Entrega.Value; //primeiro ítem
            g.DrawString(String.Format(" Entrega:{0:dd/MM/yyyy(ddd)} a partir de {1:HH:mm}", Data_Entrega, Data_Entrega), fonteTiket, Brushes.Black, col, ln);
            ln += 35;
            if (ckbPAGO.Checked)
            {
                g.DrawString(String.Format("( X ) PAGO      (   ) NÃO PAGO"), fonteTiket, Brushes.Black, col + 80, ln);
            }
            else
            {
                g.DrawString(String.Format("(   ) PAGO      ( X ) NÃO PAGO"), fonteTiket, Brushes.Black, col + 80, ln);
            }
            ln += 35;
            g.DrawString("================================================", fonteTiket, Brushes.Black, col, ln);
            ln += 80;
            g.DrawString(".", fonteTiket, Brushes.Black, col, ln);
        }

        #endregion

        private DateTime UltimoDoDia(DateTime dia, int pedido_id)
        {
            BLLAgendaPedido bll = new BLLAgendaPedido();
            bll.ExcluirPorPedido(pedido_id);   // apaga inicialmente qualquer entrada do pedido 
            DataTable dt;
            dt = bll.CarregaUltimaEntrada(dia);
            if (dt.Rows.Count == 0)
            {
                return Convert.ToDateTime(string.Format("{0:dd/MM/yyyy 07:59}", dia));
            }
            else
                return Convert.ToDateTime(dt.Rows[0].ItemArray[8]);
        }

        private void ApagaAgenda(int pedido_id)
        {
            BLLAgendaPedido bll = new BLLAgendaPedido();
            bll.ExcluirPorPedido(pedido_id);
        }

        private void GravaAgenda(int pedido_id)
        {
            if (gvItens.FocusedRowHandle < 0) return;
            DateTime dtI;

            BLLAgendaPedido bll = new BLLAgendaPedido();
            AgendaPedido modelo = new AgendaPedido();

            modelo = bll.EntradaDoPedido(pedido_id); // se não existir vem nulo

            if (modelo.pedido_id == 0)
            {
                modelo.pedido_id = pedido_id;
                modelo.location = "0";
                modelo.status = 2;

            }
            modelo.subject = string.Format("[{0:d}]{1:s}",txtTot_Pecas.Text,cbCliente.Text);
            modelo.description = gvItens.GetDataRow(0).ItemArray[1].ToString();
            modelo.location = Convert.ToString (pedido_id);

            dtI = UltimoDoDia(dtpData_Entrega.Value, pedido_id);

            modelo.start = dtI.AddMinutes(1); 
            modelo.end = dtI.AddMinutes(10);
            bll.Incluir(modelo); 
        }

        private void Gravar()
        {
            int idAtual;

            try
            {
                //leitura dos dados
                Cliente modeloCliente = new Cliente();
                Pedido modelo = new Pedido(modeloCliente);
                ItemCollection modeloItens = new ItemCollection();
                PedidoTelaParaModelo(modelo);
                ItensTelaParaModelo(modeloItens);
                modelo.Itens = modeloItens;


                //objeto para gravar os dados no bd
                BLLPedido bll = new BLLPedido();

                if (modelo.id == 0)
                {
                    //cadastrar novo grupo
                    bll.Incluir(modelo);
                    idAtual = modelo.id;
                    MessageBox.Show("Pedido Inserido. Id=" + modelo.id.ToString());
                    Filtrar(idAtual);
                }
                else
                {
                    //alerar um pedido
                    idAtual = Convert.ToInt32(txtId.Text);
                    modelo.id = Convert.ToInt32(txtId.Text);
                    bll.Altera(modelo);
                    if (chkMensal.Checked)
                    {
                        ApagaAgenda(idAtual);
                    }
                    else
                    {
                        //Gravar agenda ...
                        GravaAgenda(idAtual);
                    }
                    Filtrar(idAtual);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnGravar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Gravar();
            alterabotoes(2);
        }

        private void btnInserir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.operacao = "inserir";
            LimpaTela(true);
            this.alterabotoes(2);
            cbCliente.Focus();
        }

        private void dtpData_Entrega_TextChanged(object sender, EventArgs e)
        {
            if (gvItens.RowCount > 0 && gvItens.FocusedRowHandle > 0)
            {
                lblDiaSemana.Text = String.Format("({0:dddd})", dtpData_Entrega.Value);
                _ItemChanged(gvItens.FocusedRowHandle);
            }
        }

        private void scc1_SplitterPositionChanged(object sender, EventArgs e)
        {
            scc1.Panel2.Enabled = true;
        }

        private void Desconto_ValueChanged(object sender, EventArgs e)
        {
            CalculaTotais();
        }

        private void txtAmortizacao_ValueChanged(object sender, EventArgs e)
        {
            CalculaTotais();
        }

        private void AdicionaItem()
        {
            mPodeAlterar = true;

            DataRow row = dtItens.NewRow(); 
            UltimoItem = dtItens.Rows.Count - 1;
            gvItens.SelectRow(UltimoItem);
            gvItens.FocusedRowHandle = UltimoItem;
            LimpaTela(false);
            row[0] = UltimoItem + 1;
            row[1] = "TESTE";
            dtItens.Rows.Add(row);
            txtDescricao.Text = "";
            txtBordado_Descricao.Focus();
            btnGravar.Enabled = true;
            dtItens.Rows[0].BeginEdit();
            dtItens.Rows[0].ItemArray[1] = "TESTE NOVO";
            dtItens.Rows[0].EndEdit();
            gvItens.RefreshData();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionaItem();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //if (dgItensO.CurrentRow.Index < 0) return;

            //dgItensO.Rows.Remove(dgItensO.CurrentRow);
            //if (dgItensO.CurrentRow.Index < 0) return;

            //int LinhaGrade;

            //for (LinhaGrade = dgItensO.CurrentRow.Index; LinhaGrade < dgItensO.Rows.Count; LinhaGrade++)
                //dgItensO.Rows[LinhaGrade].Cells[0].Value = LinhaGrade + 1;
            //btnGravar.Enabled = true;
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            int LinhaAtualNr, LinhaNovaNr, Coluna;
            object Valor;
            //LinhaAtualNr = dgItensO.CurrentRow.Index;
            //if (LinhaAtualNr > 0)
            //{
                //LinhaNovaNr = dgItensO.CurrentRow.Index - 1;
                //for (Coluna = 1; Coluna < dgItensO.ColumnCount; Coluna++)
                //{
                    //if (dgItensO.Columns[Coluna].Name == "preco" ||
                        //dgItensO.Columns[Coluna].Name == "Tot_Item")
                        //Valor = String.Format("{0:N2}", dgItensO.Rows[LinhaNovaNr].Cells[Coluna].Value);
                    //else
                        //Valor = dgItensO.Rows[LinhaNovaNr].Cells[Coluna].Value;

                    //dgItensO.Rows[LinhaNovaNr].Cells[Coluna].Value = dgItensO.Rows[LinhaAtualNr].Cells[Coluna].Value;
                    //dgItensO.Rows[LinhaAtualNr].Cells[Coluna].Value = Valor;
                //}
                //dgItensO.CurrentCell = dgItensO.Rows[LinhaNovaNr].Cells[0];
                //dgItensO.Focus();

                //LinhaAtualNr = dgItensO.CurrentRow.Index;
                btnGravar.Enabled = true;
            //}
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            int LinhaAtualNr, LinhaNovaNr, Coluna;
            object Valor;
            //LinhaAtualNr = dgItensO.CurrentRow.Index;
            //if (LinhaAtualNr < dgItensO.RowCount - 1)
            {
                //LinhaNovaNr = dgItensO.CurrentRow.Index + 1;
                //for (Coluna = 1; Coluna < dgItensO.ColumnCount - 1; Coluna++)
                //{
                    //if (dgItensO.Columns[Coluna].Name == "preco" ||
                        //dgItensO.Columns[Coluna].Name == "Tot_Item")
                        //Valor = String.Format("{0:N2}", dgItensO.Rows[LinhaNovaNr].Cells[Coluna].Value);
                    //else
                        //Valor = dgItensO.Rows[LinhaNovaNr].Cells[Coluna].Value;

                    //dgItensO.Rows[LinhaNovaNr].Cells[Coluna].Value = dgItensO.Rows[LinhaAtualNr].Cells[Coluna].Value;
                    //dgItensO.Rows[LinhaAtualNr].Cells[Coluna].Value = Valor;
                //}
                //dgItensO.CurrentCell = dgItensO.Rows[LinhaNovaNr].Cells[0];
                //dgItensO.Focus();

                //LinhaAtualNr = dgItensO.CurrentRow.Index;
                btnGravar.Enabled = true;
            }
        }

        private void txtBordado_Descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtBordado_Descricao.Text == ".")
                {
                    //int id = 0;

                    //CarregaBordado(id);

                    //My.Settings.Pesquisa_Resultado = nudBordado_Id.Value
                    txtPC_Solicitadas.Focus();
                 }
                else
                {
                    dlgSelecionaBordado f = new GUI.dlgSelecionaBordado();
                    f.FiltrarBordados(txtBordado_Descricao.Text);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        nudBordado_Id.Value = f.modeloBordado.id;
                        txtBordado_Pontos.Value = f.modeloBordado.pontos;
                        txtBordado_Preco.Value = f.modeloBordado.preco;
                        txtBordado_Arquivo.Text = f.modeloBordado.arquivo;
                        txtBordado_Descricao.Text = f.modeloBordado.descricao;
                        //Carrega a Imagem
                        byte[] img = (byte[])f.modeloBordado.imagem;

                        if (img != null)
                        {
                            MemoryStream ms = new MemoryStream(img);
                            picBordado.Image = Image.FromStream(ms);
                            ms.Dispose();
                        }
                        txtPC_Solicitadas.Focus();
                    }
                }
            }
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            int LinhaGrade, NovoItem;

            if (gvItens.FocusedRowHandle < 0) return;
            //NovoItem = dgItensO.CurrentRow.Index + 1;
            //dgItensO.Rows.Insert(NovoItem);

            //for (LinhaGrade = NovoItem; LinhaGrade < dgItensO.Rows.Count - 1; LinhaGrade++)
            //    dgItensO.Rows[LinhaGrade].Cells["Item"].Value = LinhaGrade + 1;
            //dgItensO.CurrentCell = dgItensO.Rows[NovoItem].Cells[0];

            LimpaTela(false);
            //dgItensO.Rows[NovoItem].Cells["Descricao"].Value = LinhaGrade + 1;
            txtDescricao.Text = "";

            txtBordado_Descricao.Focus();
            //mAtualizarGradeItens = true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string caixa;
            double mPago, mSaldo;
            int pedido_atual = Convert.ToInt32(txtId.Text);
            int linha_atual = gvRegistros.FocusedRowHandle;

            if (MessageBox.Show("Confirma a baixa do pedido: " + txtId.Text + "?",
                                "Baixa de Pedido",
                                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (this.cbQuitado.Checked && chkExecutado.Checked)
            {
                MessageBox.Show("Pedido já finalizado!",
                                "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop,
                                MessageBoxDefaultButton.Button1);
                return;
            }

            dePagamento.EditValue = DateTime.Now;
            mPago = Pago.Value;
            mSaldo = Saldo.Value;
            caixa = String.Format("{0:N2}", mSaldo);
            Pago.Text = String.Format("{0:N2}", mPago + mSaldo);
            Saldo.Text = "0,00";
            ckbPAGO.Checked = true;
            cbQuitado.Checked = true;
            chkExecutado.Checked = true;

            operacao = "Alterar";
            Gravar(); //Efetiva a baixa

            //Baixa na agenda
            BLLAgendaPedido bll = new BLLAgendaPedido();
            bll.AlteraSituacao(pedido_atual, 0);

            if (chkFiltroExecutado.Checked)
            {
                MessageBox.Show("Pedido Finalizado.");
                Filtrar(pedido_atual);
            }
            else
            {
                MessageBox.Show("Pedido Finalizado. Após pressionar <Ok> este pedido não será mostrado!");
                Filtrar(Convert.ToInt32(gvRegistros.GetDataRow(linha_atual).ItemArray[0])) ;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (txtBordado_Descricao.Text != ".")
            {
                txtPreco_Por_Peca.Text = txtBordado_Preco.Text;
                txtDescricao.Text = txtBordado_Descricao.Text;
             }
            txtPreco_Por_Peca.Focus();
        }

        private void chkFiltroMensal_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFiltroMensal.Checked && !chkFiltroDemais.Checked)
            {
                MessageBox.Show("Pelo menos uma das opções deve ser selecionada!");
                chkFiltroMensal.Checked = !chkFiltroMensal.Checked;
            }
            else
            {
                Filtrar();
            }
        }

        private void chkFiltroDemais_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFiltroMensal.Checked && !chkFiltroDemais.Checked)
            {
                MessageBox.Show("Pelo menos uma das opções deve ser selecionada!");
                chkFiltroDemais.Checked = !chkFiltroDemais.Checked;
            }
            else
            {
                Filtrar();
            }
        }

        private void chkFiltroExecutado_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFiltroExecutado.Checked && !chkFiltroNaoExecutado.Checked)
            {
                MessageBox.Show("Pelo menos uma das opções deve ser selecionada!");
                chkFiltroExecutado.Checked = !chkFiltroExecutado.Checked;
            }
            else
            {
                Filtrar();
            }
        }

        private void chkFiltroNaoExecutado_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFiltroExecutado.Checked && !chkFiltroNaoExecutado.Checked)
            {
                MessageBox.Show("Pelo menos uma das opções deve ser selecionada!");
                chkFiltroNaoExecutado.Checked = !chkFiltroNaoExecutado.Checked;
            }
            else
            {
                Filtrar();
            }
        }

        private void chkFiltroQuitado_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFiltroQuitado.Checked && !chkFiltroNaoQuitado.Checked)
            {
                MessageBox.Show("Pelo menos uma das opções deve ser selecionada!");
                chkFiltroQuitado.Checked = !chkFiltroQuitado.Checked;
            }
            else
            {
                Filtrar();
            }
        }

        private void chkFiltroNaoQuitado_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFiltroQuitado.Checked && !chkFiltroNaoQuitado.Checked)
            {
                MessageBox.Show("Pelo menos uma das opções deve ser selecionada!");
                chkFiltroNaoQuitado.Checked = !chkFiltroNaoQuitado.Checked;
            }
            else
            {
                Filtrar();
            }
        }

        private void txtPC_Solicitadas_ValueChanged(object sender, EventArgs e)
        {
            txtPC_Entregues.Text = txtPC_Solicitadas.Text;
            _PcChanged();
        }

        private void txtPC_Solicitadas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPC_Entregues.Text = txtPC_Solicitadas.Text;
                if (txtBordado_Descricao.Text == ".")
                    txtPreco_Por_Peca.Focus();
                else
                    btnImportar.Focus();
            }
        }

        private void _PcChanged()
        {
            if (gvItens.RowCount < 1)
            {
                dtItens.Rows.Add();
                UltimoItem = dtItens.Rows.Count - 1;
                dtItens.Rows[dtItens.Rows.Count - 1].ItemArray[0] = dtItens.Rows.Count;
            }

            txtPC_Bordadas.Text = txtPC_Entregues.Text;

            
            //txtTotal_Item.Text = String.Format("{0:N2}", Val(txtPC_Bordadas.Text) * Val(txtPreco_Por_Peca.Text.Replace(",", ".")))
            _ItemChanged(UltimoItem);
            CalculaTotais();
        }

        private void _ItemChanged(int linha)
        {
            ItemTelaParaGrade(linha);
            _TextChanged();
        }

        private void _TextChanged()
        {
            if (mPodeAlterar)
                if (txtId.Text != "")
                {
                    btnGravar.Enabled = true;
                    btnImprimir.Enabled = true;
                }
        }

        private void txtPreco_Por_Peca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBordado_Descricao.Text == ".")
                    txtDescricao.Focus();
                else
                    dtpData_Entrega.Focus();
            }
        }

        private void txtPreco_Por_Peca_ValueChanged(object sender, EventArgs e)
        {
            _PcChanged();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            _PcChanged();
        }

        private void MaisNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescricao.Text += " + Nome";
        }

        private void MaisFuncaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = txtDescricao.Text.Length + 3;
            txtDescricao.Text += " + Função ";
            txtDescricao.SelectionStart = i;
            txtDescricao.SelectionLength = 6;
            txtDescricao.Focus();
        }

        private void MaisNomeFuncaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescricao.Text += " + Nome + Função";
        }

        private void SelecionaCliente()
        {
            dlgSelecionaCliente f = new dlgSelecionaCliente();

            f.FiltrarClientes(cbCliente.Text);
            if (f.ShowDialog() == DialogResult.OK)
            {
                cbCliente.SelectedValue = f.modeloCliente.id;
            }
            txtPC_Solicitadas.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SelecionaCliente();
        }

        private void cbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SelecionaCliente();
            }
        }

        private void cbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (e.KeyChar == '?') SelecionaCliente();
        }

        private void gvRegistros_DoubleClick(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
        }

        private void gvRegistros_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvRegistros.RowCount < 1) return;
            if (gvItens.RowCount > 0) Carrega_Item(0); // mostra 1o item
            ExibeItens(e.FocusedRowHandle);
            CalculaTotais(); 
        }

        private void gvItens_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (UltimoItem != e.FocusedRowHandle) Carrega_Item(e.FocusedRowHandle);
            UltimoItem = e.FocusedRowHandle;
        }
    }
}

